using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FromUygulmalar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Butona bastınız.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = "Kıral";
            label7.Text = "Donstrako";
            label8.Text = "Abromov";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sonuç = "";
            string[] str = textBox1.Text.Split(' ');
            foreach (string item in str)
            {
                sonuç = sonuç + item.Substring(0, 1).ToUpper() + item.Substring(1, item.Length - 1) + " ";
            }
            label1.Text = "Merhaba " + sonuç;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Öğretmen ":
                    MessageBox.Show("Öğrencileriniz var");
                    break;
                case "Mühendis":
                    MessageBox.Show("Kahveni içmeyi unutma");
                    break;
                case "Doktor":
                    MessageBox.Show("Hastalarınızın hayatını kurtarıyorsunuz <3");
                    break;
                case "Kemanist":
                    MessageBox.Show("Easter egg.");
                    break;
                default:
                    break;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(maskedTextBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox2.Text+" Tarihinde sitemimize kayıt olmuştur.");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string sonuç = "";
            string[] str = textBox2.Text.Split(' ');
            foreach (string item in str)
            {
                 sonuç= sonuç+ item.Substring(0,1).ToUpper()+item.Substring(1,item.Length-1)+" ";
            }
            listBox1.Items.Add(sonuç);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked && checkBox1.Checked) 
            {
                MessageBox.Show("Çift cinsiyetli olarak sisteme aktarılmıştır.");
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("Kadın olarak sisteme aktarılmıştır.");
            }
            else if (checkBox2.Checked)
            {
                MessageBox.Show("Erkek olarak sisteme aktarılmıştır.");
            }
            else
            {
                MessageBox.Show("Cinsiyetini belirmek istemiyor diye sisteme aktarılmıştır.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
