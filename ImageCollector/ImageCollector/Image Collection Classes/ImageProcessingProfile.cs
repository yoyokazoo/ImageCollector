using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace ImageCollector
{
    public class ImageProcessingProfile
    {
        [JsonIgnore]
        public ImageProcessingProfile initialProfile = null;

        public string InputFolderPath { get; set; }
        public string OutputFolderPath { get; set; }
        public string SourceImagePath { get; set; }

        // Offset from top left corner of the window
        public int OffsetX { get; set; }
        public int OffsetY { get; set; }

        // Width and height of slices
        public int Width { get; set; }
        public int Height { get; set; }

        // Each snapshot should be offset by this value.  Only increment StepX when in the same row,
        // only increment StepY when switching rows
        // Possible we need a ColumnStepX and ColumnStepY and a RowStepX and RowStepY separately for different patterns
        // but we'll cross that bridge when we come to it
        public int StepX { get; set; }
        public int StepY { get; set; }

        // How many images to capture in rows/columns
        public int RepeatColumns { get; set; }
        public int RepeatRows { get; set; }

        // If we have some sort of honeycomb pattern, X/Y values should go:
        // 0, AlternatingRowOffsetX, 0, AlternatingRowOffsetX, 0, etc.
        // 0, AlternatingRowOffsetY, 0, AlternatingRowOffsetY, 0, etc.
        public int AlternatingRowOffsetX { get; set; }
        public int AlternatingRowOffsetY { get; set; }

        public string MostRecentPreviewFilePath { get; set; }

        public ImageProcessingProfile()
        {
            initialProfile = null;

            InputFolderPath = null;
            OutputFolderPath = null;
            SourceImagePath = null;

            OffsetX = 0;
            OffsetY = 0;

            Width = 0;
            Height = 0;

            StepX = 0;
            StepY = 0;
            
            RepeatColumns = 0;
            RepeatRows = 0;
            
            AlternatingRowOffsetX = 0;
            AlternatingRowOffsetY = 0;

            MostRecentPreviewFilePath = null;
        }

        public void Save()
        {
            Stream fileStream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "ImageProcessingProfile files (*.ipp)|*.ipp|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveFileDialog.OpenFile()) != null)
                {
                    JsonSerializer serializer = new JsonSerializer();

                    // TODO: This looks like it stinks!
                    using (var sw = new StreamWriter(fileStream))
                    {
                        using (var jsonTextWriter = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(jsonTextWriter, this);
                        }
                    }
                }
            }

            // reset initial state so we can tell if we have unsaved changes
            this.initialProfile = this.Clone();
        }

        public static ImageProcessingProfile Open()
        {
            Stream fileStream;
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "ImageProcessingProfile files (*.ipp)|*.ipp|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = openFileDialog.OpenFile()) != null)
                {
                    // TODO: this looks like it SUPER STINKS
                    using (StreamReader file = new StreamReader(fileStream))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        ImageProcessingProfile newProfile = (ImageProcessingProfile)serializer.Deserialize(file, typeof(ImageProcessingProfile));
                        newProfile.initialProfile = newProfile.Clone();

                        return newProfile;
                    }
                }
            }

            return new ImageProcessingProfile();
        }

        public ImageProcessingProfile Clone()
        {
            ImageProcessingProfile newProfile = new ImageProcessingProfile();

            newProfile.InputFolderPath = this.InputFolderPath;
            newProfile.OutputFolderPath = this.OutputFolderPath;
            newProfile.SourceImagePath = this.SourceImagePath;
            newProfile.OffsetX = this.OffsetX;
            newProfile.OffsetY = this.OffsetY;
            newProfile.Width = this.Width;
            newProfile.Height = this.Height;
            newProfile.StepX = this.StepX;
            newProfile.StepY = this.StepY;
            newProfile.RepeatColumns = this.RepeatColumns;
            newProfile.RepeatRows = this.RepeatRows;
            newProfile.AlternatingRowOffsetX = this.AlternatingRowOffsetX;
            newProfile.AlternatingRowOffsetY = this.AlternatingRowOffsetY;
            newProfile.MostRecentPreviewFilePath = this.MostRecentPreviewFilePath;

            return newProfile;
        }

        public bool IsProfileUnsaved()
        {
            return !this.Equals(initialProfile);
        }

        public override bool Equals(object otherObj)
        {
            var otherProfile = (ImageProcessingProfile)otherObj ?? new ImageProcessingProfile();

            if(!string.Equals(this.InputFolderPath, otherProfile.InputFolderPath) ||
               !string.Equals(this.OutputFolderPath, otherProfile.OutputFolderPath) ||
               !string.Equals(this.SourceImagePath, otherProfile.SourceImagePath) ||
               this.OffsetX != otherProfile.OffsetX ||
               this.OffsetY != otherProfile.OffsetY ||
               this.Width != otherProfile.Width ||
               this.Height != otherProfile.Height ||
               this.StepX != otherProfile.StepX ||
               this.StepY != otherProfile.StepY ||
               this.RepeatColumns != otherProfile.RepeatColumns ||
               this.RepeatRows != otherProfile.RepeatRows ||
               this.AlternatingRowOffsetX != otherProfile.AlternatingRowOffsetX ||
               this.AlternatingRowOffsetY != otherProfile.AlternatingRowOffsetY ||
               this.MostRecentPreviewFilePath != otherProfile.MostRecentPreviewFilePath)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // TODO: AlternatingRowOffsetY not implemented
        // TODO: endingX/endingY
        public List<Rectangle> GetRectangles()
        {
            List<Rectangle> rectangles = new List<Rectangle>();

            int startingY = OffsetY;
            int endingY = startingY + Height;

            for (int row = 0; row < RepeatRows; row++)
            {
                // set up X for new row
                int startingX = OffsetX;
                startingX += AlternatingRowOffsetX * (row % 2); // every other row, alternate by X
                int endingX = startingX + Width;

                for (int column = 0; column < RepeatColumns; column++)
                {
                    Rectangle newRect = new Rectangle(startingX, startingY, Width, Height);
                    rectangles.Add(newRect);

                    startingX = endingX;
                    startingX += StepX;
                    endingX = startingX + Width;
                }

                startingY = endingY;
                startingY += StepY;
                endingY = startingY + Height;
            }

            return rectangles;
        }
    }
}
