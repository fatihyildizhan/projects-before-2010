using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaCsharpOgreniyorum_Ders1
{
    public partial class FyDoxa_Csharp_StringBirlestirme : Form
    {
        public FyDoxa_Csharp_StringBirlestirme()
        {
            InitializeComponent();
        }

        private void btnEkrandaGoster_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adım: "+txtAd.Text+" Soyadım: "+txtSoyad.Text+" Şehir: "+txtSehir.Text+" E-Postam: "+txtEposta.Text);
        }

    }
}
