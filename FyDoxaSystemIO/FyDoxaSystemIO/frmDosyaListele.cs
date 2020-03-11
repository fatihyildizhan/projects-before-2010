using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FyDoxaSystemIO
{
    public partial class frmDosyaListele : Form
    {
        public frmDosyaListele()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=FyDoxaSystemIO;trusted_connection=true");

        List<Dosya> dosyalar;
        private void btnResimListele_Click(object sender, EventArgs e)
        {
            dosyalar = new List<Dosya>();

            try
            {
                SqlCommand com = new SqlCommand("select * from Dosyalar", con);
                con.Open();

                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    Dosya d = new Dosya();
                    d.DosyaAd = dr["DosyaAd"].ToString();
                    d.DosyaId = Convert.ToInt32(dr["DosyaId"]);
                    d.Dosyam = (byte[])dr["Dosyam"];
                    d.Tarih = Convert.ToDateTime(dr["Tarih"]);
                    d.Uzanti = dr["Uzanti"].ToString();
                    dosyalar.Add(d);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
            ListeDoldur();
        }
        public void ListeDoldur()
        {
            listView1.Items.Clear();

            foreach (Dosya d in dosyalar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = d.DosyaId.ToString();
                li.SubItems.Add(d.DosyaAd);
                li.SubItems.Add(d.Uzanti);
                li.SubItems.Add(d.Tarih.ToLongTimeString());
                
                li.Tag = d.Dosyam;

                listView1.Items.Add(li);
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ListViewItem li = listView1.SelectedItems[0];
                    FileStream fs = new FileStream(saveFileDialog1.FileName + li.SubItems[2].Text, FileMode.Create);

                    byte[] dizi = (byte[])li.Tag;
                    fs.Write(dizi, 0, dizi.Length);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata Detayı: " + ex.Message);
                }
                MessageBox.Show("Dosya Başarıyla Belirtilen Adrese Kaydedildi.");
            }
        }

        private void önizlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            byte[] dizi = (byte[])listView1.SelectedItems[0].Tag;
            ms.Write(dizi, 0, dizi.Length);

            pictureBox1.Image = Image.FromStream(ms);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 3)
            {
                Dosya.deger = (Dosya.deger == 1 ? -1 : 1);
                dosyalar.Sort();
                ListeDoldur();
            }
        }
    }
}
