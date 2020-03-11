using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;

namespace FatihYildizhanDbAndFiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBasla.Enabled = false;
            btnKaydet.Enabled = false;
            //Control.CheckForIllegalCrossThreadCalls = false;

            //ListViewItem li = new ListViewItem();
            //li.Text = "5";
            //li.SubItems.Add("Gri");
            //lstMFile.Items.Add(li);

            //ListViewItem li2 = new ListViewItem();
            //li2.Text = "7";
            //li2.SubItems.Add("Mavi");
            //lstMFile.Items.Add(li2);

            //ListViewItem li5 = new ListViewItem();
            //li5.Text = "8";
            //li5.SubItems.Add("Mor");
            //lstMFile.Items.Add(li5);

            //ListViewItem li6 = new ListViewItem();
            //li6.Text = "9";
            //li6.SubItems.Add("Gri");
            //lstMFile.Items.Add(li6);

            //ListViewItem li7 = new ListViewItem();
            //li7.Text = "11";
            //li7.SubItems.Add("Mor");
            //lstMFile.Items.Add(li7);

            //ListViewItem li8 = new ListViewItem();
            //li8.Text = "12";
            //li8.SubItems.Add("Gri");
            //lstMFile.Items.Add(li8);

            //ListViewItem li20 = new ListViewItem();
            //li6.Text = "13";
            //li6.SubItems.Add("Mavi");
            //lstMFile.Items.Add(li20);

            //ListViewItem li21 = new ListViewItem();
            //li7.Text = "15";
            //li7.SubItems.Add("Füme");
            //lstMFile.Items.Add(li21);

            //ListViewItem li22 = new ListViewItem();
            //li8.Text = "17";
            //li8.SubItems.Add("Mor");
            //lstMFile.Items.Add(li22);

            //lstMRec.Tag = 9;
            // 6

            //ListViewItem li3 = new ListViewItem();
            //li3.Text = "U";
            //li3.SubItems.Add("6");
            //li3.SubItems.Add("Bej");
            //lstTFile.Items.Add(li3);

            //ListViewItem li4 = new ListViewItem();
            //li4.Text = "I";
            //li4.SubItems.Add("7");
            //li4.SubItems.Add("Mavi");
            //lstTFile.Items.Add(li4);

            //ListViewItem li10 = new ListViewItem();
            //li10.Text = "I";
            //li10.SubItems.Add("10");
            //li10.SubItems.Add("Mavi");
            //lstTFile.Items.Add(li10);

            //ListViewItem li11 = new ListViewItem();
            //li11.Text = "D";
            //li11.SubItems.Add("12");
            //li11.SubItems.Add("");
            //lstTFile.Items.Add(li11);

            //ListViewItem li12 = new ListViewItem();
            //li12.Text = "D";
            //li12.SubItems.Add("13");
            //li12.SubItems.Add("");
            //lstTFile.Items.Add(li12);

            //ListViewItem li13 = new ListViewItem();
            //li13.Text = "I";
            //li13.SubItems.Add("14");
            //li13.SubItems.Add("Füme");
            //lstTFile.Items.Add(li13);

            //ListViewItem li23 = new ListViewItem();
            //li12.Text = "U";
            //li12.SubItems.Add("15");
            //li12.SubItems.Add("Mavi");
            //lstTFile.Items.Add(li23);

            //ListViewItem li24 = new ListViewItem();
            //li13.Text = "D";
            //li13.SubItems.Add("16");
            //li13.SubItems.Add("");
            //lstTFile.Items.Add(li24);

        }

        // Yapılan tüm işlemlerin kaydını tutan değişkenler 

        int toplamIslemSayisi = 0;
        int toplamInsertSayisi = 0;
        int toplamUpdateSayisi = 0;
        int toplamHataSayisi = 0;
        int toplamDeleteSayisi = 0;

        // Kaçıncı Sıradaki Veri'nin gönderileceğini tutuan değişkenler

        int mFileKacinciGonderilecek = 0;
        int tFileKacinciGonderilecek = 0;

        // Gelen Veri'nin kaçıncı sıraya yerleşeceğini tutan değişkenler

        int newMFileKacinciGeldi = 1;
        int hataDosyKacinciGeldi = 1;

        Label ll;
        ListViewItem liGiden;

        public void LabeliGoster()
        {
            ll.BringToFront();
        }
        // Verileri Gönderen fonksiyonlar

        public void MFileToMRec()
        {
                try
                {
                    lstMFile.Items[mFileKacinciGonderilecek].BackColor = Color.Red;
                    ListViewItem li = new ListViewItem();
                    li = lstMFile.Items[mFileKacinciGonderilecek];

                    string item = li.Text + "               " + li.SubItems[1].Text;

                    Label l = new Label();
                    l.Left = li.Position.X + 14;
                    l.Top = li.Position.Y + 38;
                    l.Text = item;
                    l.BackColor = Color.Blue;
                    l.Height = 19;
                    l.Width = 205;

                    this.Controls.Add(l);
                    ll = l;
                    liGiden = li;

                    LabeliGoster();

                    timerMFileToMRec.Start();
                    mFileKacinciGonderilecek++;
                    kacItemVar--;
                }
                catch (Exception)
                {


                }
        }
        public void MRecToNewMFile()
        {
                try
                {
                    ListViewItem li = new ListViewItem();
                    li = lstMRec.Items[0];

                    string item = li.Text + "               " + li.SubItems[1].Text;

                    Label l = new Label();
                    l.Left = li.Position.X + 14;
                    l.Top = li.Position.Y + 267;
                    l.Text = item;
                    l.BackColor = Color.Blue;
                    l.Height = 19;
                    l.Width = 188;

                    this.Controls.Add(l);
                    ll = l;
                    liGiden = li;
                    LabeliGoster();
                    timerMRecToNewMFile.Start();
                }
                catch (Exception)
                {


                }
        }
        public void TFileToTRec()
        {
                try
                {
                    lstTFile.Items[tFileKacinciGonderilecek].BackColor = Color.Red;
                    ListViewItem li = new ListViewItem();
                    li = lstTFile.Items[tFileKacinciGonderilecek];

                    string item = li.Text + "       " + li.SubItems[1].Text+"              "+li.SubItems[2].Text;

                    Label l = new Label();
                    l.Left = li.Position.X + 236;
                    l.Top = li.Position.Y + 38;
                    l.Text = item;
                    l.BackColor = Color.Blue;
                    l.Height = 19;
                    l.Width = 205;

                    this.Controls.Add(l);
                    ll = l;
                    liGiden = li;

                    LabeliGoster();
                   
                    timerTFileToTRec.Start();
                    tFileKacinciGonderilecek++;
                }
                catch (Exception)
                {


                }
        }
        public void TRecToHataDosyasi()
        {
                try
                {
                    ListViewItem li = new ListViewItem();
                    li = lstTRec.Items[0];

                    string item = li.Text + "       " + li.SubItems[1].Text + "              " + li.SubItems[2].Text;

                    Label l = new Label();
                    l.Left = li.Position.X + 236;
                    l.Top = li.Position.Y + 267;
                    l.Text = item;
                    l.BackColor = Color.Blue;
                    l.Height = 19;
                    l.Width = 187;

                    this.Controls.Add(l);
                    ll = l;
                    liGiden = li;
                    LabeliGoster();
                    timerTRecToHataDosyasi.Start();
                }
                catch (Exception)
                {


                }
        }
        public void TRecToNewMFile()
        {
                try
                {
                    ListViewItem li = new ListViewItem();
                    li = lstTRec.Items[0];

                    ListViewItem li2 = new ListViewItem();
                    li2.Text = lstTRec.Items[0].SubItems[1].Text;
                    li2.SubItems.Add(lstTRec.Items[0].SubItems[2].Text);

                    string item = lstTRec.Items[0].SubItems[1].Text + "              " + lstTRec.Items[0].SubItems[2].Text;

                    Label l = new Label();
                    l.Left = li.Position.X + 236;
                    l.Top = li.Position.Y + 267;
                    l.Text = item;
                    l.BackColor = Color.Blue;
                    l.Height = 19;
                    l.Width = 187;

                    this.Controls.Add(l);
                    ll = l;
                    liGiden = li2;
                    LabeliGoster();
                    timerTRecToNewMFile.Start();
                }
                catch (Exception)
                {
                }
        }

        // Update işleminde, TRec'deki veriyi MRec'deki ile değiştiren fonksiyon
        public void islemUpdateYerDegistir()
        {
            lstMRec.Items[0].SubItems[0].Text = lstTRec.Items[0].SubItems[1].Text;
            lstMRec.Items[0].SubItems[1].Text = lstTRec.Items[0].SubItems[2].Text;
        }

        // Animasyon Left Özelliğini Ayarla
        // Animasyon Top Özelliğini Ayarla
        bool left = false;
        bool top = false;

        private void timerMRecToNewMFile_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ll.Top < 369 + (20*newMFileKacinciGeldi) && ll.Top<=549)
                {
                    ll.Top++;
                }
                else
                {
                    top = true;
                }

                if (top)
                {
                    timerMRecToNewMFile.Stop();
                    top = false;

                    ll.Visible = false;
                    ListViewItem li = new ListViewItem();
                    li.Text = liGiden.Text;
                    li.SubItems.Add(liGiden.SubItems[1]);
                    li.BackColor = Color.Blue;
                    lstNewMFile.Items.Add(li);
                    newMFileKacinciGeldi++;

                    btnBasla.Enabled = true;
                    btnKaydet.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }
        private void timerTFileToTRec_Tick(object sender, EventArgs e)
        {
            if (ll.Top < 265 + 27)
            {
                ll.Top++;
            }
            else
            {
                top = true;
            }

            if (top)
            {
                timerTFileToTRec.Stop();
                top = false;

                ll.Visible = false;

                lstTRec.Items.Clear();

                ListViewItem li = new ListViewItem();
                li.Text = liGiden.Text;
                li.SubItems.Add(liGiden.SubItems[1]);
                li.SubItems.Add(liGiden.SubItems[2]);
                li.BackColor = Color.Blue;
                lstTRec.Items.Add(li);

                btnBasla.Enabled = true;
                btnKaydet.Enabled = true;
            }

        }
        private void timerTRecToHataDosyasi_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ll.Top < 369 + (20 * hataDosyKacinciGeldi) && ll.Top <= 540)
                {
                    ll.Top++;
                }
                else
                {
                    top = true;
                }

                if (top)
                {
                    timerTRecToHataDosyasi.Stop();
                    top = false;

                    ll.Visible = false;
                    ListViewItem li = new ListViewItem();
                    li.Text = liGiden.Text;
                    li.SubItems.Add(liGiden.SubItems[1]);
                    li.SubItems.Add(liGiden.SubItems[2]);
                    li.BackColor = Color.Blue;
                    lstHataDosyasi.Items.Add(li);
                    hataDosyKacinciGeldi++;

                    btnBasla.Enabled = true;
                    btnKaydet.Enabled = true;
                }
            }
            catch (Exception)
            {
            }
        }
        private void timerMFileToMRec_Tick(object sender, EventArgs e)
        {
            if (ll.Left < 12 + 4)
            {
                ll.Left++;
            }
            else
            {
                left = true;
            }

            if (ll.Top < 265 + 27)
            {
                ll.Top++;
            }
            else
            {
                top = true;
            }

            if (top && left)
            {
                timerMFileToMRec.Stop();
                left = false;
                top = false;

                ll.Visible = false;

                lstMRec.Items.Clear();

                ListViewItem li = new ListViewItem();
                li.Text = liGiden.Text;
                li.SubItems.Add(liGiden.SubItems[1]);
                li.BackColor = Color.Blue;
                lstMRec.Items.Add(li);

                btnBasla.Enabled = true;
                btnKaydet.Enabled = true;
            }
        }
        private void timerTRecToNewMFile_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ll.Left != 12)
                {
                    ll.Left--;
                }
                else
                {
                    left = true;
                }

                if (ll.Top < 375 + (20 * newMFileKacinciGeldi) && ll.Top <= 540)
                {
                    ll.Top++;
                }
                else
                {
                    top = true;
                }

                if (top&&left)
                {
                    timerTRecToNewMFile.Stop();
                    top = false;
                    left = false;
                    ll.Visible = false;
                    ListViewItem li = new ListViewItem();
                    li.Text = liGiden.Text;
                    li.SubItems.Add(liGiden.SubItems[1]);
                    li.BackColor = Color.Blue;
                    lstNewMFile.Items.Add(li);
                    newMFileKacinciGeldi++;

                    btnBasla.Enabled = true;
                    btnKaydet.Enabled = true;
                }
            }
            catch (Exception)
            {
            }

        }

        // Fonksiyonlar
        // Insert , Delete , Update 
        public void islemInsert(int MRecFile, int TRecFile)
        {
            try
            {
                if(MRecFile<TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 3;
                    siradakiadim[1] = 2;
                    //MRecToNewMFile();
                    //MFileToMRec();
                }
                else if(MRecFile==TRecFile)
                {
                    siradakiadim = new int[4];
                    siradakiadim[0] = 4;
                    siradakiadim[1] = 3;
                    siradakiadim[2] = 2;
                    siradakiadim[3] = 1;
                    //TRecToHataDosyasi();
                    //MRecToNewMFile();
                    //MFileToMRec();
                    //TFileToTRec();

                }
                else if(MRecFile>TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 5;
                    siradakiadim[1] = 1;
                    //TRecToNewMFile();
                    //TFileToTRec();
                }
                else{}
            }
            catch (Exception)
            {
                
            }
            Basla();
        }
        public void islemDelete(int MRecFile, int TRecFile)
        {
            try
            {
                if(MRecFile<TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 3;
                    siradakiadim[1] = 2;

                    //MRecToNewMFile();
                    //MFileToMRec();
                }
                else if(MRecFile==TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 1;
                    siradakiadim[1] = 2;

                    //TFileToTRec();
                    //MFileToMRec();
                }
                else if(MRecFile>TRecFile)
                {
                    siradakiadim = new int[3];
                    siradakiadim[0] = 4;
                    siradakiadim[1] = 3;
                    siradakiadim[1] = 1;

                    //TRecToHataDosyasi();
                    //MRecToNewMFile();
                    //TFileToTRec();
                }
                else{}
            }
            catch (Exception)
            {
                
            }
            Basla();
        }
        public void islemUpdate(int MRecFile, int TRecFile)
        {
            try
            {
                if(MRecFile<TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 3;
                    siradakiadim[1] = 2;

                    //MRecToNewMFile();
                    //MFileToMRec();
                }
                else if (MRecFile == TRecFile)
                {
                    islemUpdateYerDegistir();

                    siradakiadim = new int[3];
                    siradakiadim[0] = 3;
                    siradakiadim[1] = 1;
                    siradakiadim[2] = 2;

                    //MRecToNewMFile();
                    //TFileToTRec();
                    //MFileToMRec();
                }
                else if(MRecFile>TRecFile)
                {
                    siradakiadim = new int[2];
                    siradakiadim[0] = 4;
                    siradakiadim[1] = 1;

                    //TRecToHataDosyasi();
                    //TFileToTRec();
                }
                else{}
            }
            catch (Exception)
            {
                
            }
            Basla();
        }
       
        // Sıradaki Adımı Belirleyen Kontroller

        // Bool adim1 = TFileToTRec
        // Bool adim2 = MFileToMRec
        // Bool adim3 = MRecToNewMFile
        // Bool adim4 = TRecToHataDosyasi
        // Bool adim5 = TrecToNewMFile
        // Bool adim6 = Karşılaştır

        // Sıradaki İşlem Numarasının Tutulduğu int Array
        
        int[] siradakiadim;
        int i = 0;

        int acilis = 0;
        bool MRecYeniDegerGeldiMi = false;
        bool TRecYeniDegerGeldiMi = false;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Basla();
            btnBasla.Enabled = false;
            btnKaydet.Enabled = false;
            if (kacItemVar == 0 && MRecYeniDegerGeldiMi == false && TRecYeniDegerGeldiMi == false)
            {
                MessageBox.Show("İşlenecek Veri Kalmadı");


                btnKaydet.Enabled = true;

                btnTFileOku.Enabled = true;
                btnMFileOku.Enabled = true;

                btnBasla.Enabled = false;
            }
        }


        int kacItemVar = 0;
        private void Basla()
        {
            try
            {
                toplamIslemSayisi++;
                if (siradakiadim == null)
                {
                    if (acilis == 0)
                    {
                        TFileToTRec();
                        acilis++;
                    }
                    else if (acilis == 1)
                    {
                        MFileToMRec();
                        acilis++;
                    }
                    else
                    {
                        CompareMRecToTRec();
                    }
                }
                else if (siradakiadim.Length > i)
                {
                    if (siradakiadim[i] == 1)
                    {
                        TFileToTRec();
                        TRecYeniDegerGeldiMi = true;
                    }
                    else if (siradakiadim[i] == 2)
                    {
                        MFileToMRec();
                        MRecYeniDegerGeldiMi = true;
                        lstMFile.Tag = Convert.ToInt32(lstMFile.Tag) - 1;
                    }
                    else if (siradakiadim[i] == 3)
                    {
                        MRecToNewMFile();
                    }
                    else if (siradakiadim[i] == 4)
                    {
                        TRecToHataDosyasi();
                        toplamHataSayisi++;
                    }
                    else if (siradakiadim[i] == 5)
                    {
                        TRecToNewMFile();
                    }
                    i++;
                }
                else if (TRecYeniDegerGeldiMi || MRecYeniDegerGeldiMi)
                {
                    CompareMRecToTRec();
                }
               
            }
            catch (Exception)
            {
            }
            btnKaydet.Enabled = true;
        }

        bool mFileOkunduMu = false;
        bool tFileOkunduMu = false;

        private void btnMFileOku_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "M-File Yükle";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = false;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    StreamReader str = new StreamReader(fs);


                    string satir = str.ReadToEnd();
                    //MessageBox.Show(satir);

                    fs.Close();
                    str.Close();

                    if (satir.Contains(":") && satir.Contains(";"))
                    {
                        string[] dizi = satir.Split(':');

                        //lstMFile.Tag = dizi.Length + 1;
                        kacItemVar = dizi.Length;

                        for (int i = 0; i < dizi.Length; i++)
                        {
                            string[] dizicik = dizi[i].Split(';');

                            //if (dizicik.Length == 2)
                            //{
                                ListViewItem li = new ListViewItem();
                                li.Text = dizicik[0].ToString();
                                li.SubItems.Add(dizicik[1].ToString());

                                lstMFile.Items.Add(li);
                            //}
                            //else
                            //{
                            //    DialogResult dr = MessageBox.Show("Lütfen M-File Formatında Dosya Seçiniz!", "Uyarı 1: '5;Gri:'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    if (DialogResult.OK == dr)
                            //    {
                            //        break;
                            //    }
                            //}
                        }
                        mFileOkunduMu = true;
                        btnMFileOku.Enabled = false;
                        if (mFileOkunduMu && tFileOkunduMu)
                        {
                            btnBasla.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen M-File Formatında Dosya Seçiniz!", "Uyarı 2: '5;Gri:'", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnTFileOku_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Title = "T-File Yükle";
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.Multiselect = false;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    StreamReader str = new StreamReader(fs);


                    string satir = str.ReadToEnd();
                    //MessageBox.Show(satir);

                    fs.Close();
                    str.Close();

                    if (satir.Contains(":") && satir.Contains(";"))
                    {
                        string[] dizi = satir.Split(':');

                        for (int i = 0; i < dizi.Length; i++)
                        {
                            string[] dizicik = dizi[i].Split(';');

                            //if (dizicik.Length != 3 && i==0)
                            //{
                                ListViewItem li = new ListViewItem();
                                li.Text = dizicik[0].ToString();
                                li.SubItems.Add(dizicik[1].ToString());
                                li.SubItems.Add(dizicik[2].ToString());

                                lstTFile.Items.Add(li);
                            //}
                            //else
                            //{
                            //    DialogResult dr = MessageBox.Show("Lütfen T-File Formatında Dosya Seçiniz!", "Uyarı 3: 'U;6;Bej:'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //    if (DialogResult.OK == dr)
                            //    {
                            //        break;
                            //    }
                            //}

                        }
                        btnTFileOku.Enabled = false;
                        tFileOkunduMu = true;
                        if (mFileOkunduMu && tFileOkunduMu)
                        {
                            btnBasla.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen T-File Formatında Dosya Seçiniz!", "Uyarı 4: 'U;6;Bej:'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
        
        public void CompareMRecToTRec()
        {
            MRecYeniDegerGeldiMi = false;
            TRecYeniDegerGeldiMi = false;
            i = 0;
                int MRecFile = Convert.ToInt32(lstMRec.Items[0].SubItems[0].Text);
                int TRecFile = Convert.ToInt32(lstTRec.Items[0].SubItems[1].Text);

                string islemAdi = lstTRec.Items[0].SubItems[0].Text;
                try
                {
                    if (islemAdi == "I")
                    {
                        islemInsert(MRecFile, TRecFile);
                        toplamInsertSayisi++;
                    }
                    else if (islemAdi == "U")
                    {
                        islemUpdate(MRecFile, TRecFile);
                        toplamUpdateSayisi++;
                    }
                    else if (islemAdi == "D")
                    {
                        islemDelete(MRecFile, TRecFile);
                        toplamDeleteSayisi++;
                    }
                }
                catch (Exception)
                {

                }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 3)
                {

                    StreamWriter sw = new StreamWriter(sfd.FileName);

                    string veri = "";
                    for (int i = 0; i < lstNewMFile.Items.Count; i++)
                    {
                        if (i == (lstNewMFile.Items.Count - 1))
                        {
                            veri += lstNewMFile.Items[i].SubItems[0].Text + ";" + lstNewMFile.Items[i].SubItems[1].Text;
                        }
                        else if (i < lstNewMFile.Items.Count)
                        {
                            veri += lstNewMFile.Items[i].SubItems[0].Text + ";" + lstNewMFile.Items[i].SubItems[1].Text + ":";
                        }
                    }
                    sw.WriteLine(veri);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                
            }

            
        }
    }
}
