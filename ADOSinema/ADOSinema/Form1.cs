using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADOSinema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKategoriEkle f = new frmKategoriEkle();
            f.ShowDialog();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmKategoriSil f = new frmKategoriSil();
            f.ShowDialog();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmEkle f = new frmFilmEkle();
            f.ShowDialog();
        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFilmAra f = new frmFilmAra();
            f.ShowDialog();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFilmSil f = new frmFilmSil();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
