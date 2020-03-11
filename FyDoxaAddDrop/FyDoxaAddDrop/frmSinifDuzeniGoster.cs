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

namespace FyDoxaAddDrop
{
    public partial class frmSinifDuzeniGoster : Form
    {
        public frmSinifDuzeniGoster()
        {
            InitializeComponent();
        }

        private void frmSinifDuzeniGoster_Load(object sender, EventArgs e)
        {
            string dosya = @"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Siniflar\" + Form1.secilenSinif;
            FileStream fs = new FileStream(dosya, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            List<Ogrenci> sinif = (List<Ogrenci>)bf.Deserialize(fs);
            fs.Close();

            foreach (Ogrenci o in sinif)
            {
                Button b = new Button();
                b.ForeColor = Color.Red;
                b.BackColor = Color.White;
                b.Width = 130;
                b.Text = o.OgrenciAd;
                b.Location = new Point(o.XKor, o.YKor);

               pnlSinifDuzeni.Controls.Add(b);
            }
        }
    }
}
