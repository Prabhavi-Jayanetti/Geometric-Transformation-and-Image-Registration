using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_01
{
    public partial class Form1 : Form
    {
        preprocessing p = new preprocessing();
        OpenFileDialog ofd = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.LoadOriginalImage(ofd.FileName);
            pictureBox1.ImageLocation = "1bSave.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.ImageLocation = "1cSave.png";
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Correction20degrees();
            pictureBox2.ImageLocation = "20DegreeOutput.png";
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            p.Correction90degrees();
            pictureBox3.ImageLocation = "90DegreeOutput.png";
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
