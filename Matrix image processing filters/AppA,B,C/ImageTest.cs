using System;
using System.Drawing;
using System.Windows.Forms;
namespace ImageTest
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void OpenFille_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    Bitmap fileImage = new Bitmap(filePath);
                    pictureBox1.Image = fileImage;
                    CreateNewImage(fileImage);
                }
            }
            catch
            {
                MessageBox.Show("Error Reading of JPG-File!");
            }
        }
        private void CreateNewImage(Bitmap InputImage)
        {
            int m = InputImage.Width, n = InputImage.Height;
            int i, j;
            Bitmap OutputImage = new Bitmap(m, n);
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Color color_of_Pixel = InputImage.GetPixel(i, j);
                    Color New_color_of_Pixel = Color.FromArgb(255 - color_of_Pixel.R,
                    255 - color_of_Pixel.G,
                    255 - color_of_Pixel.B);
                    OutputImage.SetPixel(i, j, New_color_of_Pixel);
                    pictureBox2.Image = OutputImage;
                }
            }
            Bitmap OutputImage1 = new Bitmap(m, n);
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Color color_of_Pixel = InputImage.GetPixel(i, j);
                    int new_red = color_of_Pixel.R + 30;
                    if (new_red > 255)
                    {
                        new_red = 255;
                    }
                    Color New_color_of_Pixel1 = Color.FromArgb(new_red,
                    color_of_Pixel.G,
                    color_of_Pixel.B); ;
                    OutputImage1.SetPixel(i, j, New_color_of_Pixel1);
                    pictureBox3.Image = OutputImage1;
                }
            }
            Bitmap OutputImage2 = new Bitmap(m, n); Bitmap OutputImage3 = new Bitmap(m, n); Bitmap OutputImage4 = new Bitmap(m, n);
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Color color_of_Pixel = InputImage.GetPixel(i, j);
                    Color New_color_of_Pixel2 = Color.FromArgb(color_of_Pixel.R, 0, 0);
                    Color New_color_of_Pixel3 = Color.FromArgb(0, color_of_Pixel.G, 0);
                    Color New_color_of_Pixel4 = Color.FromArgb(0, 0, color_of_Pixel.B);
                    OutputImage2.SetPixel(i, j, New_color_of_Pixel2);
                    pictureBox4.Image = OutputImage2;
                    OutputImage3.SetPixel(i, j, New_color_of_Pixel3);
                    pictureBox5.Image = OutputImage3;
                    OutputImage4.SetPixel(i, j, New_color_of_Pixel4);
                    pictureBox6.Image = OutputImage4;
                }
            }
        }
    }
}