using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;

namespace FyDoxaSystemIO
{
    public partial class frmDosyaGozat : Form
    {
        public frmDosyaGozat()
        {
            InitializeComponent();
        }
        FileInfo fi;
        private void btnGozat_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fi = new FileInfo(openFileDialog1.FileName);
                string[] ad = openFileDialog1.SafeFileName.Split('.');
                txtDosyaAdi.Text = ad[0];
                txtDosyaYolu.Text = openFileDialog1.FileName;
                txtDosyaUzantisi.Text = fi.Extension;
                txtTarihi.Text = fi.CreationTime.ToLongDateString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;database=FyDoxaSystemIO;trusted_connection=true");

            try
            {
                FileStream fs = new FileStream(txtDosyaYolu.Text, FileMode.Create);
                byte[] dizi = new byte[fs.Length];
                fs.Read(dizi, 0, dizi.Length);
                fs.Close();

                SqlCommand com = new SqlCommand("insert into Dosyalar values(@ad,@uzanti,@dosyam,@tarih)", con);
                com.Parameters.AddWithValue("@ad", txtDosyaAdi.Text);
                com.Parameters.AddWithValue("@uzanti", fi.Extension);
                com.Parameters.AddWithValue("@dosyam", dizi);
                com.Parameters.AddWithValue("@tarih", fi.CreationTime);
                
                con.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Dosya Başarıyla Kaydedildi.");
            }
            catch (SqlException sq)
            {
                MessageBox.Show("SQL Bağlantı Hatası: " + sq.Message);
            }
            catch (FileNotFoundException fl)
            {
                MessageBox.Show("Dosya Bulunamadı: " + fl.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayı: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
