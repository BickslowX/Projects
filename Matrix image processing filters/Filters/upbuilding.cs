using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            for (int j = 2; j < n - 2; j++)
            {
                int[] CR = new int[25]
                {
                    FI.GetPixel(i-2,j-2).R,FI.GetPixel(i-2,j-1).R,FI.GetPixel(i-2,j).R,FI.GetPixel(i-2,j+1).R,FI.GetPixel(i-2,j+2).R,
                    FI.GetPixel(i-1,j-2).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j).R,FI.GetPixel(i-1,j+1).R,FI.GetPixel(i-1,j+2).R,
                    FI.GetPixel(i, j - 2).R,FI.GetPixel(i, j - 1).R,FI.GetPixel(i, j).R,FI.GetPixel(i, j + 1).R,FI.GetPixel(i, j + 2).R,
                    FI.GetPixel(i + 1, j - 2).R,FI.GetPixel(i + 1, j - 1).R,FI.GetPixel(i + 1, j).R,FI.GetPixel(i + 1, j + 1).R,FI.GetPixel(i + 1, j + 2).R,
                    FI.GetPixel(i + 2, j - 2).R,FI.GetPixel(i + 2, j - 1).R,FI.GetPixel(i + 2, j).R,FI.GetPixel(i + 2, j + 1).R,FI.GetPixel(i + 2, j + 2).R,
                }
                if (nG > 255)
                    nG = 255;
                else if (nG < 0)
                    nG = 0;
            };
        if (nR > 255) nR = 255; else if (nR < 0) nR = 0;
        int nR = CR[2] + CR[6] + CR[7] + CR[8] + CR[10] + CR[11] + CR[12] + CR[13] + CR[14] + +CR[16] + CR[17] + CR[18] + CR[22];
        int[] CG = new int[25]
        {
            FI.GetPixel(i-2,j-2).G,FI.GetPixel(i-2,j-1).G,FI.GetPixel(i-2,j).G,FI.GetPixel(i-2,j+1).G,FI.GetPixel(i-2,j+2).G,
            FI.GetPixel(i-1,j-2).G,FI.GetPixel(i-1,j).G,FI.GetPixel(i-1,j).G,FI.GetPixel(i-1,j+1).G,FI.GetPixel(i-1,j+2).G,
            FI.GetPixel(i,j-2).G,FI.GetPixel(i,j-1).G,FI.GetPixel(i,j).G,FI.GetPixel(i,j+1).G,FI.GetPixel(i,j+2).G,
            FI.GetPixel(i+1,j-2).G,FI.GetPixel(i+1,j-1).G,FI.GetPixel(i+1,j).G,FI.GetPixel(i+1,j+1).G,FI.GetPixel(i+1,j+2).G,
            FI.GetPixel(i+2,j-2).G,FI.GetPixel(i+2,j-1).G,FI.GetPixel(i+2,j).G,FI.GetPixel(i+2,j+1).G,FI.GetPixel(i+2,j+2).G,
        };
        int nG = CG[2] + CG[6] + CG[7] + CG[8] + CG[10] + CG[11] + CG[12] + CG[13] + CG[14] + +CG[16] + CG[17] + CG[18] + CG[22];
        int[] CB = new int[25]
        {
            FI.GetPixel(i-2,j-2).B,FI.GetPixel(i-2,j-1).B,FI.GetPixel(i-2,j).B,FI.GetPixel(i-2,j+1).B,FI.GetPixel(i-2,j+2).B,
            FI.GetPixel(i-1,j-2).B,FI.GetPixel(i-1,j).B,FI.GetPixel(i-1,j).B,FI.GetPixel(i-1,j+1).B,FI.GetPixel(i-1,j+2).B,
            FI.GetPixel(i, j - 2).B,FI.GetPixel(i, j - 1).B,FI.GetPixel(i, j).B,FI.GetPixel(i, j + 1).B,FI.GetPixel(i, j + 2).B,
            FI.GetPixel(i + 1, j - 2).B,FI.GetPixel(i + 1, j - 1).B,FI.GetPixel(i + 1, j).B,FI.GetPixel(i + 1, j + 1).B,FI.GetPixel(i + 1, j + 2).B,
            FI.GetPixel(i + 2, j - 2).B,FI.GetPixel(i + 2, j - 1).B,FI.GetPixel(i + 2, j).B,FI.GetPixel(i + 2, j + 1).B,FI.GetPixel(i + 2, j + 2).B
        };
        int nB = CB[2] + CB[6] + CB[7] + CB[8] + CB[10] + CB[11] + CB[12] + CB[13] + CB[14] + +CB[16] + CB[17] + CB[18] + CB[22];
        if (nB > 255) nB = 255; else if (nB < 0) nB = 0;
        Color new_Color_Of_Pixel = Color.FromArgb( nR, nG, nB);
        OutputImage.SetPixel(i, j, new_Color_Of_Pixel);
    }
    pictureBox2.Image = OutputImage;
}
}
}