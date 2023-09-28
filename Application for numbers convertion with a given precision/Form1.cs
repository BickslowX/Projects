using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Math;

namespace IT_HW1
{
    public partial class Converter : Form
    {
        public Converter()
        {
            InitializeComponent();
            label1.Text = "        ";
            for(int i=1;i<36;i++)
            {
                comboBox1.Items.Add(i+1);
            }
            textBox2.Text = "1e-4";
            comboBox1.SelectedIndex = 0;
            label1.Text = "           ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Decimal Number");
                    return;
                }
                label1.Text = "";
                int r = Convert.ToInt32(comboBox1.Text);
                double I = Floor(Convert.ToDouble(textBox1.Text));
                string a = "";
                string alph = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                while (I > 0)
                {
                    a += alph[(int)(Floor(I % r))];
                    I = Floor(I / r);
                }
                for (int j = 0; j < a.Length; j++)
                {
                    label1.Text += a[a.Length - j - 1];
                }
                if ((Convert.ToDouble(textBox1.Text) % 1 > 0) && (textBox2.Text != ""))
                {
                    if (textBox2.Text == "")
                    {
                        MessageBox.Show("Enter Precission");
                        return;
                    }
                    label1.Text += ",";
                    double s = Ceiling(Log(1 / Convert.ToDouble(textBox2.Text)) / Log(Convert.ToInt32(comboBox1.Text)));
                    label11.Text = s.ToString();
                    double f = Convert.ToDouble("0," + textBox1.Text.Split(',')[1]);
                    f *= r;
                    for (int i = 0; i < s; i++)
                    {
                        label1.Text += alph[(int)Floor(f * 1.0)];
                        f -= Floor(f * 1.0);
                        f *= r;
                    }
                }
            }
            catch(Exception exep)
            {
                MessageBox.Show("Something went wrong.\nTry again.");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                int a =textBox1.Text.IndexOf(".");
                textBox1.Text = textBox1.Text.Replace('.', ',');
                textBox1.SelectionStart = a+1;
            }
        }
    }
}
