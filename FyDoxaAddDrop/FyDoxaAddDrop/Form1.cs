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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ogrenciSayisi = 1;
        public static string secilenSinif;
        private void Form1_Load(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = ogrenciSayisi + ". Öğrenci";
            b.Tag = 1;
            b.ForeColor = Color.Red;
            b.BackColor = Color.White;
            b.Width = 130;
            b.MouseHover += new EventHandler(b_MouseHover);
            b.MouseLeave += new EventHandler(b_MouseLeave);
            b.MouseDown += new MouseEventHandler(b_MouseDown);
            b.Click += new EventHandler(b_Click);
            pnlSinifBilgileri.Controls.Add(b);
            SiniflariListele();
        }

        void b_MouseLeave(object sender, EventArgs e)
        {
            lblBilgilendirme.Text = "Bilgilendirmeyi Görüntülemek İçin Butonların Üzerine Geliniz!";
        }

        void b_MouseHover(object sender, EventArgs e)
        {
            lblBilgilendirme.Text ="İsmini değiştirmek için tıklayın.. Taşımak için Sağ tuşa basılı tutun..";
        }

        void b_Click(object sender, EventArgs e)
        {
            frmOgrenciAdi foa = new frmOgrenciAdi();
            foa.ShowDialog();
            (sender as Button).Text = frmOgrenciAdi.ogrAd;
        }

        void b_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                (sender as Button).DoDragDrop((sender as Button), DragDropEffects.All);
            }
        }

        private void pnlSinifDuzeni_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void pnlSinifDuzeni_DragDrop(object sender, DragEventArgs e)
        {
            Button b = (e.Data.GetData(typeof(Button)) as Button);
            b.Location = new Point(e.X - (this.Left + pnlSinifBilgileri.Width+50), e.Y - (this.Top+150));

            pnlSinifDuzeni.Controls.Add(b);
            ogrenciSayisi++;
            btnSinifKaydet.Enabled = true;
            txtSinifIsmi.ReadOnly = false;

            Form1_Load(null, null);
        }

        private void btnSinifKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSinifIsmi.Text.Trim() != "")
                {
                    List<Ogrenci> sinif = new List<Ogrenci>();

                    foreach (Control c in pnlSinifDuzeni.Controls)
                    {
                        if (c is Button && (c as Button).Tag.ToString() != "100")
                        {
                            Ogrenci o = new Ogrenci();
                            o.OgrenciAd = (c as Button).Text;
                            o.XKor = (c as Button).Location.X;
                            o.YKor = (c as Button).Location.Y;

                            sinif.Add(o);
                        }
                    }
                    if (!Directory.Exists(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Siniflar"))
                    {
                        Directory.CreateDirectory(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Siniflar");
                    }

                    FileStream fs = new FileStream(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Siniflar\" + txtSinifIsmi.Text + ".dat", FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, sinif);
                    fs.Close();
                    MessageBox.Show("Sınıf Başarıyla Kaydedildi.");
                    SiniflariListele();
                }
                else
                {
                    MessageBox.Show("Lütfen sınıf adını belirleyiniz.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata var: "+ex.Message);
            }
        }

        private void btnSinifGoster_Click(object sender, EventArgs e)
        {
            secilenSinif = cmbSinifListesi.SelectedItem.ToString();
            frmSinifDuzeniGoster fsd = new frmSinifDuzeniGoster();
            fsd.ShowDialog();
        }

        private void cmbSinifListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSinifGoster.Enabled = true;
        }

        public void SiniflariListele()
        {
            cmbSinifListesi.Items.Clear();
            DirectoryInfo di = new DirectoryInfo(@"C:\Users\FyDoxa\Documents\FyDoxaDenemeKlasoru\Siniflar");
                foreach (FileInfo fi in di.GetFiles())
                {
                    cmbSinifListesi.Items.Add(fi.Name);
                }
           
        }
    }
}
