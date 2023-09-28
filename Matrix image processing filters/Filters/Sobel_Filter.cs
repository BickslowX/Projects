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
            Bitmap FI = new Bitmap(pictureBox1.Image);
            int m = FI.Width; int n = FI.Height;
            m = FI.Width;
            n = FI.Height;
            Bitmap OutputImage = new Bitmap(m, n);
            for (int i = 1; i < m - 1; i++)
            {
                for (int j = 1; j < n - 1; j++)
                {
                    int Grey = Convert.ToInt32(FI.GetPixel(i, j).R * 0.299 + FI.GetPixel(i, j).G * 0.587 + FI.GetPixel(i, j).B * 0.114);
                    int[,] cG = new int[3, 3]
                    {
                            {Convert.ToInt32(FI.GetPixel(i-1, j-1).R * 0.299 + FI.GetPixel(i-1, j-1).G * 0.587 + FI.GetPixel(i-1, j-1).B * 0.114),
                            Convert.ToInt32(FI.GetPixel(i-1, j).R* 0.299 + FI.GetPixel(i-1, j).G * 0.587 + FI.GetPixel(i-1, j).B * 0.114),
                            Convert.ToInt32(FI.GetPixel(i, j+1).R * 0.299 + FI.GetPixel(i, j+1).G * 0.587 + FI.GetPixel(i, j+1).B * 0.114)},
                            {Convert.ToInt32(FI.GetPixel(i, j-1).R * 0.299 + FI.GetPixel(i, j-1).G * 0.587 + FI.GetPixel(i, j-1).B * 0.114),
                            Convert.ToInt32(FI.GetPixel(i, j).R * 0.299 + FI.GetPixel(i, j).G * 0.587 + FI.GetPixel(i, j).B * 0.114),
                            Convert.ToInt32(FI.GetPixel(i, j + 1).R * 0.299 + FI.GetPixel(i, j + 1).G * 0.587 + FI.GetPixel(i, j + 1).B * 0.114)},
                            {Convert.ToInt32(FI.GetPixel(i+1, j-1).R* 0.299 + FI.GetPixel(i+1, j-1).G* 0.587 + FI.GetPixel(i+1, j-1).B* 0.114),
                            Convert.ToInt32(FI.GetPixel(i+1, j).R* 0.299 + FI.GetPixel(i+1, j).G* 0.587 + FI.GetPixel(i+1, j).B* 0.114),
                            Convert.ToInt32(FI.GetPixel(i+1, j+1).R* 0.299 + FI.GetPixel(i+1, j+1).G* 0.587 + FI.GetPixel(i+1, j+1).B* 0.114)}
                    }

                }
            }
            if (nS > 255)
                nS = 255;
            else if (nS < 0)
                nS = 0;
            int[,] cGY = new int[3, 3]
            {
                {Convert.ToInt32(FI.GetPixel(i-1, j-1).R * 0.299 + FI.GetPixel(i-1, j-1).G * 0.587 + FI.GetPixel(i-1, j-1).B * 0.114), Convert.ToInt32(FI.GetPixel(i-1, j).R * 0.299 + FI.GetPixel(i-1, j).G * 0.587 + FI.GetPixel(i-1, j).B * 0.114), Convert.ToInt32(FI.GetPixel(i, j+1).R * 0.299 + FI.GetPixel(i, j+1).G * 0.587 + FI.GetPixel(i, j+1).B * 0.114)},
                {Convert.ToInt32(FI.GetPixel(i, j-1).R * 0.299 + FI.GetPixel(i, j-1).G * 0.587 + FI.GetPixel(i,j-1).B * 0.114), Convert.ToInt32(FI.GetPixel(i, j).R * 0.299 + FI.GetPixel(i, j).G * 0.587 + FI.GetPixel(i, j).B * 0.114), Convert.ToInt32(FI.GetPixel(i, j+1).R * 0.299 + FI.GetPixel(i, j+1).G * 0.587 + FI.GetPixel(i, j+1).B * 0.114)},
                {Convert.ToInt32(FI.GetPixel(i+1, j-1).R * 0.299 + FI.GetPixel(i+1, j-1).G * 0.587+ FI.GetPixel(i+1, j-1).B * 0.114), Convert.ToInt32(FI.GetPixel(i+1, j).R * 0.299 + FI.GetPixel(i+1, j).G * 0.587 + FI.GetPixel(i+1, j).B * 0.114), Convert.ToInt32(FI.GetPixel(i+1, j+1).R * 0.299 + FI.GetPixel(i+1, j+1).G * 0.587 + FI.GetPixel(i+1, j+1).B * 0.114)}
            };
            int nG = cG[0, 0] * (-1) + cG[0, 1] * (-2) + cG[0, 2] * (-1) + cG[1, 0] * 0 + cG[1, 1] * 0 + cG[1, 2] * 0 + cG[2, 0] * 1 + cG[2, 1] * 2 + cG[2, 2] * 1;
            int nGY = cGY[0, 0] * (-1) + cGY[0, 1] * 0 + cGY[0, 2] * 1 + cGY[1, 0] * (-2) + cGY[1, 1] * 0 + cGY[1, 2] * 2 + cGY[2, 0] * (-1) + cGY[2, 1] * 0 + cGY[2, 2] * 1;
            int nS = Convert.ToInt32(Math.Sqrt(nG * nG + nGY * nGY));
            Color new_cG = Color.FromArgb(nS, nS, nS);
            OutputImage.SetPixel(i, j, new_cG);
            pictureBox2.Image = OutputImage;
        }
    }
}