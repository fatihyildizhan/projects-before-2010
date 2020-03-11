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
    public partial class frmYayinEviEkle : Form
    {
        public frmYayinEviEkle()
        {
            InitializeComponent();
        }

        private void btnYayinEvEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = DoxaKutuphaneDAL.Facade.YayinEvi.YayinEviEkle(txtYayinEvAd.Text, txtYayinEvAdres.Text);

            if (kontrol)
            {
                MessageBox.Show("Mission is successful!");
            }
            else
            {
                MessageBox.Show("Y");
            }
        }
    }
}
