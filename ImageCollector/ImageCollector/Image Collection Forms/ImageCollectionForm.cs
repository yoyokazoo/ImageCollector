using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
