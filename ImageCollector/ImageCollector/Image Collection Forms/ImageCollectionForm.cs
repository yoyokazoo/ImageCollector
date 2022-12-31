using ImageCollector.Image_Collection_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCollector
{
    public partial class ImageCollectionForm : Form
    {
        public ImageCollectionForm()
        {
            InitializeComponent();
        }

        private void buttonListProcessNames_Click(object sender, EventArgs e)
        {
            ScreenCapture.ListAllRunningProcesses();
        }

        private void buttonScreenshotAllProcesses_Click(object sender, EventArgs e)
        {
            ScreenCapture.SaveTestScreenshotOfAllProcesses();
        }

        private void buttonScreenshotDesktop_Click(object sender, EventArgs e)
        {
            ScreenCapture.SaveTestDesktopScreenshot("Desktop.bmp");
        }

        private void buttonScreenshotNamedProcess_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            ScreenCapture.SaveTestScreenshotsOfAllProcessesWithName(processName);
        }

        private void buttonScreenshotAfterFocusing_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            ScreenCapture.SaveTestScreenshotOfDesktopAfterFocusing(processName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            ScreenCapture.PrintProcessProperties(processName);
        }

        private void buttonScreenshotNumProcess_Click(object sender, EventArgs e)
        {
            int processNum = int.Parse(textBoxProcessNum.Text);
            ScreenCapture.SaveTestScreenshotsOfProcessNum(processNum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int processNum = int.Parse(textBoxProcessNum.Text);
            ScreenCapture.SaveTestScreenshotOfDesktopAfterFocusing(processNum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int processNum = int.Parse(textBoxProcessNum.Text);
            ScreenCapture.PrintProcessProperties(processNum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ScreenCapture.CapturePeriodicScreenshotsOfDesktop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            IntPtr processPtr = ScreenCapture.GetWindowHandleByName(processName);
            Rectangle rect = new Rectangle(0, 0, 500, 500);
            ScreenCapture.MoveAndResizeWindow(processPtr, rect);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int processNum = int.Parse(textBoxProcessNum.Text);
            Process process = Process.GetProcessById(processNum);
            IntPtr processPtr = process.MainWindowHandle;

            Rectangle rect = new Rectangle(0, 0, 500, 500);
            ScreenCapture.MoveAndResizeWindow(processPtr, rect);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ImageProcessingForm imageProcessing = new ImageProcessingForm();
            imageProcessing.ShowDialog();
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
            profile = ImageCollectionProfile.Open();
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

        #region Profile Lifecycle
        // TODO: Some way to reuse this between forms
        // --------------------------------------------------------------------------------------------------------------------------------

        private ImageCollectionProfile profile;
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
            profile = new ImageCollectionProfile();
            UpdateControlsFromProfile();
        }

        private void ImageCollectionForm_Load(object sender, EventArgs e)
        {
            CreateNewProfile();
        }

        private void UpdateControlsFromProfile()
        {
            textBoxProcessName.Text = profile.ProcessName;
            textBoxProcessNum.Text = profile.ProcessNum.ToString();

            textBoxWindowOffsetX.Text = profile.WindowOffsetX.ToString();
            textBoxWindowOffsetY.Text = profile.WindowOffsetY.ToString();

            textBoxWindowWidth.Text = profile.WindowWidth.ToString();
            textBoxWindowHeight.Text = profile.WindowHeight.ToString();
        }

        private void ImageCollectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !ConfirmUnsavedChangesAction();
        }

        // --------------------------------------------------------------------------------------------------------------------------------
        #endregion

        private void ProcessName_TextChanged(object sender, EventArgs e)
        {
            profile.ProcessName = textBoxProcessName.Text;
        }

        private void ProcessNum_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxProcessNum.Text, out int result);
            profile.ProcessNum = result;
        }

        private void WindowOffsetX_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWindowOffsetX.Text, out int result);
            profile.WindowOffsetX = result;
        }

        private void WindowOffsetY_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWindowOffsetY.Text, out int result);
            profile.WindowOffsetY = result;
        }

        private void WindowWidth_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWindowWidth.Text, out int result);
            profile.WindowWidth = result;
        }

        private void WindowHeight_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxWindowHeight.Text, out int result);
            profile.WindowHeight = result;
        }
    }
}
