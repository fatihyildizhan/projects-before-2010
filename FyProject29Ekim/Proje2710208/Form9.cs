using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje2710208
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        string[] seferler = new string[0];
        int sayac = 0;
        string[] otobusler = new string[0];
        int sayacOto = 0;
        string[] helikopter = new string[0];
        int sayacKop = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            for (int i = 0; i < seferler.Length; i++)
            {
                string[] dizi = seferler[i].Split(',');
                if (dizi[0] == txtSeferNo.Text)
                {
                    kontrol = false;
                }
            }

            if (kontrol == true)
            {
                Array.Resize(ref seferler, sayac + 1);

                string sefertipi = "";
                if (rdbAktarma.Checked==true)
                {
                    sefertipi = "Aktarmalı";
                }
                else
                {
                    sefertipi = "Ekspres";
                }


                string seferbilgisi = txtSeferNo.Text + "," + cmbNerden.SelectedItem.ToString() + "," + cmbNereye.SelectedItem.ToString() + "," + dateTimePicker1.Value.ToShortDateString() + "," + sefertipi;

                seferler[sayac]= seferbilgisi;
                sayac++;
            }
            else
            {
                MessageBox.Show("seferler No Mevcuttur!");
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (chkNerden.Checked == true && chkTarih.Checked)
            {
                
                foreach (string seferdetayi in seferler)
                {
                    string[] seferbilgisi2 = seferdetayi.Split(',');
                    if (seferbilgisi2[1]==cmbAramaKalkis.SelectedItem.ToString()&&seferbilgisi2[3]==dateTimePicker2.Value.ToShortDateString())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = seferbilgisi2[0].ToString();
                        li.SubItems.Add(seferbilgisi2[1].ToString());
                        li.SubItems.Add(seferbilgisi2[2].ToString());
                        li.SubItems.Add(seferbilgisi2[3].ToString());
                        li.SubItems.Add(seferbilgisi2[4].ToString());
                        listView1.Items.Add(li);
                    }
                }
                
            }
            else if (chkNerden.Checked)
            {
                foreach (string item in seferler)
                {
                    string[] seferbilgisi3 = item.Split(',');
                    if (seferbilgisi3[1] == cmbAramaKalkis.SelectedItem.ToString())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = seferbilgisi3[0].ToString();
                        li.SubItems.Add(seferbilgisi3[1].ToString());
                        li.SubItems.Add(seferbilgisi3[2].ToString());
                        li.SubItems.Add(seferbilgisi3[3].ToString());
                        li.SubItems.Add(seferbilgisi3[4].ToString());
                        listView1.Items.Add(li);
                    }

                }
            }
            else if(chkTarih.Checked)
            {
                foreach (string item in seferler)
                {
                    string[] seferbilgisi4 = item.Split(',');
                    if (seferbilgisi4[3] == dateTimePicker2.Value.ToShortDateString())
                    {
                        ListViewItem li = new ListViewItem();
                        li.Text = seferbilgisi4[0].ToString();
                        li.SubItems.Add(seferbilgisi4[1].ToString());
                        li.SubItems.Add(seferbilgisi4[2].ToString());
                        li.SubItems.Add(seferbilgisi4[3].ToString());
                        li.SubItems.Add(seferbilgisi4[4].ToString());
                        listView1.Items.Add(li);
                    }
                }                    


            }
        }

        private void cmbNereye_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOtobusekle_Click(object sender, EventArgs e)
        {
            bool denetim = true;
            foreach (string item in otobusler)
            {
                string[] otobuslerDetay = item.Split(',');
                if (otobuslerDetay[3] == txtPlaka.Text)
                {
                    denetim = false;
                }
            }

            if (denetim = true)
            {
                Array.Resize(ref otobusler, sayacOto + 1);
                string otobusBilgisi = txtKoltuk.Text + "," + txtMarka.Text + "," + txtModel.Text + "," + txtPlaka.Text;

                otobusler[sayacOto] = otobusBilgisi;
                sayacOto++;
            }
            else
            {
                MessageBox.Show("Girdiğiniz plaka Mevcuttur!");
            }
        }

        private void btnHelikopter_Click(object sender, EventArgs e)
        {
            bool dene = true;
            foreach (string item in helikopter)
            {
                string[] helikopterDetay = item.Split(',');
                if (helikopterDetay[1] == cbmModel.SelectedItem.ToString())
                {
                    dene = false;
                }
            }


            if (dene == true)
            {
                Array.Resize(ref helikopter, sayacKop + 1);

                string denetleme = "";
                if (rdbVar.Checked)
                    denetleme = "Var";
                else
                    denetleme = "Yok";

                string helikopterDetay = cmbHelKoltuk.SelectedItem.ToString() + "," + cbmModel.SelectedItem.ToString() + "," + denetleme;

                helikopter[sayacKop] = helikopterDetay;
                sayacKop++;
            }
            else
                MessageBox.Show("Seçmiş Olduğunuz Model Mevcuttur!");

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        
    }
}
