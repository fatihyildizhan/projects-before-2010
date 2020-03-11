using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DoxaMarina
{
    public partial class YatEkle : Form
    {
        public YatEkle()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Yat y = new Yat();
            y.YatAdı = txtYatAd.Text;
            y.YatBoyu = Convert.ToInt32(txtYatBoy.Text);
            y.KabinSayisi = Convert.ToInt32(txtKabinSayisi.Text);
            y.IskeleId = Convert.ToInt32(txtIskeleId.Text);
            if (Yat.IskeleIdKontrol(Convert.ToInt32(txtIskeleId.Text)) == true)
            {
                Yat.yatListesi.Add(y);
            }
            else
                MessageBox.Show("Bu Iskele No daha önceden eklenmiştir");
        }
    }
}
