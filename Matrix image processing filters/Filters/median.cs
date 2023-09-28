using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Ex11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog1.FileName;
                    Bitmap fileImage =
                    new Bitmap(filePath);
                    pictureBox1.Image = fileImage;
                }
            }
            catch
            {
                MessageBox.Show("Error Reading of JPG-File!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //rezkost
            Bitmap FI = new Bitmap(pictureBox1.Image);
            int m = FI.Width; int n = FI.Height;
            Bitmap OutputImage = new Bitmap(m, n);
            for (int i = 1; i < m - 1; i++)
                for (int j = 1; j < n - 1; j++)
                {
                    int[] Color_of_pixelR = new int[9]
                    {
                    FI.GetPixel(i-1,j-1).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R,
                    FI.GetPixel(i,j-1).R,FI.GetPixel(i,j).R,FI.GetPixel(i,j+1).R,
                    FI.GetPixel(i+1,j-1).R,FI.GetPixel(i+1,j).R,FI.GetPixel(i+1,j+1).R
                    };
                    Array.Sort(Color_of_pixelR);
                    int nR = Color_of_pixelR[5];
                    int[] Color_of_pixelG = new int[9]
                    {
                    FI.GetPixel(i-1,j-1).G,FI.GetPixel(i-1,j).G,FI.GetPixel(i-1,j+1).G,
                    FI.GetPixel(i,j-1).G,FI.GetPixel(i,j).G,FI.GetPixel(i,j+1).G,
                    FI.GetPixel(i+1,j-1).G,FI.GetPixel(i+1,j).G,FI.GetPixel(i+1,j+1).G
                    };
                    Array.Sort(Color_of_pixelG);
                    int nG = Color_of_pixelG[5];
                    int[] Color_of_pixelB = new int[9]
                    {
                    FI.GetPixel(i-1,j-1).B,FI.GetPixel(i-1,j).B,FI.GetPixel(i-1,j+1).B,
                    FI.GetPixel(i,j-1).B,FI.GetPixel(i,j).B,FI.GetPixel(i,j+1).B,
                    FI.GetPixel(i+1,j-1).B,FI.GetPixel(i+1,j).B,FI.GetPixel(i+1,j+1).B
                    };
                    Array.Sort(Color_
                    of_pixelR);
                    int nB = Color_of_pixelB[5];
                    Color new_Color_Of_Pixel = Color.FromArgb( nR, nG, nB);
                    OutputImage.SetPixel(i, j, new_Color_Of_Pixel);
                }
            pictureBox2.Image = OutputImage;
        }
    }
}