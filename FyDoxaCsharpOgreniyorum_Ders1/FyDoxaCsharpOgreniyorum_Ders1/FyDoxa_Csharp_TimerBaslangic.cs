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
    public partial class FyDoxa_Csharp_TimerBaslangic : Form
    {
        public FyDoxa_Csharp_TimerBaslangic()
        {
            InitializeComponent();
        }

        decimal sure = 0;
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                sure = numericUpDown1.Value;

                btnBaslat.Enabled = false;
                
                timer1.Start();
            }
            else
            {
                MessageBox.Show("Lütfen Süreyi Belirleyiniz!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblKalanSure.Text = sure.ToString()+" Saniye";
            if (sure == 0)
            {
                timer1.Stop();
                
                MessageBox.Show("Süreniz Bitti!");

                btnBaslat.Enabled = true;
            }
        }
    }
}
