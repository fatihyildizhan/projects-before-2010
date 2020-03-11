using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaFileSystemWatcher
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void silinenleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SilinenleriListele si = new SilinenleriListele();
            si.ShowDialog();
        }

        private void değiştirilenleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DegistirilenleriListele de = new DegistirilenleriListele();
            de.ShowDialog();
        }

        private void oluşturulanlarıGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OlusturulanlariListele ol = new OlusturulanlariListele();
            ol.ShowDialog();
        }

        private void adkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YenidenAdlandirilanlariListele ye = new YenidenAdlandirilanlariListele();
            ye.ShowDialog();
        }
    }
}
