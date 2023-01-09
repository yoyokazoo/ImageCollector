using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace ImageCollector
{
    public class ImageProcessingProfile : SaveableProfile<ImageProcessingProfile>
    {
        static ImageProcessingProfile()
        {
            ProfileName = "ImageProcessingProfile";
            ProfileFileExtension = "ipp";
        }

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

        // If we have some sort of honeycomb pattern, X/Y values should go:
        // 0, AlternatingRowOffsetX, 0, AlternatingRowOffsetX, 0, etc.
        // 0, AlternatingRowOffsetY, 0, AlternatingRowOffsetY, 0, etc.
        public int AlternatingRowOffsetX { get; set; }
        public int AlternatingRowOffsetY { get; set; }

        public int RepeatX { get; set; }
        public int RepeatY { get; set; }

        public string SlicePrefix { get; set; }

        public bool BlowAwayFolderContents { get; set; }

        public string MostRecentPreviewFilePath { get; set; }

        public ImageProcessingProfile()
        {
            InitialProfile = null;

            InputFolderPath = null;
            OutputFolderPath = null;
            SourceImagePath = null;

            OffsetX = 0;
            OffsetY = 0;

            Width = 0;
            Height = 0;

            StepX = 0;
            StepY = 0;
            
            RepeatX = 1;
            RepeatY = 1;

            AlternatingRowOffsetX = 0;
            AlternatingRowOffsetY = 0;

            SlicePrefix = string.Empty;
            BlowAwayFolderContents = false;

            MostRecentPreviewFilePath = null;
        }

        public override ImageProcessingProfile Clone()
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
            newProfile.RepeatX = this.RepeatX;
            newProfile.RepeatY = this.RepeatY;
            newProfile.MostRecentPreviewFilePath = this.MostRecentPreviewFilePath;
            newProfile.SlicePrefix = this.SlicePrefix;
            newProfile.BlowAwayFolderContents = this.BlowAwayFolderContents;

            return newProfile;
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
               this.RepeatX != otherProfile.RepeatX ||
               this.RepeatY != otherProfile.RepeatY ||
               this.AlternatingRowOffsetX != otherProfile.AlternatingRowOffsetX ||
               this.AlternatingRowOffsetY != otherProfile.AlternatingRowOffsetY ||
               this.MostRecentPreviewFilePath != otherProfile.MostRecentPreviewFilePath ||
               !string.Equals(this.SlicePrefix, otherProfile.SlicePrefix) ||
               this.BlowAwayFolderContents != otherProfile.BlowAwayFolderContents)
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

            for (int row = 0; row < RepeatY; row++)
            {
                // set up X for new row
                int startingX = OffsetX;
                startingX += AlternatingRowOffsetX * (row % 2); // every other row, alternate by X
                int endingX = startingX + Width;

                for (int column = 0; column < RepeatX; column++)
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
