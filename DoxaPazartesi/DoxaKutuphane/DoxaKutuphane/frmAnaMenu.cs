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
    public partial class frmAnaMenu : Form
    {
        public frmAnaMenu()
        {
            InitializeComponent();
        }
        public static string avatarYolu = "";
        public static string kad = "";
        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
             label2.Text = "Welcome " + "'" + kad + "'" + "...";
            if (avatarYolu.Length != 0)
            {
                pictureBox2.Image = Image.FromFile(avatarYolu);
               
            }
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            r f = new r();
            f.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmKategoriSil f = new frmKategoriSil();
            f.ShowDialog();
            
        }

        private void araToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmKategoriAra f = new frmKategoriAra();
            f.ShowDialog();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayinEviEkle f = new frmYayinEviEkle();
            f.ShowDialog();
        }

        private void yayınEviSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayinEviSil f = new frmYayinEviSil();
            f.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayinEviGuncelle f = new frmYayinEviGuncelle();
            f.ShowDialog();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYayinEviAra f = new frmYayinEviAra();
            f.ShowDialog();
        }

        private void yazarEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarEkle f = new frmYazarEkle();
            f.ShowDialog();
        }

        private void yazarSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarSil f = new frmYazarSil();
            f.ShowDialog();
        }

        private void yazarGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYazarGuncelle f = new frmYazarGuncelle();
            f.ShowDialog();
        }

        private void araToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmYazarAra f = new frmYazarAra();
            f.ShowDialog();
        }

        private void kitapEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapEkle f = new frmKitapEkle();
            f.ShowDialog();
        }

        private void kitapGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKitapGuncelle f = new frmKitapGuncelle();
            f.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmKitapGuncelle f = new frmKitapGuncelle();
            f.ShowDialog();
        }

        private void araToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Kitap.frmKitapAra f = new DoxaKutuphane.Kitap.frmKitapAra();
            f.ShowDialog();
        }

        private void dinamikAramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kitap.frmKitapAraDinamik frm = new DoxaKutuphane.Kitap.frmKitapAraDinamik();
            frm.ShowDialog();
        }
        
    }
}
