using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoxaKutuphane
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;uid=sa;pwd=123");
        private void button2_Click(object sender, EventArgs e)
        {
            frmKullaniciEkle f = new frmKullaniciEkle();
            f.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("KullaniciKontrol",con); // kullanici kontrol Prosedürü
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KullaniciAd",txtKullaniciAd.Text);
            com.Parameters.AddWithValue("@Sifre",txtSifre.Text);
            
            DoxaMethodsDAL.Facade.Connection.ConOpen(con); // connection aç
           
            int sayi = Convert.ToInt32(com.ExecuteScalar()); // tek satır etkilendiği için exScalar...
            // static bi instance tanımla gelen değeri executeReader ile oku eğer while a girerse geçerlidir aksi halde değildirr. bilgileri
            // static class a at her yerde kullanırsın.
            
            DoxaMethodsDAL.Facade.Connection.ConClose(con); // connection kapa

            frmAnaMenu fam = new frmAnaMenu(); // ana menü için instance
            
            if (sayi > 0) // exScalardan dönen değer 0 dan büyük ise üye vardır.. ana menüyü açma
            {
                SqlCommand com2 = new SqlCommand("KullaniciGetir",con);
                com2.CommandType = CommandType.StoredProcedure;
                com2.Parameters.AddWithValue("@KullaniciAd",txtKullaniciAd.Text);
                com2.Parameters.AddWithValue("@Sifre",txtSifre.Text);
                
                DoxaMethodsDAL.Facade.Connection.ConOpen(con); // connection aç
                
                SqlDataReader dr = com2.ExecuteReader(); // kullanıcı  adı ve avatar yolunu getirmmek için yeni sorgu....
                while (dr.Read())
                {   
                    frmAnaMenu.kad = dr["KullaniciAd"].ToString() ;
                    frmAnaMenu.avatarYolu=dr["Avatar"].ToString();
                }
                
                    DoxaMethodsDAL.Facade.Connection.ConClose(con); // connection kapa
                
                    this.BackColor = Color.Green;  // kullanıcı geçerliyse ana menüyü aç ve arkaplan rengini yeşil yap
                    fam.ShowDialog();
            }
            else
            {
                this.BackColor = Color.Red;
                DialogResult sonuc = MessageBox.Show("Üye Bilgileriniz Hatalı Tekrar Deneyiniz...", "Hatalı Giriş Denemesi", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(sonuc==DialogResult.Retry)
                {
                    txtKullaniciAd.Focus();
                }
                else
                {
                DialogResult uyeol = MessageBox.Show("Üye olmak için OK ' e tıklayınız..", "Kayıtsız Kullanıcı", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if(uyeol==DialogResult.OK)
                    {
                        frmKullaniciEkle f = new frmKullaniciEkle();
                        f.ShowDialog();
                    }
                    else
                    {
                        frmLoad.frmGir.Close();
                        this.Close();
                    }
                }

            }
        }

        private void txtKullaniciAd_Click(object sender, EventArgs e)
        {
            txtKullaniciAd.Clear();
        }

        private void txtSifre_Click(object sender, EventArgs e)
        {
            txtSifre.Clear();
        }

        
    }
}
