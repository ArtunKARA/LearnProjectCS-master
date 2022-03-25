using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BüfeSatışEkranı
{
    public partial class Form1 : Form
    {
        public int fiçecek;
        public int fyiyecek;
        public int faksesuar;
        public int tfiyat =0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbYiyecek.Text)
            {
                case "Cips":
                    fyiyecek = 8;
                    break;
                case "Mısır":
                    fyiyecek = 10;
                    break;
                case "Çikolata":
                    fyiyecek = 5;
                    break;

                default:
                    break;
            }
        }

        private void btYiyecek_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cbYiyecek.Text+" Adet:"+txYiyecek.Text+" Tutar:"+fyiyecek*Convert.ToInt32(txYiyecek.Text)+"TL");
            tfiyat += fyiyecek * Convert.ToInt32(txYiyecek.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbİçecek_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbİçecek.Text)
            {
                case "Ayran":
                    fiçecek = 2;
                    break;
                case "Soda":
                    fiçecek = 1;
                    break;
                case "Çay":
                    fiçecek = 5;
                    break;

                default:
                    break;
            }
        }

        private void cbAksesuar_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAksesuar.Text)
            {
                case "Gözlük":
                    faksesuar = 8;
                    break;
                case "Yastık":
                    faksesuar = 10;
                    break;
                default:
                    break;
            }
        }

        private void txYiyecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txİçecek_TextChanged(object sender, EventArgs e)
        {

        }

        private void txAksesuar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btİçecek_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cbİçecek.Text + " Adet:" + txİçecek.Text + " Tutar:" + fiçecek * Convert.ToInt32(txİçecek.Text) + "TL");
            tfiyat += fiçecek * Convert.ToInt32(txİçecek.Text);
        }

        private void btAksesuar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cbAksesuar.Text + " Adet:" + txAksesuar.Text + " Tutar:" + faksesuar * Convert.ToInt32(txAksesuar.Text) + "TL");
            tfiyat += faksesuar * Convert.ToInt32(txAksesuar.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("İşleminiz ipatal edilmiştir.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("Tutar:"+Convert.ToInt32(tfiyat)+"TL");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
