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
    public partial class frmYazarAra : Form
    {
        public frmYazarAra()
        {
            InitializeComponent();
        }

        private void btnYazarAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DoxaKutuphaneDAL.Facade.Yazar.YazarlariGetir();
        }

       
    }
}
