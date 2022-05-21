using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldFinderForm
{
    public partial class Form1 : Form
    {
        string[] ldata;
        public Form1()
        {
            InitializeComponent();
        }

        private void TBAranan_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBAranan_Click(object sender, EventArgs e)
        {

        }

        private void TBAranan_DoubleClick(object sender, EventArgs e)
        {
            TBAranan.Text = "";
        }

        private void Bul_Click(object sender, EventArgs e)
        {
            int locate = 0;
            int flocate;
            string uldata = "";
            if (TBAranan.TextLength>0)
            {


                do
                {
                    flocate = richTBmetin.Text.IndexOf(TBAranan.Text, locate);
                    if (flocate != -1)
                    {
                        uldata += Convert.ToString(flocate) + " ";
                        locate = flocate + TBAranan.Text.Length;
                    }
                    else
                    {
                        locate++;
                    }
                } while (richTBmetin.Text.Length > locate);
                if (uldata.Length > 0)
                {
                    ldata = uldata.Split(' ');
                    MessageBox.Show(uldata);
                    lbAdet.Text = Convert.ToString(ldata.Length - 1);
                    foreach (var item in ldata)
                    {
                        CBkonum.Items.Add(item);
                    }
                    CBkonum.Text = ldata[0];
                }
                else
                {
                    lbAdet.Text = "0";
                }
            }
        
        }

        private void Git_Click(object sender, EventArgs e)
        {
            int count = ldata.Length-2;
            
            while (count>=0)
            {
                int a = Convert.ToInt32(ldata[count]);
                richTBmetin.Select(a,TBAranan.Text.Length);
                richTBmetin.SelectionColor = Color.Red;
                count--;
            }
        }
    }
}
