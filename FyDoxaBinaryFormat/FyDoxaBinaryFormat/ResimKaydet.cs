using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FyDoxaBinaryFormat
{
    public partial class ResimKaydet : Form
    {
        public ResimKaydet()
        {
            InitializeComponent();
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = openFileDialog1.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                txtResimYolu.Text = openFileDialog1.FileName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Resim.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Image.FromFile(txtResimYolu.Text));
            fs.Close();
        }
    }
}
