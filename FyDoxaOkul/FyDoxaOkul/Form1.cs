using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaOkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Method Tanımları
        public bool KontrolOgrenci(string[] dizi, string aranilacak)
        {
            bool kontrol = true;
            foreach (string ara in dizi)
            {
                string[] diziBilgileri = ara.Split(',');
                if (diziBilgileri[0] == aranilacak)
                {
                    kontrol = false;
                    break;
                }
            }
            return kontrol;
        }

        //Dizi Tanımları
        string[] ogrenciler = new string[0];
        string[] ogretmenler = new string[0];
        string[] dersler = new string[0];
        string[] siniflar = new string[0];
        //Sayac Vs Tanımları
        int sayacOgrenci = 0;
        int sayacOgretmen = 0;
        int sayacSinif = 0;
        int sayacDers = 0;

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (cmbSinif.Text != "" && txtAd.Text != "" && txtNumara.Text != "" && txtSoyad.Text != "")
            {
                bool sonuc = KontrolOgrenci(ogrenciler, txtNumara.Text);
                if (sonuc == true)
                {
                    Array.Resize(ref ogrenciler, sayacOgrenci + 1);

                    string cinsiyet = "";
                    if (rdbErkek.Checked)
                    {
                        cinsiyet = "Erkek";
                    }
                    else
                    {
                        cinsiyet = "Bayan";
                    }
                    string ogrenciBilgileri = txtNumara.Text + "," + txtAd.Text + "," + txtSoyad.Text + "," + cmbSinif.SelectedItem.ToString() + "," + cinsiyet + "," + txtResimYol.Text;

                    ogrenciler[sayacOgrenci] = ogrenciBilgileri;
                    sayacOgrenci++;
                }
                else
                {
                    MessageBox.Show(txtNumara.Text + " No lu Öğrenci Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtResimYol.Text = openFileDialog1.FileName;

            }
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            foreach (string araOgrenci in ogrenciler)
            {
                string[] ogrenciDetaylari = araOgrenci.Split(',');

                ListViewItem li = new ListViewItem();
                li.Text = ogrenciDetaylari[0];
                li.SubItems.Add(ogrenciDetaylari[1]);
                li.SubItems.Add(ogrenciDetaylari[2]);
                li.SubItems.Add(ogrenciDetaylari[3]);
                li.SubItems.Add(ogrenciDetaylari[4]);
                li.SubItems.Add(ogrenciDetaylari[5]);
                listView1.Items.Add(li);
            }
        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            if (txtOgretmenAd.Text != "" && txtOgretmenNo.Text != "" && txtOgretmenSoyad.Text != "")
            {
                bool sonuc = KontrolOgrenci(ogretmenler, txtOgretmenNo.Text);
                if (sonuc == true)
                {
                    Array.Resize(ref ogretmenler, sayacOgretmen + 1);

                    string cinsiyet = "";
                    if (rdbOgrErkek.Checked == true)
                    {
                        cinsiyet = "Erkek";
                    }
                    else
                    {
                        cinsiyet = "Bayan";
                    }
                    string ogretmenBilgileri = txtOgretmenNo.Text + "," + txtOgretmenAd.Text + "," + txtOgretmenSoyad.Text + "," + cmbOgretmenDers.SelectedItem.ToString() + "," + cinsiyet + "," + txtOgrResimYol.Text;

                    ogretmenler[sayacOgretmen] = ogretmenBilgileri;
                    sayacOgretmen++;
                }
                else
                {
                    MessageBox.Show(txtOgretmenNo.Text + " No lu Öğretmen Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Boş Bırakmayın!");
            }
        }

        private void btnOgrGozat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOgrResimYol.Text = openFileDialog1.FileName;
            }
        }

        private void btnOgrListele_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            foreach (string araOgretmen in ogretmenler)
            {
                string[] ogretmenDetaylari = araOgretmen.Split(',');

                ListViewItem li = new ListViewItem();
                li.Text = ogretmenDetaylari[0];
                li.SubItems.Add(ogretmenDetaylari[1]);
                li.SubItems.Add(ogretmenDetaylari[2]);
                li.SubItems.Add(ogretmenDetaylari[3]);
                li.SubItems.Add(ogretmenDetaylari[4]);
                li.SubItems.Add(ogretmenDetaylari[5]);
                listView2.Items.Add(li);
            }
        }

        private void btnSinifGozat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSinifResimYolu.Text = openFileDialog1.FileName;
            }
        }

        private void btnSinifEkle_Click(object sender, EventArgs e)
        {
            if (txtSinifKodu.Text != "" && txtSinifSorumlusu.Text != "" && cmbSinifKapasite.Text != "" && cmbSinifTipi.Text != "")
            {
                bool sonuc = KontrolOgrenci(siniflar, txtSinifKodu.Text);
                if (sonuc == true)
                {
                    Array.Resize(ref siniflar, sayacSinif + 1);


                    string sinifBilgileri = txtSinifKodu.Text + "," + cmbSinifKapasite.SelectedItem.ToString() + "," + cmbSinifTipi.SelectedItem.ToString() + "," + txtSinifSorumlusu.Text + "," + txtSinifResimYolu.Text;

                    siniflar[sayacSinif] = sinifBilgileri;
                    sayacSinif++;
                }
                else
                {
                    MessageBox.Show(txtSinifKodu.Text + " No lu Sınıf Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Boş Bırakmayınız!");
            }
        }

        private void btnSinifListele_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            foreach (string araSinif in siniflar)
            {
                string[] sinifDetaylari = araSinif.Split(',');

                ListViewItem li = new ListViewItem();
                li.Text = sinifDetaylari[0];
                li.SubItems.Add(sinifDetaylari[1]);
                li.SubItems.Add(sinifDetaylari[2]);
                li.SubItems.Add(sinifDetaylari[3]);
                li.SubItems.Add(sinifDetaylari[4]);
                listView3.Items.Add(li);
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            if (cmbDersBolum.Text != "" && txtDersAdi.Text != "" && txtDersKodu.Text != "" &&txtDersSeviye.Text != "")
            {
                bool sonuc = KontrolOgrenci(dersler, txtDersKodu.Text);
                if (sonuc == true)
                {
                    Array.Resize(ref dersler, sayacDers + 1);

                    string dersTipi = "";
                    if (rdbDersSayisal.Checked == true)
                    {
                        dersTipi = "Sayisal";
                    }
                    else
                    {
                        dersTipi = "Sözel";
                    }
                    string dersBilgileri = txtDersKodu.Text + "," + txtDersAdi.Text + "," + txtDersSeviye.Text + "," + cmbDersBolum.SelectedItem.ToString() + "," + dersTipi + "," + txtDersResimYol.Text;

                    dersler[sayacDers] = dersBilgileri;
                    sayacDers++;
                }
                else
                {
                    MessageBox.Show(txtDersKodu.Text + " No lu Ders Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurun!");
            }
        }

        private void btnDersGozat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              txtDersResimYol.Text = openFileDialog1.FileName;
            }
        }

        private void btnDersListele_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            foreach (string araDers in dersler)
            {
                string[] dersDetaylari = araDers.Split(',');

                ListViewItem li = new ListViewItem();
                li.Text = dersDetaylari[0];
                li.SubItems.Add(dersDetaylari[1]);
                li.SubItems.Add(dersDetaylari[2]);
                li.SubItems.Add(dersDetaylari[3]);
                li.SubItems.Add(dersDetaylari[4]);
                li.SubItems.Add(dersDetaylari[5]);
                listView4.Items.Add(li);
            }
        }
    }
    //Fatih Yıldızhan && DoXa && 09'
    //fatih@yildizhanlar.com
    //www.fatihyildizhan.com
}
