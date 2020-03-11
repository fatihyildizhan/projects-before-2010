using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaSystemIO
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void dosyaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDosyaListele fd = new frmDosyaListele();
            fd.ShowDialog();
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDosyaGozat fg = new frmDosyaGozat();
            fg.ShowDialog();
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
