using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaCsharpOgreniyorum_Ders1
{
    public partial class FyDoxa_Csharp_Timer : Form
    {
        public FyDoxa_Csharp_Timer()
        {
            InitializeComponent();
        }
        decimal sure = 0;
        bool ilkOyuncuOynadiMi = false;
        int tiklanmaSayisi = 0;
    
        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                tiklanmaSayisi = 0;
                sure = numericUpDown1.Value;
                btnTiklanilan.Enabled = true;
                numericUpDown1.Enabled = false;
                lblDefaTiklandi.Text = "0";
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Lütfen Süreyi Artırınız!");
            }
        }

        private void btnTiklanilan_Click(object sender, EventArgs e)
        {
            tiklanmaSayisi++;
            lblDefaTiklandi.Text = tiklanmaSayisi.ToString();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblKalanZaman.Text = sure.ToString();
            
            if (sure == 0 && ilkOyuncuOynadiMi == false)
            {
                ilkOyuncuOynadiMi = true;
                timer1.Stop();
                btnTiklanilan.Enabled = false;
                txtOyuncu1Skor.Text = tiklanmaSayisi.ToString();
            }
            else if (sure == 0 && ilkOyuncuOynadiMi == true)
            {
                timer1.Stop();
                txtOyuncu2Skor.Text = tiklanmaSayisi.ToString();

                if (Convert.ToInt32(txtOyuncu1Skor.Text) > Convert.ToInt32(txtOyuncu2Skor.Text))
                {
                    MessageBox.Show("Tebrikler 1.Oyuncu KAZANDINIZ!");
                }
                else if (Convert.ToInt32(txtOyuncu1Skor.Text) < Convert.ToInt32(txtOyuncu2Skor.Text))
                {
                    MessageBox.Show("Tebrikler 2.Oyuncu KAZANDINIZ!");
                }
                else
                {
                    MessageBox.Show("DOSTLUK KAZANDI!");
                }

                txtOyuncu1Skor.Text = "";
                txtOyuncu2Skor.Text = "";
                numericUpDown1.Value = 0;
                lblDefaTiklandi.Text = "0";
                ilkOyuncuOynadiMi = false;
                btnTiklanilan.Enabled = false;
                numericUpDown1.Enabled = true;
            }
        }

       
    }
}
