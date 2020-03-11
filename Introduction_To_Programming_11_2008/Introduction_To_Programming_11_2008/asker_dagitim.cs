using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Introduction_To_Programming_11_2008
{
    public partial class asker_dagitim : Form
    {
        public asker_dagitim()
        {
            InitializeComponent();
        }
        //Dizi Tanımları
        string[] askerBilgisi = new string[0];
        string[] bolgeBilgisi = new string[0];
        //Sayac Tanımları
        int sycAskrBlgs = 0;
        int sycBlgBlgs = 0;
        int[] rastgeleSayilar = new int[0];
        Random r = new Random();
        //Asker Ekle Butonu
        private void btnAskerEkle_Click(object sender, EventArgs e)
        {
            if ((txtAd.Text != "") && (txtSoyad.Text != "") && (txtTcNo.Text != ""))
            {
                txtAd.Focus();
                btnGorevBelirle.Enabled = true;
                bool tcNoKntrl = true; //T.C. Kontrol
                for (int i = 0; i < askerBilgisi.Length; i++) //askerbilgisinin uzunluğu kadar döner
                {
                    string[] tcNoNew = askerBilgisi[i].Split(',');
                    if (tcNoNew[2] == txtTcNo.Text) //eğer Girilen T.C no var ise kontrol false yapılır
                    {
                        tcNoKntrl = false;
                    }
                }
                if (tcNoKntrl == true)//Asker bilgileri birleştirilip askerbilgisi dizisine atılır
                {
                    lstAskerEklenen.Items.Clear();
                    Array.Resize(ref askerBilgisi, sycAskrBlgs + 1);
                    string infoBirlestir = txtAd.Text + "," + txtSoyad.Text + "," + txtTcNo.Text;
                    askerBilgisi[sycAskrBlgs] = infoBirlestir;
                    sycAskrBlgs++;
                    foreach (string bilgi in askerBilgisi)//Son girilen asker bilgisi ilk listview da gösterilir
                    {
                        if (tcNoKntrl == true)
                        {
                            string[] infoAsker = bilgi.Split(',');
                            ListViewItem li = new ListViewItem();
                            li.Text = infoAsker[0].ToString();
                            li.SubItems.Add(infoAsker[1].ToString());
                            li.SubItems.Add(infoAsker[2].ToString());
                            lstAskerEklenen.Items.Add(li);
                        }
                    }
                }
                else// Girilen T.C no mevcut ise bu koşul çalışır
                {
                    MessageBox.Show("Girdiniğiniz T.C. No Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Bilgileri Doğru ve Eksiksiz Giriniz!");
            }
        }
        // Bölge Ekle Butonu
        private void btnBolgeEkle_Click(object sender, EventArgs e)
        {
           if((txtBolgeAd.Text!="")&&(txtBolgeKod.Text!=""))
           {
               bool blgKodKontrol = true;
               btnGorevBelirle.Enabled = true;
               lstSonDurum.Items.Clear();
               for (int i = 0; i < bolgeBilgisi.Length; i++) // girilen bölge kodunun mevcut olma durumuna bakar
               {
                   string[] dizi = bolgeBilgisi[i].Split(',');
                   if (dizi[1] == txtBolgeKod.Text)// Eğer bölge kodu mevcut ise kontrol false yapılır
                   {
                       blgKodKontrol = false;
                   }
               }
               if (blgKodKontrol == true) // koşul doğru ise bölge bilgileri bolgeBilgisi Dizisine atılır
               {
                   lstBolgeEklenen.Items.Clear();
                   Array.Resize(ref bolgeBilgisi, sycBlgBlgs + 1);
                   string infoBirlestir = txtBolgeAd.Text + "," + txtBolgeKod.Text;
                   bolgeBilgisi[sycBlgBlgs] = infoBirlestir;
                   sycBlgBlgs++;
                   foreach (string bilgi in bolgeBilgisi)
                   {
                       string[] infoBolgeler = bilgi.Split(',');
                       ListViewItem li = new ListViewItem();
                       li.Text = infoBolgeler[0].ToString();
                       li.SubItems.Add(infoBolgeler[1].ToString());
                       lstBolgeEklenen.Items.Add(li);
                   }
               }
               else// bolge kodu mevcut ise bu koşul çalışır
               {
                   MessageBox.Show("Girdiniğiniz Bölge Kodu Mevcuttur!");
               }
           }
           else
           {
               MessageBox.Show("Lütfen Bilgileri Doğru ve Eksiksiz Giriniz!");
           }
        }
        //Görev Yeri Belirle Butonu
        private void btnGorevBelirle_Click(object sender, EventArgs e)
        {
            if (askerBilgisi.Length != 0 && bolgeBilgisi.Length != 0)
            {
                btnGorevBelirle.Enabled = false;
                lstSonDurum.Items.Clear();
                for (int i = 0; i < askerBilgisi.Length; ) //Asker sayısı kadar rastgele farklı sayı üretilir
                {
                    int uretilenSayi = r.Next(0, askerBilgisi.Length);
                    if (Array.IndexOf(rastgeleSayilar, uretilenSayi) == -1)
                    {
                        Array.Resize(ref rastgeleSayilar, i + 1);
                        rastgeleSayilar[i] = uretilenSayi;
                        i++;
                    }
                }
                // Eğer asker sayıgı bölge sayısından fazla ise bu koşul çalışır
                // Her bölgeye en az bir asker rastgele dağıtılır . Geriye kalan askerlerde rastgele bölgelere tekrar dağıtılır
                if (askerBilgisi.Length >= bolgeBilgisi.Length)
                {
                    int sycBolge = 0;
                    for (int i = 0; i < askerBilgisi.Length; i++)
                    {
                        string infoTum = askerBilgisi[rastgeleSayilar[i]] + ',' + bolgeBilgisi[sycBolge];// Rastgele üretilen sayılar kullanılır.
                        ListViewItem li = new ListViewItem();
                        string[] infoTumToListe = infoTum.Split(',');
                        li.Text = infoTumToListe[0].ToString();
                        li.SubItems.Add(infoTumToListe[1].ToString());
                        li.SubItems.Add(infoTumToListe[2].ToString());
                        li.SubItems.Add(infoTumToListe[3].ToString());
                        li.SubItems.Add(infoTumToListe[4].ToString());
                        lstSonDurum.Items.Add(li);
                        sycBolge++;
                        if (sycBolge == bolgeBilgisi.Length)
                        {
                            sycBolge = 0;
                        }
                    }
                }
                // eğer asker sayısı bölge sayısından az ise bölgelere mevcut askerler rastgele dağıtılır
                else
                {
                    for (int i = 0; i < askerBilgisi.Length; i++)
                    {
                        string infoTum = askerBilgisi[rastgeleSayilar[i]] + ',' + bolgeBilgisi[i]; // Rastgele üretilen sayılar kullanılır.
                        ListViewItem li = new ListViewItem();
                        string[] infoTumToListe = infoTum.Split(',');
                        li.Text = infoTumToListe[0].ToString();
                        li.SubItems.Add(infoTumToListe[1].ToString());
                        li.SubItems.Add(infoTumToListe[2].ToString());
                        li.SubItems.Add(infoTumToListe[3].ToString());
                        li.SubItems.Add(infoTumToListe[4].ToString());
                        lstSonDurum.Items.Add(li);
                    }
                }   
            }
            else
            {
                MessageBox.Show("Lütfen Asker Ve Bölge Ekleyiniz !");
            }
        }
             private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            btnAskerEkle.Enabled = true;
        }
             private void txtBolgeKod_TextChanged(object sender, EventArgs e)
        {
            btnBolgeEkle.Enabled = true;
        }

             private void asker_dagitim_Load(object sender, EventArgs e)
             {

             }
        }      
    }

