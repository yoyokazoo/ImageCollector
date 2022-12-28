using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
