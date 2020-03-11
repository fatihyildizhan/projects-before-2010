using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaBinaryFormat
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TextKaydet tx = new TextKaydet();
            tx.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TextOku tx = new TextOku();
            tx.ShowDialog();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimKaydet rk = new ResimKaydet();
            rk.ShowDialog();
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResimGoster rg = new ResimGoster();
            rg.ShowDialog();
        }

        private void öğrenciKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciKaydet ok = new OgrenciKaydet();
            ok.ShowDialog();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListele ol = new OgrenciListele();
            ol.ShowDialog();
        }

    }
}
