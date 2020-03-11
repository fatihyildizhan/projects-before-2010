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
    public partial class r : Form
    {
        public r()
        {
            InitializeComponent();
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {

           bool kontrol =DoxaKutuphaneDAL.Facade.Kategori.KategoriEkle(txtKategoriAd.Text);
           if (kontrol)
           {
               lblKtgrEkleSonuc.BackColor = Color.Green;
               lblKtgrEkleSonuc.Text = "Mission is 	successful!";
           }
           else
           { 
               lblKtgrEkleSonuc.BackColor = Color.Red;
               lblKtgrEkleSonuc.Text = "There is a Problem!";
           }
        
            
        }

        private void r_Load(object sender, EventArgs e)
        {

        }
    }
}
