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
    public partial class OgrenciListele : Form
    {
        public OgrenciListele()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\ogrenciListesi.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Ogrenci> ogrenciler = (List<Ogrenci>)bf.Deserialize(fs);
            fs.Close();

            foreach (Ogrenci ogr in ogrenciler)
            {
                ListViewItem li = new ListViewItem();
                li.Text = ogr.OgrAd;
                li.SubItems.Add(ogr.OgrSoyad);
                li.SubItems.Add(ogr.OgrNo.ToString());
                li.SubItems.Add(ogr.BolumAd);

                listView1.Items.Add(li);
            }
        }
    }
}
