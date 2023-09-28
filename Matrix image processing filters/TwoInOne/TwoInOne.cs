using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap fileImage = new Bitmap(pictureBox1.Image);
            Bitmap fileImage2 = new Bitmap(pictureBox2.Image);
            int n = fileImage.Height; int m = fileImage2.Height;
            Bitmap OutputImage = new Bitmap(m, n);
            for (int i = 0; i < m - 3; i++)
                for (int j = 0; j < n - 3; j++)
                {
                    Color color_of_Pixel = fileImage.GetPixel(i, j);
                    Color color_of_Pixel2 = fileImage2.GetPixel(i, j);
                    Color New_color_of_Pixel = Color.FromArgb(
                    Convert.ToInt32(color_of_Pixel.R * 0.4 + color_of_Pixel2.R * 0.6),
                    Convert.ToInt32(color_of_Pixel.G * 0.4 + color_of_Pixel2.G * 0.6),
                    Convert.ToInt32(color_of_Pixel.B * 0.4 + color_of_Pixel2.B * 0.6));
                    OutputImage.SetPixel(i, j, New_color_of_Pixel);
                }
            pictureBox3.Image = OutputImage;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    Bitmap fileImage = new Bitmap(filePath);
                    pictureBox1.Image = fileImage;
                }
            }
            catch
            {
                MessageBox.Show("Error Reading of JPG-File!");
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    Bitmap fileImage = new Bitmap(filePath);
                    pictureBox2.Image = fileImage;
                }
            }
            catch
            {
                MessageBox.Show("Error Reading of JPG-File!");
            }
        }
    }
}