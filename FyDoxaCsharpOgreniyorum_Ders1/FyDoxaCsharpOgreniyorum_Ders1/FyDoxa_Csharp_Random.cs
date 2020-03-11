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
    public partial class FyDoxa_Csharp_Random : Form
    {
        public FyDoxa_Csharp_Random()
        {
            InitializeComponent();
        }
        int sayi;
        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            
            sayi = r.Next(0, 10);
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (sayi == Convert.ToInt32(txtGirilenSayi.Text))
            {
                MessageBox.Show("Tebrikler Doğru Tahmin");
            }
            else
            {
                MessageBox.Show("Yanlış Tahmin!");
            }
        }

        private void txtGirilenSayi_MouseClick(object sender, MouseEventArgs e)
        {
            txtGirilenSayi.Text = "";
        }
    }
}
