using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaOtobusFirmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] seferler = new string[0];
        int sayac = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtSeferNo.Text != "" && cmbNerden.Text != "" && cmbNereye.Text != "")
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
                    if (rdbAktarma.Checked == true)
                    {
                        sefertipi = "Aktarmalı";
                    }
                    else
                    {
                        sefertipi = "Ekspres";
                    }


                    string seferbilgisi = txtSeferNo.Text + "," + cmbNerden.SelectedItem.ToString() + "," + cmbNereye.SelectedItem.ToString() + "," + dateTimePicker1.Value.ToShortDateString() + "," + sefertipi;

                    seferler[sayac] = seferbilgisi;
                    sayac++;
                }
                else
                {
                    MessageBox.Show("seferler No Mevcuttur!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz..");
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
                    if (seferbilgisi2[1] == cmbAramaKalkis.SelectedItem.ToString() && seferbilgisi2[3] == dateTimePicker2.Value.ToShortDateString())
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
            else if (chkTarih.Checked)
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

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!chkNerden.Checked && !chkTarih.Checked)
            {
                MessageBox.Show("Lütfen Arama Kriteri Seçiniz!");
            }
            else
            {
                if (chkNerden.Checked && chkTarih.Checked)
                {

                    foreach (string seferdetayi in seferler)
                    {
                        string[] seferbilgisi2 = seferdetayi.Split(',');
                        if (seferbilgisi2[1] == cmbAramaKalkis.SelectedItem.ToString() && seferbilgisi2[3] == dateTimePicker2.Value.ToShortDateString())
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
                else if (chkTarih.Checked)
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
        }
    }
    //Fatih Yıldızhan && DoXa && 09'
    //fatih@yildizhanlar.com
    //www.fatihyildizhan.com
}
