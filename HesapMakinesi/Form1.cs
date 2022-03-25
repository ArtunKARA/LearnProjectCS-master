using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public int seçim;
        public int sayı = 0;
        public string sayım = "";
        public int sonuç = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
            sayım += "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
            sayım += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
            sayım += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
            sayım += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
            sayım += "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
            sayım += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
            sayım += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
            sayım += "8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
            sayım += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
            sayım += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            sonuç = 0;
            textBox1.Clear();
            sayım = "";
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(sayım);
            sonuç = işlem(seçim, sayı, sonuç);
            seçim = 1;
            textBox1.Text += "+";
            sayım = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(sayım);
            sonuç = işlem(seçim, sayı, sonuç);
            seçim = 2;
            textBox1.Text += "-";
            sayım = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(sayım);
            sonuç = işlem(seçim, sayı, sonuç);
            seçim = 3;
            textBox1.Text += "x";
            sayım = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(sayım);
            sonuç = işlem(seçim, sayı, sonuç);
            seçim = 4;
            textBox1.Text += "/";
            sayım = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayı = Convert.ToInt32(sayım);
            sonuç = işlem(seçim, sayı, sonuç);
            label1.Text = Convert.ToString(sonuç);
        }
        public int işlem(int seçim, int sayı, int sonuç)
        {
            switch (seçim)
            {
                case 0:
                    return sayı;
                case 1:
                    return sayı + sonuç;
                case 2:
                    return sonuç - sayı;
                case 3:
                    return sonuç * sayı;
                case 4:
                    return sonuç / sayı;
                default:
                    return 0;

            }
        }
    }

}
