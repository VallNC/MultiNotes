using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ImageForm : Form
    {
        public ImageForm(Image image)
        {
            InitializeComponent();
            pictureBox1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
