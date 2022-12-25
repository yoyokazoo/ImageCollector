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

namespace ImageCollector
{
    public partial class FormImageProcessing : Form
    {
        private ImageProcessingProfile profile; // todo: ISaveableProfile to help with menu bar refactoring?

        public FormImageProcessing()
        {
            InitializeComponent();
        }

        private void ImageProcessingForm_Load(object sender, EventArgs e)
        {
            CreateNewProfile();
        }

        private void CreateNewProfile()
        {
            profile = new ImageProcessingProfile();
            UpdateControlsFromProfile();
        }

        #region Menu Strip
        // todo: once the shape of this program is more fleshed out, figure out a way to share this functionality

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
            if(profile.IsProfileUnsaved())
            {
                var confirmResult = MessageBox.Show("You have unsaved changes, would you like to proceed?",
                                     "Unsaved Changes",
                                     MessageBoxButtons.YesNo);

                return confirmResult == DialogResult.Yes;
            }

            return true;
        }

        #endregion

        #region Saving/Loading

        private void UpdateControlsFromProfile()
        {
            textBoxInputFolder.Text = profile.InputFolderPath;
            textBoxOutputFolder.Text = profile.OutputFolderPath;

            textBoxOffsetX.Text = profile.OffsetX.ToString();
            textBoxOffsetY.Text = profile.OffsetY.ToString();

            textBoxWidth.Text = profile.Width.ToString();
            textBoxHeight.Text = profile.Height.ToString();

            textBoxStepX.Text = profile.StepX.ToString();
            textBoxStepY.Text = profile.StepY.ToString();

            textBoxRepeatColumns.Text = profile.RepeatColumns.ToString();
            textBoxRepeatRows.Text = profile.RepeatRows.ToString();

            textBoxAltRowX.Text = profile.AlternatingRowOffsetX.ToString();
            textBoxAltRowY.Text = profile.AlternatingRowOffsetY.ToString();
        }

        private void FormImageProcessing_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ConfirmUnsavedChangesAction();
        }

        #endregion

        #region Profile Updates

        private void buttonChooseInputFolder_Click(object sender, EventArgs e)
        {
            profile.InputFolderPath = SelectFolder(folderBrowserDialogInput, textBoxInputFolder);
        }

        private void buttonChooseOutputFolder_Click(object sender, EventArgs e)
        {
            profile.OutputFolderPath = SelectFolder(folderBrowserDialogOutput, textBoxOutputFolder);
        }

        private string SelectFolder(FolderBrowserDialog browserDialog, TextBox pathTextBox)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            browserDialog.SelectedPath = currentDirectory;

            DialogResult result = browserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pathTextBox.Text = browserDialog.SelectedPath;
            }

            return browserDialog.SelectedPath;
        }

        protected void OffsetX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxOffsetX.Text, out int parseResult);
            profile.OffsetX = parseResult;
        }

        protected void OffsetY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxOffsetY.Text, out int parseResult);
            profile.OffsetY = parseResult;
        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWidth.Text, out int parseResult);
            profile.Width = parseResult;
        }

        private void textBoxHeight_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxHeight.Text, out int parseResult);
            profile.Height = parseResult;
        }

        protected void StepX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxStepX.Text, out int parseResult);
            profile.StepX = parseResult;
        }

        protected void StepY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxStepY.Text, out int parseResult);
            profile.StepY = parseResult;
        }

        protected void RepeatColumns_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxRepeatColumns.Text, out int parseResult);
            profile.RepeatColumns = parseResult;
        }

        protected void RepeatRows_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxRepeatRows.Text, out int parseResult);
            profile.RepeatRows = parseResult;
        }

        protected void AlternatingRowOffsetX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxAltRowX.Text, out int parseResult);
            profile.AlternatingRowOffsetX = parseResult;
        }

        protected void AlternatingRowOffsetY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxAltRowY.Text, out int parseResult);
            profile.AlternatingRowOffsetY = parseResult;
        }


        #endregion

        private void buttonPreview_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(profile.InputFolderPath))
            {
                Console.WriteLine("You need to specify an input folder!");
                return;
            }

            ImageProcessingPreviewForm processingPreviewForm = new ImageProcessingPreviewForm(profile);
            processingPreviewForm.ShowDialog();

            UpdateControlsFromProfile();
        }

        // TODO: check that directories actually exist before running -- if the output folder gets renamed for example
        // you'll get a generic GDI exception
        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(profile.InputFolderPath) || string.IsNullOrEmpty(profile.OutputFolderPath))
            {
                Console.WriteLine("You need to specify an input and output folder!");
                return;

            }

            List<Rectangle> rectangles = profile.GetRectangles();
            var files = Directory.GetFiles(profile.InputFolderPath);
            int sliceIndex = 0;

            foreach(var file in files)
            {
                Bitmap sourceBitmap = new Bitmap(file);

                foreach (Rectangle r in rectangles)
                {
                    string imagePath = Path.Combine(profile.OutputFolderPath, $"Slice_{sliceIndex}.bmp");

                    Bitmap destinationBitmap = sourceBitmap.Clone(r, System.Drawing.Imaging.PixelFormat.Undefined);
                    destinationBitmap.Save(imagePath, ImageFormat.Bmp);
                    destinationBitmap.Dispose();

                    sliceIndex++;
                }

                sourceBitmap.Dispose();
            }
        }
    }
}
