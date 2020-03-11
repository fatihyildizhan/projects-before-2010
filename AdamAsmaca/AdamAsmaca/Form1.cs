using System;
using System.Windows.Forms;

namespace AdamAsmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string kelime = null;
        string kullanilanHarfler = "";
        int dogruTahminSayisi = 0;
        int hak = 0;
        int yanlisTahminSayisi = 0;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            if (kelime == null || hak == 0)
            {
                btnTahmin.Enabled = false;
            }
            else
            {
                btnTahmin.Enabled = true;
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            if (txtKelime.Text != "" && txtKelime.Text.Length==5)
            {
                DegerleriSifirla();

                kelime = txtKelime.Text;
                hak = Convert.ToInt32(numericUpDown1.Value);
                lblDogruTahminSayisi.Text = dogruTahminSayisi.ToString();
                lblKalanHakSayisi.Text = hak.ToString();
                lblKullanilanHarfler.Text = kullanilanHarfler;
                lblYanlisTahminSayisi.Text = yanlisTahminSayisi.ToString();
                btnBasla.Enabled = false;
                btnTahmin.Enabled = true;
                
                lblKelimeler.Text += txtKelime.Text+", ";
                txtKelime.Text = "";

            }
            else
            {
                MessageBox.Show("Lütfen 5 harfli bir kelime giriniz!");
            }
        }

        private void DegerleriSifirla()
        {
            kelime = null;
            kullanilanHarfler = "";
            dogruTahminSayisi = 0;
            hak = 0;
            yanlisTahminSayisi = 0;
            lblHarfSonuc.Text = "";
            progressBar1.Value = 0;
            label1.Text = "*";
            label2.Text = "*";
            label3.Text = "*";
            label4.Text = "*";
            label5.Text = "*";
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (kullanilanHarfler.IndexOf(textBox1.Text) != -1)
                {
                    MessageBox.Show("Bu harf daha önce girilmiş");
                }
                else
                {
                    int[] indxi = new int[0];
                    int sayac = 0;
                    for (int i = 0; i < kelime.Length; i++)
                    {
                        if (kelime[i] == Convert.ToChar(textBox1.Text))
                        {
                            Array.Resize(ref indxi, sayac + 1);
                            indxi[sayac] = i;
                            sayac++;
                        }
                    }

                    if (indxi.Length > 0)
                    {
                        btnTahmin.Enabled = false;
                        int bulunanHarfSayisi = 0;

                        if (Array.IndexOf(indxi, 0) != -1)
                        {
                            label1.Text = textBox1.Text;
                            dogruTahminSayisi++;
                            bulunanHarfSayisi++;
                        }
                        if (Array.IndexOf(indxi, 1) != -1)
                        {
                            label2.Text = textBox1.Text;
                            dogruTahminSayisi++;
                            bulunanHarfSayisi++;
                            }
                        if (Array.IndexOf(indxi, 2) != -1)
                        {
                            label3.Text = textBox1.Text;
                            dogruTahminSayisi++;
                            bulunanHarfSayisi++;
                            }
                        if (Array.IndexOf(indxi, 3) != -1)
                        {
                            label4.Text = textBox1.Text;
                            dogruTahminSayisi++;
                            bulunanHarfSayisi++;
                            }
                        if (Array.IndexOf(indxi, 4) != -1)
                        {
                            label5.Text = textBox1.Text;
                            dogruTahminSayisi++;
                            bulunanHarfSayisi++;
                            }
                        lblHarfSonuc.Text = bulunanHarfSayisi + " tane " + textBox1.Text + " varmış!";
                        timer1.Start();
                    }
                    else
                    {
                        hak--;
                        yanlisTahminSayisi++;
                        lblHarfSonuc.Text = "DOBROSKİ!!!";
                    }
                    if (hak == 0)
                    {
                        MessageBox.Show("Oyun bitti napalım");
                        btnTahmin.Enabled = false;
                        btnBasla.Enabled = true;
                        DegerleriSifirla();
                    }
                    kullanilanHarfler += textBox1.Text + " , ";

                    lblDogruTahminSayisi.Text = dogruTahminSayisi.ToString();
                    lblKalanHakSayisi.Text = hak.ToString();
                    lblKullanilanHarfler.Text = kullanilanHarfler;
                    lblYanlisTahminSayisi.Text = yanlisTahminSayisi.ToString();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir harf giriniz");
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int artisOrani = 0;
            artisOrani += 2;
            progressBar1.Step = artisOrani;
            progressBar1.PerformStep();
            int SuAnkiDeger = progressBar1.Value;
            if (SuAnkiDeger == 20 && dogruTahminSayisi==1)
            {
                timer1.Stop();
                btnTahmin.Enabled = true;
            }
            else if (SuAnkiDeger == 40 && dogruTahminSayisi==2)
            {
                timer1.Stop();
                btnTahmin.Enabled = true;
            }
            else if (SuAnkiDeger == 60 && dogruTahminSayisi == 3)
            {
                timer1.Stop();
                btnTahmin.Enabled = true;
            }
            else if (SuAnkiDeger == 80 && dogruTahminSayisi == 4)
            {
                timer1.Stop();
                btnTahmin.Enabled = true;
            }
            else if (SuAnkiDeger == 100 && dogruTahminSayisi == 5)
            {
                timer1.Stop();
                MessageBox.Show("Tebrikler Kazandınız...");
                btnTahmin.Enabled = false;
                btnBasla.Enabled = true;
            }
        }

        private void txtKelime_MouseClick(object sender, MouseEventArgs e)
        {
            txtKelime.Text = "";
        }
    }
    //Fatih Yıldızhan && DoXa && 09'
    //fatih@yildizhanlar.com
    //https://fatihyildizhan.com
}