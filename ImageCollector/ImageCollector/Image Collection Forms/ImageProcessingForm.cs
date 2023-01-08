using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ImageCollector.Image_Collection_Forms
{
    public partial class ImageProcessingForm : Form
    {
        public ImageProcessingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string test = ScreenCapture.SelectFolder(folderBrowserDialog, textBoxInputFolder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string test = ScreenCapture.SelectBmpFile(openFileDialog, textBoxSourceImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string test = ScreenCapture.SelectFolder(folderBrowserDialog, textBoxOutputFolder);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] inputImagePaths = Directory.GetFiles(textBoxInputFolder.Text);
            string subImagePath = textBoxSourceImage.Text;

            foreach (string inputImagePath in inputImagePaths)
            {
                List<Point> matchingPoints = ImageComparison.FindSubImageCoordinates(new Bitmap(subImagePath), new Bitmap(inputImagePath));
                Console.WriteLine($"Found matching points for {subImagePath} in {inputImagePath}: {string.Join(",", matchingPoints)}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] sourceFilePaths = Directory.GetFiles(textBoxInputFolder.Text);
            string outputImagePath = textBoxOutputFolder.Text;

            // TODO: eventually add ability to slice multiple
            List<Rectangle> rectangles = profile.GetRectangles();
            int sliceIndex = 0;

            foreach (var sourceFilePath in sourceFilePaths)
            {
                Bitmap sourceBitmap = new Bitmap(sourceFilePath);

                foreach (Rectangle r in rectangles)
                {
                    string imagePath = Path.Combine(outputImagePath, $"{profile.SlicePrefix}Slice_{sliceIndex}.bmp");

                    Bitmap destinationBitmap = sourceBitmap.Clone(r, System.Drawing.Imaging.PixelFormat.Undefined);
                    destinationBitmap.Save(imagePath, ImageFormat.Bmp);
                    destinationBitmap.Dispose();

                    sliceIndex++;
                }

                sourceBitmap.Dispose();
            }
        }

        #region Profile Lifecycle
        // TODO: Some way to reuse this between forms
        // --------------------------------------------------------------------------------------------------------------------------------

        private ImageProcessingProfile profile;
        private bool CloseForm()
        {
            if (ConfirmUnsavedChangesAction())
            {
                this.Close();
                return true;
            }

            return false;
        }

        private bool ConfirmUnsavedChangesAction()
        {
            if (profile.IsProfileUnsaved())
            {
                var confirmResult = MessageBox.Show("You have unsaved changes, would you like to proceed?",
                                     "Unsaved Changes",
                                     MessageBoxButtons.YesNo);

                return confirmResult == DialogResult.Yes;
            }

            return true;
        }

        private void CreateNewProfile()
        {
            profile = new ImageProcessingProfile();
            UpdateControlsFromProfile();
        }

        private void ImageCollectionForm_Load(object sender, EventArgs e)
        {
            CreateNewProfile();
        }

        private void UpdateControlsFromProfile()
        {
            textBoxInputFolder.Text = profile.InputFolderPath;
            textBoxOutputFolder.Text = profile.OutputFolderPath;
            textBoxSourceImage.Text = profile.SourceImagePath;

            textBoxOffsetX.Text = profile.OffsetX.ToString();
            textBoxOffsetY.Text = profile.OffsetY.ToString();

            textBoxWidth.Text = profile.Width.ToString();
            textBoxHeight.Text = profile.Height.ToString();

            textBoxStepX.Text = profile.StepX.ToString();
            textBoxStepY.Text = profile.StepY.ToString();

            textBoxRepeatX.Text = profile.RepeatX.ToString();
            textBoxRepeatY.Text = profile.RepeatY.ToString();

            textBoxSlicePrefix.Text = profile.SlicePrefix;
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        #endregion

        private void OffsetX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxOffsetX.Text, out int result);
            profile.OffsetX = result;
        }

        private void OffsetY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxOffsetY.Text, out int result);
            profile.OffsetY = result;
        }

        private void Width_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWidth.Text, out int result);
            profile.Width = result;
        }

        private void Height_TestChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxHeight.Text, out int result);
            profile.Height = result;
        }

        private void StepX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxStepX.Text, out int result);
            profile.StepX = result;
        }

        private void StepY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxStepY.Text, out int result);
            profile.StepY = result;
        }

        private void RepeatX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxRepeatX.Text, out int result);
            profile.RepeatX = result;
        }

        private void RepeatY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxRepeatY.Text, out int result);
            profile.RepeatY = result;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConfirmUnsavedChangesAction())
            {
                CreateNewProfile();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile = ImageProcessingProfile.Open();
            UpdateControlsFromProfile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            profile.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void ImageProcessingForm_Load(object sender, EventArgs e)
        {
            CreateNewProfile();
        }

        private void InputFolderPath_TextChanged(object sender, EventArgs e)
        {
            profile.InputFolderPath = textBoxInputFolder.Text;
        }

        private void OutputFolderPath_TextChanged(object sender, EventArgs e)
        {
            profile.OutputFolderPath = textBoxOutputFolder.Text;
        }

        private void SourceImage_TextChanged(object sender, EventArgs e)
        {
            profile.SourceImagePath = textBoxSourceImage.Text;
        }

        private void ImageProcessingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ConfirmUnsavedChangesAction();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(profile.InputFolderPath))
            {
                Console.WriteLine("You need to specify an input folder!");
                return;
            }

            ImageProcessingPreviewForm processingPreviewForm = new ImageProcessingPreviewForm(profile);
            processingPreviewForm.ShowDialog();

            UpdateControlsFromProfile();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<Bitmap> sourceBitmaps = ScreenCapture.GetBitmapsFromInputFolderPath(profile.InputFolderPath);
            string outputImagePath = textBoxOutputFolder.Text;

            List<Tuple<Bitmap, int>> uniqueBitmaps = ImageComparison.FindUniqueBitmaps(sourceBitmaps);
            for(int i = 0; i < uniqueBitmaps.Count; i++)
            {
                int occurrences = uniqueBitmaps[i].Item2;
                uniqueBitmaps[i].Item1.Save(Path.Combine(outputImagePath, $"Unique_{occurrences}_{i}.bmp"), ImageFormat.Bmp);
                uniqueBitmaps[i].Item1.Dispose();
            }

            foreach(var bmp in sourceBitmaps)
            {
                bmp.Dispose();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string inputFolderPath = profile.InputFolderPath;
            List<Tuple<string, List<Color>>> uniqueColorCoordinates = ImageComparison.FindUniqueColorCoordinates(inputFolderPath);

            Console.WriteLine();
        }

        private void textBoxSlicePrefix_TextChanged(object sender, EventArgs e)
        {
            profile.SlicePrefix = textBoxSlicePrefix.Text;
        }
    }
}
