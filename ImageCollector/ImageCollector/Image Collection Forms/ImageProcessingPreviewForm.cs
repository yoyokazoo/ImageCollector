using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCollector.Image_Collection_Forms
{
    public partial class ImageProcessingPreviewForm : Form
    {
        private ImageProcessingProfile processingProfile;

        public ImageProcessingPreviewForm(ImageProcessingProfile _processingProfile)
        {
            processingProfile = _processingProfile;

            InitializeComponent();
        }

        private void ImageProcessingPreviewForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(processingProfile.MostRecentPreviewFilePath))
            {
                PickRandomImage();
            }
            ShowImage();
        }

        private void PickRandomImage()
        {
            var files = Directory.GetFiles(processingProfile.InputFolderPath);
            int randomIndex = new Random().Next(files.Length);
            processingProfile.MostRecentPreviewFilePath = files[randomIndex];
        }

        private void ShowImage()
        {
            Console.WriteLine($"Previewing {processingProfile.MostRecentPreviewFilePath}");

            Bitmap previewBitmap = GetPreviewMarkedUpBitmap();
            pictureBoxPreview.Image = previewBitmap;
        }

        private Bitmap GetPreviewMarkedUpBitmap()
        {
            Bitmap baseBitmap = new Bitmap(processingProfile.MostRecentPreviewFilePath);

            List<Rectangle> rectangles = processingProfile.GetRectangles();
            foreach (Rectangle r in rectangles)
            {
                DrawBox(r, baseBitmap);
            }

            return baseBitmap;
        }

        // Draw a single box by drawing four lines
        private void DrawBox(Rectangle rect, Bitmap bmp)
        {
            int startingX = rect.X;
            int startingY = rect.Y;
            int endingX = Math.Min(rect.Right, bmp.Width - 1);
            int endingY = Math.Min(rect.Bottom, bmp.Height - 1);

            for (int x = startingX; x < endingX; x++)
            {
                bmp.SetPixel(x, startingY, Color.Red);
                bmp.SetPixel(x, Math.Max(endingY - 1, 0), Color.Red);
            }
            for (int y = startingY; y < endingY; y++)
            {
                bmp.SetPixel(startingX, y, Color.Red);
                bmp.SetPixel(Math.Max(endingX - 1, 0), y, Color.Red);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            PickRandomImage();
            ShowImage();
        }

        private void buttonDecrementOffsetX_Click(object sender, EventArgs e)
        {
            processingProfile.OffsetX--;
            ShowImage();
        }

        private void buttonIncrementOffsetX_Click(object sender, EventArgs e)
        {
            processingProfile.OffsetX++;
            ShowImage();
        }

        private void buttonDecrementOffsetY_Click(object sender, EventArgs e)
        {
            processingProfile.OffsetY--;
            ShowImage();
        }

        private void buttonIncrementOffsetY_Click(object sender, EventArgs e)
        {
            processingProfile.OffsetY++;
            ShowImage();
        }

        private void buttonDecrementWidth_Click(object sender, EventArgs e)
        {
            processingProfile.Width--;
            ShowImage();
        }

        private void buttonIncrementWidth_Click(object sender, EventArgs e)
        {
            processingProfile.Width++;
            ShowImage();
        }

        private void buttonDecrementHeight_Click(object sender, EventArgs e)
        {
            processingProfile.Height--;
            ShowImage();
        }

        private void buttonIncrementHeight_Click(object sender, EventArgs e)
        {
            processingProfile.Height++;
            ShowImage();
        }

        private void buttonDecrementStepX_Click(object sender, EventArgs e)
        {
            processingProfile.StepX--;
            ShowImage();
        }

        private void buttonIncrementStepX_Click(object sender, EventArgs e)
        {
            processingProfile.StepX++;
            ShowImage();
        }

        private void buttonDecrementStepY_Click(object sender, EventArgs e)
        {
            processingProfile.StepY--;
            ShowImage();
        }

        private void buttonIncrementStepY_Click(object sender, EventArgs e)
        {
            processingProfile.StepY++;
            ShowImage();
        }

        private void buttonDecrementRepeatX_Click(object sender, EventArgs e)
        {
            processingProfile.RepeatX--;
            ShowImage();
        }

        private void buttonIncrementRepeatX_Click(object sender, EventArgs e)
        {
            processingProfile.RepeatX++;
            ShowImage();
        }

        private void buttonDecrementRepeatY_Click(object sender, EventArgs e)
        {
            processingProfile.RepeatY--;
            ShowImage();
        }

        private void buttonIncrementRepeatY_Click(object sender, EventArgs e)
        {
            processingProfile.RepeatY++;
            ShowImage();
        }
    }
}
