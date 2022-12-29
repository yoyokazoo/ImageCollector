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
            string[] inputImagePaths = Directory.GetFiles(textBoxInputFolder.Text);
            string outputImagePath = textBoxOutputFolder.Text;

            // TODO: eventually add ability to slice multiple
            Rectangle[] rectangles = new Rectangle[1];
            rectangles[0] = new Rectangle(int.Parse(textBoxLeft.Text), int.Parse(textBoxTop.Text), int.Parse(textBoxWidth.Text), int.Parse(textBoxHeight.Text));
            int sliceIndex = 0;

            foreach (var inputFilePath in inputImagePaths)
            {
                Bitmap sourceBitmap = new Bitmap(inputFilePath);

                foreach (Rectangle r in rectangles)
                {
                    string imagePath = Path.Combine(outputImagePath, $"Slice_{sliceIndex}.bmp");

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
