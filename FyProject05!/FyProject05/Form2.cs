using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyProject05
{
    public partial class Form2 : Form
    {
        int toplam;
        int sonfiyat;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnsepet_Click(object sender, EventArgs e)
        {
            int sayac_sepet = 10;
            string urunisim = lsturun.SelectedItem.ToString();
            int fiyat = Convert.ToInt32(lstfiyat.SelectedItem);
            int adet = Convert.ToInt32(nd_adet.Value);

            if (sayac_sepet > lstsepet.Items.Count)
            {
                lstsepet.Items.Add(urunisim + ", " + fiyat + ", " + adet);
                toplam += fiyat * adet;
                txtToplam.Text = toplam.ToString();
            }
            else if (sayac_sepet == lstsepet.Items.Count)
            {
                MessageBox.Show("Sepetiniz Dolu,Lütfen Satın Alınız");
            }
             
         }

        private void btnsatis_Click(object sender, EventArgs e)
        {
            try
            {
                int indirim = Convert.ToInt32(txtindirim.Text);
                sonfiyat = toplam - (toplam * indirim / 100);

                DialogResult sonuc = MessageBox.Show("Toplam Tutar" + sonfiyat.ToString() + "ytl dir.Satışı onaylıyormusunuz?", "Satış", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (sonuc == DialogResult.Yes)
                {
                    satis_detayi.Items.Add(sonfiyat);
                    lstsepet.Items.Clear();
                }
                else if (sonuc == DialogResult.No)
                {
                    lstsepet.Items.Clear();
                    satis_detayi.Items.Clear();
                    txtToplam.Clear();
                    txtindirim.Clear();

                    lsturun.Items.Clear();
                    lsturun.Items.Add("ekmek");
                    lsturun.Items.Add("pizza");
                    lsturun.Items.Add("köfte");
                    lsturun.Items.Add("pide");

                    lstfiyat.Items.Clear();
                    lstfiyat.Items.Add(10);
                    lstfiyat.Items.Add(20);
                    lstfiyat.Items.Add(30);
                    lstfiyat.Items.Add(100);
                    lstfiyat.Items.Add(200);


                }
                if (sonuc == DialogResult.Cancel)
                {

                }
            }
            catch
            {
                DialogResult sonuc_c1 = MessageBox.Show("İndirim Uygulansın mı?", "Uyarı", MessageBoxButtons.YesNo);
                if (sonuc_c1 == DialogResult.Yes)
                {
                    txtindirim.Focus();
                }
                else if(sonuc_c1==DialogResult.No)
                {
                    satis_detayi.Items.Add(txtToplam.Text.ToString());
                }
            }
        
        
        
        }

        private void btncop_Click(object sender, EventArgs e)
        {
            lstsepet.Items.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lsturun.Items.Add("ekmek");
            lsturun.Items.Add("pizza");
            lsturun.Items.Add("köfte");
            lsturun.Items.Add("pide");

            lstfiyat.Items.Add(10);
            lstfiyat.Items.Add(20);
            lstfiyat.Items.Add(30);
            lstfiyat.Items.Add(100);
            lstfiyat.Items.Add(200);
        }

    }
}
