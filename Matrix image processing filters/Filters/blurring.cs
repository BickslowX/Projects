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
            for (int i = 2; i < m - 2; i++)
            {
                for (int j = 2; j < n - 2; j++)
                {
                    int[] CR = new int[25]
                    {
                    FI.GetPixel(i-2,j-2).R,FI.GetPixel(i-2,j-1).R,FI.GetPixel(i-2,j).R,FI.GetPixel(i-2,j+1).R,FI.GetPixel(i-2,j+2).R,
                    FI.GetPixel(i-1,j-2).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R,FI.GetPixel(i-1,j+2).R,
                    FI.GetPixel(i,j-2).R,FI.GetPixel(i,j-1).R,FI.GetPixel(i,j).R,FI.GetPixel(i,j+1).R,FI.GetPixel(i,j+2).R,
                    FI.GetPixel(i+1,j-2).R,FI.GetPixel(i+1,j-1).R,FI.GetPixel(i+1,j).R,FI.GetPixel(i+1,j+1).R,FI.GetPixel(i+1,j+2).R,
                    FI.GetPixel(i+2,j-2).R,FI.GetPixel(i+2,j-1).R,FI.GetPixel(i+2,j).R,FI.GetPixel(i+2,j+1).R,FI.GetPixel(i+2,j+2).R,
                    };
                    int nR = Convert.ToInt32(CR[0] * 0.000789 + CR[1] * 0.006581 + CR[2] * 0.013347 + CR[3] * 0.006581 + CR[4] * 0.000789
                    + CR[5] * 0.006581 + CR[6] * 0.054901 + CR[7] * 0.111345 + CR[8] * 0.054901 + CR[9] * 0.006581 +
                    CR[10] * 0.013347 + +CR[11] * 0.111345 + CR[12] * 0.225821 + CR[13] * 0.111345 + CR[14] * 0.013347
                    + CR[15] * 0.006581 + CR[16] * 0.054901 + CR[17] * 0.111345 + CR[18] * 0.054901 + CR[19] * 0.006581 + CR[20] * 0.000789 + CR[21]
                    * 0.006581 + CR[22] * 0.013347 + CR[23] * 0.006581 + CR[24] * 0.000789);
                    if (nR > 255) nR = 255; else if (nR < 0) nR = 0;
                    int[] CG = new int[25]
                    {
                    FI.GetPixel(i-2,j-2).G,FI.GetPixel(i-2,j-1).G,FI.GetPixel(i-2,j).G,FI.GetPixel(i-2,j+1).G,FI.GetPixel(i-2,j+2).G,
                    FI.GetPixel(i-1,j-2).G,FI.GetPixel(i-1,j).G,FI.GetPixel(i-1,j).G,FI.GetPixel(i-1,j+1).G,FI.GetPixel(i-1,j+2).G,
                    FI.GetPixel(i,j-2).G,FI.GetPixel(i,j-1).G,FI.GetPixel(i,j).G,FI.GetPixel(i,j+1).G,FI.GetPixel(i,j+2).G,
                    FI.GetPixel(i+1,j-2).G,FI.GetPixel(i+1,j-1).G,FI.GetPixel(i+1,j).G,FI.GetPixel(i+1,j+1).G,FI.GetPixel(i+1,j+2).G,
                    FI.GetPixel(i+2,j-2).G,FI.GetPixel(i+2,j-1).G,FI.GetPixel(i+2,j).G,FI.GetPixel(i+2,j+1).G,FI.GetPixel(i+2,j+2).G,
                    };
                    int nG = Convert.ToInt32(CG[0] * 0.000789 + CG[1] * 0.006581 + CG[2] * 0.013347 + CG[3] * 0.006581 + CG[4]
                    * 0.000789 + CG[5] * 0.006581 + CG[6] * 0.054901 + CG[7] * 0.111345 + CG[8] * 0.054901 + CG[9] * 0.006581 +
                    CG[10] * 0.013347 + +CG[11] * 0.111345 + CG[12] * 0.225821 + CG[13] * 0.111345 + CG[14] * 0.013347 + CG[15] *
                    0.006581 + CG[16] * 0.054901 + CG[17] * 0.111345 + CG[18] * 0.054901 + CG[19] * 0.006581 + CG[20] * 0.000789 +
                    CG[21] * 0.006581 + CG[22] * 0.013347 + CG[23] * 0.006581 + CG[24] * 0.000789);
                    if (nG > 255) nG = 255; else if (nG < 0) nG = 0;
                    int[] CB = new int[25]
                    {
                    FI.GetPixel(i-2,j-2).B,FI.GetPixel(i-2,j-1).B,FI.GetPixel(i-2,j).B,FI.GetPixel(i-2,j+1).B,FI.GetPixel(i-2,j+2).B,
                    FI.GetPixel(i-1,j-2).B,FI.GetPixel(i-1,j).B,FI.GetPixel(i-1,j).B,FI.GetPixel(i-1,j+1).B,FI.GetPixel(i-1,j+2).B,
                    FI.GetPixel(i,j-2).B,FI.GetPixel(i,j-1).B,FI.GetPixel(i,j).B,FI.GetPixel(i,j+1).B,FI.GetPixel(i,j+2).B,
                    FI.GetPixel(i+1,j-2).B,FI.GetPixel(i+1,j-1).B,FI.GetPixel(i+1,j).B,FI.GetPixel(i+1,j+1).B,FI.GetPixel(i+1,j+2).B,
                    FI.GetPixel(i+2,j-2).B,FI.GetPixel(i+2,j-1).B,FI.GetPixel(i+2,j).B,FI.GetPixel(i+2,j+1).B,FI.GetPixel(i+2,j+2).B
                    };
                    int nB = Convert.ToInt32(CB[0] * 0.000789 + CB[1] * 0.006581 + CB[2] * 0.013347 + CB[3] * 0.006581 + CB[4]
                        * 0.000789 + CB[5] * 0.006581 + CB[6] * 0.054901 + CB[7] * 0.111345 + CB[8] * 0.054901 + CB[9] * 0.006581 + CB[10]
                        * 0.013347 + +CB[11] * 0.111345 + CB[12] * 0.225821 + CB[13] * 0.111345 + CB[14] * 0.013347 + CB[15] * 0.006581 + CB[16]
                        * 0.054901 + CB[17] * 0.111345 + CB[18] * 0.054901 + CB[19] * 0.006581 + CB[20] * 0.000789 + CB[21] * 0.006581 + CB[22]
                        * 0.013347 + CB[23] * 0.006581 + CB[24] * 0.000789);
                    if (nB > 255) nB = 255; else if (nB < 0) nB = 0;
                    Color new_Color_Of_Pixel = Color.FromArgb(nR, nG, nB);
                    OutputImage.SetPixel(i, j, new_Color_Of_Pixel);
                }
            }
            pictureBox2.Image = OutputImage;
        }
    }
}