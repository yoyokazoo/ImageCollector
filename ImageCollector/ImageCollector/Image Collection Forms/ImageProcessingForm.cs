using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string test = ScreenCapture.SelectFolder(folderBrowserDialog, textBoxSourceImage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string test = ScreenCapture.SelectFolder(folderBrowserDialog, textBoxOutputFolder);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
