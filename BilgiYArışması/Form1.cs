using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYArışması
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int[] soruno = new int[5];
        public string cvp = "";
        public Form1()
        {
            InitializeComponent();
        }


        private void btSonraki_Click(object sender, EventArgs e)
        {
            

           if ("Kontrol Et" == btSonraki.Text)
            {
                if (rbA.Checked == true)
                {
                    kontrol(rbA.Text, cvp);                   
                }
                else if (rbB.Checked == true)
                {
                    kontrol(rbB.Text, cvp);
                }
                else if (rbC.Checked == true)
                {
                    kontrol(rbC.Text, cvp);
                }
                else if (rbD.Checked == true)
                {
                    kontrol(rbD.Text, cvp);
                }
                else
                {
                    btSonraki.Text = "Sonraki";
                    x++;
                }
               
            }

            if (x == 4)
            {
                richTextBox1.Clear();
                btSonraki.Text = "Bitti";
                MessageBox.Show("Test Bitti");
                btTekrar.Visible = true;

            }

            if ("Sonraki" == btSonraki.Text || "Başla" == btSonraki.Text)
            {
                Random random = new Random();
                int kontrol;
                bool durum;

                do
                {
                    kontrol = random.Next(1, 5);
                    durum = soruno.Contains(kontrol);
                } while (true == durum);
                soruno[x] = kontrol;

                if (soruno[x] == 1)
                {
                    richTextBox1.Text = "Celal Bayar 22 Mayıs 1950 - 27 Mayıs 1960 yıları arasında hangi görevi üslenmiştir.";
                    rbA.Text = "Ekonomi Bakanlığı";
                    rbB.Text = "Cumhurbaşkanlığı";
                    rbC.Text = "TCDD Proje Kordinatörlüğü";
                    rbD.Text = "Milli Savunma Bakanı";
                    cvp = "Cumhurbaşkanlığı";
                }
                if (soruno[x] == 2)
                {
                    richTextBox1.Text = "Demiryolarında bulunan 3. rayın amacı nedir";
                    rbA.Text = "Elektrik enerjisi sağlamak amacı ile";
                    rbB.Text = "İletişim kurabilmek için";
                    rbC.Text = "Kaçak akımdan korumak için";
                    rbD.Text = "Yakıt ikmali için";
                    cvp = "Elektrik enerjisi sağlamak amacı ile";
                }
                if (soruno[x] == 3)
                {
                    richTextBox1.Text = "1982 yılında başlayan 1991 yılında Sovyetler ve ABD tarafından imzalanan ileriye dönük nükleer silahların azaltılması amacı ile yapılan bu antlaşma görüşmalrinin adı nedir ";
                    rbA.Text = "CAS";
                    rbB.Text = "ANWA";
                    rbC.Text = "NPA";
                    rbD.Text = "START";
                    cvp = "START";
                }
                if (soruno[x] == 4)
                {
                    richTextBox1.Text = "Çok tehditli ortamlarda savaş kabiliyetine ve yüksek manevra yeteneğiyle süratine sahip donanmanın ana vurucu gücü olan gemiler hangisidir";
                    rbA.Text = "Muhripler";
                    rbB.Text = "Hücum Botlar";
                    rbC.Text = "Krüvazörler";
                    rbD.Text = "Mayın Gemileri";
                    cvp = "Krüvazörler";
                }
                
                btSonraki.Text = "Kontrol Et";
            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void kontrol(string dcvp, string vcvp)
        {
            
            
                if (dcvp == vcvp)
                {
                    label2.Text = Convert.ToString(Convert.ToInt16(label2.Text) + 1);
                }
                else
                {
                    MessageBox.Show("Doğru Cevap: "+vcvp);
                    label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                }
                rbA.Checked = false;
                rbB.Checked = false;
                rbC.Checked = false;
                rbD.Checked = false;
                x++;
                btSonraki.Text = "Sonraki";
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void rbB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btTekrar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < soruno.Length; i++)
            {
                soruno[i] = 0;
            }
            x = 0;
            btTekrar.Visible = false;
            btSonraki.Text = "Başla";
            label2.Text = "0";
            label4.Text = "0";
            rbA.Text = "A";
            rbB.Text = "B";
            rbC.Text = "C";
            rbD.Text = "D";
        }
    }
}
