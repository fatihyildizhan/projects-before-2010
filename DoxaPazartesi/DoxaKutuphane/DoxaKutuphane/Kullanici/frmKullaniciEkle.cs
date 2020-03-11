using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace DoxaKutuphane
{
    public partial class frmKullaniciEkle : Form
    {
        public frmKullaniciEkle()
        {
            InitializeComponent();
        }
        string AvatarYolu = "";
        private void btn_K_Olustur_Click(object sender, EventArgs e)
        {
            if (txt_K_Sifre.Text == txt_K_Tekrar_Sifre.Text)
            {
                this.BackColor = Color.Green;
                DoxaKutuphaneDAL.Facade.Kullanici.KullaniciEkle(txt_K_Gercek_Ad.Text, txt_K_Soyad.Text, txt_K_Ad.Text, txt_K_Sifre.Text, txt_K_Mail.Text,AvatarYolu);
                MessageBox.Show("Mission is successful!");
            }
            else
            {
                this.BackColor = Color.Red;
                MessageBox.Show("Passwords are not same");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AvatarYolu = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(AvatarYolu);
            }
        }
    }
}
