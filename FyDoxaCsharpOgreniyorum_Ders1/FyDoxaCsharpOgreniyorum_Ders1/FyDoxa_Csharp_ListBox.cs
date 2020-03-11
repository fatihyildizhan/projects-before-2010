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
    public partial class FyDoxa_Csharp_ListBox : Form
    {
        public FyDoxa_Csharp_ListBox()
        {
            InitializeComponent();
        }
        int toplamUrunAdedi = 0;
        int toplamFiyat = 0;
        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            int tutar =Convert.ToInt32(txtUrunFiyati.Text)*Convert.ToInt32(txtUrunAdedi.Text);

            listBox1.Items.Add("Ürün Adı: "+txtUrunAd.Text+" Ürün Adedi: "+txtUrunAdedi.Text+" Ürün Birim Fiyatı: "+txtUrunFiyati.Text+" Tutar: "+tutar+" TL");

            toplamFiyat += tutar;
            toplamUrunAdedi += Convert.ToInt32(txtUrunAdedi.Text);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            txtToplamTutar.Text = toplamFiyat.ToString();
            txtToplamUrunAdedi.Text = toplamUrunAdedi.ToString();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aldığınız Ürün Sayısı: "+toplamUrunAdedi+" dir.");
            MessageBox.Show("Ödediğini Toplam Tutar: "+toplamFiyat+" TL dir. Yine Bekleriz...");
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alışveriş İptal Edilmiştir.");
            listBox1.Items.Clear();
            txtToplamUrunAdedi.Text = "";
            txtToplamTutar.Text = "";
            toplamFiyat = 0;
            toplamUrunAdedi = 0;
        }

       
    }
}
