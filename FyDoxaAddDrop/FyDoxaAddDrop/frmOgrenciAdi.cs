using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaAddDrop
{
    public partial class frmOgrenciAdi : Form
    {
        public frmOgrenciAdi()
        {
            InitializeComponent();
        }

        public static string ogrAd;
        private void btnOgrAdBelirle_Click(object sender, EventArgs e)
        {
            ogrAd = txtOgrenciAd.Text;
            this.Close();
        }

        private void frmOgrenciAdi_Load(object sender, EventArgs e)
        {
        }
    }
}
