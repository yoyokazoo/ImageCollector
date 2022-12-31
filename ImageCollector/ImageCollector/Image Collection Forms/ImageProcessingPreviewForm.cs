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

        }
    }
}
