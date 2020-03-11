using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fy_new_laptop_26Ekim08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] kisiler = new String[0];
        int sayac = 0;
       // int sonDeger;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
           /* int artisOrani = 1;
            progressBar1.Step = artisOrani;
            progressBar1.PerformStep();
            sonDeger = progressBar1.Value;
            */
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //timer1.Start();
           // if (sonDeger == 100)
            //{
                Array.Resize(ref kisiler, sayac + 1);

                string cinsiyet;
                if (rdbBayan.Checked)
                    cinsiyet = "Bayan";
                else
                    cinsiyet = "Bay";

                string kisi_detayi = txtAd.Text + "," + txtSoyad.Text + "," + cmbMeslek.SelectedItem.ToString() + "," + cmnSehir.SelectedItem.ToString() + ","+cinsiyet + ","+ nudYas.Value ;

                kisiler[0] = kisi_detayi;
                sayac++;
                //timer1.Stop();
                
            //}
            

            


        
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {

            int goster =Convert.ToInt32(txtGoster.Text);

            if (goster > -1 && goster < kisiler.Length)
            {
                string[] detay_goster = kisiler[goster].Split(',');
                ListViewItem li = new ListViewItem();
                li.Text = detay_goster[0];
                li.SubItems.Add(detay_goster[1]);
                li.SubItems.Add(detay_goster[2]);
                li.SubItems.Add(detay_goster[3]);
                li.SubItems.Add(detay_goster[4]);
                li.SubItems.Add(detay_goster[5]);

                listView1.Items.Add(li);
            }
            else
            {
                MessageBox.Show("Bu index yoktur");
            }

            


            
        }
    
    }
}
