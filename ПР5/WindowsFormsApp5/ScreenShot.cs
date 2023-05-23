using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class ScreenShot : Form
    {
        public ScreenShot()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Form1.BM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Form1.BM.Save(SFD.FileName);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
