using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace ImageCollector
{
    // Rename Solution
    // Rename Project
    // Run ImageCollectionForm
    // Grab Process Name
    // Grab Screenshot to verify
    // Start passive image collection
    // Play the game! Take notes if needed

    public partial class FormImageCollection : Form
    {
        //ImageCollectionProfile profile = null;

        public FormImageCollection()
        {
            InitializeComponent();
        }

        private void ImageCollectionForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonListProcessNames_Click(object sender, EventArgs e)
        {
            ScreenCapture.ListAllRunningProcesses();
        }

        private void buttonTakeTestScreenshot_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            
            // TODO: put this in some form of validation method
            if(string.IsNullOrEmpty(processName))
            {
                
            }

            IntPtr windowHandle = ScreenCapture.GetWindowHandleByName(processName);
            if(windowHandle == IntPtr.Zero)
            {
                Console.WriteLine($"Unable to find process {processName}!");
                return;
            }

            ScreenCapture.SaveTestScreenshotsOfAllProcessesWithName(processName);
        }

        private void buttonScreenshotAllProcesses_Click(object sender, EventArgs e)
        {
            ScreenCapture.SaveTestScreenshotOfAllProcesses();
        }

        private void buttonTakeTestScreenshotDesktop_Click(object sender, EventArgs e)
        {
            ScreenCapture.SaveTestDesktopScreenshot("TestScreenshotOfDesktop.bmp");
        }

        private void buttonTakeTestScreenshotDesktopProcess_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            IntPtr processPtr = ScreenCapture.GetWindowHandleByName(processName);

            ScreenCapture.SetForegroundWindow(processPtr);

            Thread.Sleep(3000);

            ScreenCapture.SaveTestDesktopScreenshot($"TestScreenshotOfDesktop{processName}.bmp");
        }

        private void buttonPrintPropertiesOfProcess_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            IntPtr processPtr = ScreenCapture.GetWindowHandleByName(processName);

            Rectangle processWindowRect = ScreenCapture.GetWindowRectangleFromHandle(processPtr);
            Console.WriteLine($"Process window rect for {processName} is: {processWindowRect} ({processWindowRect.Location}, {processWindowRect.Size})");

            Bitmap rectangleBitmap = ScreenCapture.CaptureBitmapFromDesktopAndRectangle(processWindowRect);
            ScreenCapture.SaveBitmapToFile(rectangleBitmap, "asdfasdf.bmp");
        }

        private void buttonTakePeriodicScreenshots_Click(object sender, EventArgs e)
        {
            string processName = textBoxProcessName.Text;
            IntPtr processPtr = ScreenCapture.GetWindowHandleByName(processName);
            Rectangle processWindowRect = ScreenCapture.GetWindowRectangleFromHandle(processPtr);

            string folderPath = ScreenCapture.CreateEmptyFolder($"Periodic {processName}");

            int screenshotNum = 0;
            while(true)
            {
                string ssName = $"Periodic_{processName}_{screenshotNum}.bmp";
                string filePath = Path.Combine(folderPath, ssName);
                Bitmap rectangleBitmap = ScreenCapture.CaptureBitmapFromDesktopAndRectangle(processWindowRect);
                ScreenCapture.SaveBitmapToFile(rectangleBitmap, filePath);
                rectangleBitmap.Dispose();
                Thread.Sleep(500);
                screenshotNum++;
            }
        }

        private void buttonImageProcessing_Click(object sender, EventArgs e)
        {
            FormImageProcessing imageProcessing = new FormImageProcessing();
            imageProcessing.ShowDialog();
        }

        #region Menu Strip
        // todo: once the shape of this program is more fleshed out, figure out a way to share this functionality

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
