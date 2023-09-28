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
                    Bitmap fileImage = new Bitmap(filePath);
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
                    int[,] ColR = new int[3, 3]
                    {
                    {FI.GetPixel(i-1,j-1).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R},
                    {FI.GetPixel(i,j-1).R,FI.GetPixel(i,j).R,FI.GetPixel(i,j+1).R},
                    {FI.GetPixel(i+1,j-1).R,FI.GetPixel(i+1,j).R,FI.GetPixel(i+1,j+1).R}
                    };
                    int NewR = ColR[0, 0] * (-1) + ColR[0, 1] * (-1) + ColR[0, 2] * (-1) + ColR[1, 0] * (-1) + ColR[1, 1] * 9 + ColR[1, 2] * (-1) + ColR[2, 0] * (-1) + ColR[2, 1] * (-1) + ColR[2, 2] * (-1);
                    int[,] ColG = new int[3, 3]
                    {
                    {FI.GetPixel(i-1,j-1).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R},
                    {FI.GetPixel(i,j-1).R,FI.GetPixel(i,j).R,FI.GetPixel(i,j+1).R},
                    {FI.GetPixel(i+1,j-1).R,FI.GetPixel(i+1,j).R,FI.GetPixel(i+1,j+1).R}
                    };
                    int NewG = ColG[0, 0] * (-1) + ColG[0, 1] * (-1) + ColG[0, 2] * (-1) + ColG[1, 0] * (-1) + ColG[1, 1]
                    * 9 + ColG[1, 2] * (-1) + ColG[2, 0] * (-1) + ColG[2, 1] * (-1) + ColG[2, 2] * (-1);
                    int[,] ColB = new int[3, 3]
                    {
                    {FI.GetPixel(i-1,j-1).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R},
                    {FI.GetPixel(i,j-1).R,FI.GetPixel(i,j).R,FI.GetPixel(i,j+1).R},
                    {FI.GetPixel(i+1,j-1).R,FI.GetPixel(i+1,j).R,FI.GetPixel(i+1,j+1).R}
                    };
                    int NewB = ColB[0, 0] * (-1) + ColB[0, 1] * (-1) + ColB[0, 2] * (-1) + ColB[1, 0] * (-1) + ColB[1, 1] * 9 + ColB[1, 2] * (-1) + ColB[2, 0] * (-1) + ColB[2, 1] * (-1) + ColB[2, 2] * (-1);
                    if (NewR > 255) NewR = 255;
                    else if (NewR < 0) NewR = 0;
                    if (NewG > 255) NewG = 255;
                    else if (NewG <
                    0) NewG = 0;
                    if (NewB > 255) NewB = 255;
                    else if (NewB < 0) NewB = 0;
                    Color new_Color_Of_Pixel = Color.FromArgb(NewR, NewG, NewB);
                    OutputImage.SetPixel(i, j, new_Color_Of_Pixel);
                }
            pictureBox2.Image = OutputImage;
        }
    }
}