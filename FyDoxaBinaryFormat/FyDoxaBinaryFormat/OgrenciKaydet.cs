using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FyDoxaBinaryFormat
{
    public partial class OgrenciKaydet : Form
    {
        public OgrenciKaydet()
        {
            InitializeComponent();
        }

        List<Ogrenci> ogrenciListesi = new List<Ogrenci>();
        private void btnOgrenciOlustur_Click(object sender, EventArgs e)
        {
            try
            {
            Ogrenci ogr = new Ogrenci();
            ogr.BolumAd = txtOgrBolum.Text;
            ogr.OgrAd = txtOgrAd.Text;
            ogr.OgrNo = Convert.ToInt32(txtOgrNo.Text);
            ogr.OgrSoyad = txtOgrSoyad.Text;

            ogrenciListesi.Add(ogr);

            MessageBox.Show("Öğrenci Başarıyla Oluşturuldu");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci Oluşturulamadı: "+ex.Message);
            }
        }

        private void btnOgrKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\ogrenciListesi.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ogrenciListesi);
            fs.Close();
            MessageBox.Show("Öğrenciler Kaydedildi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.Message);
            }
        }
    }
}
