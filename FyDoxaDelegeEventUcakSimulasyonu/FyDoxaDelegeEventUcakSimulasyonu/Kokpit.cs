using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaDelegeEventUcakSimulasyonu
{
    public partial class Kokpit : Form
    {
        public Kokpit()
        {
            InitializeComponent();
        }
        Ucak u = new Ucak();
        public static int calisanMotorSayisi;

        private void Kokpit_Load(object sender, EventArgs e)
        {
            u.alcaldi += new Ucak.YukseklikOlcer(u_alcaldi);
            u.benzinAzaldi += new Ucak.BenzinOlcer(u_benzinAzaldi);
            u.benzinBitti += new Ucak.BenzinOlcer(u_benzinBitti);
            u.benzinNormal += new Ucak.BenzinOlcer(u_benzinNormal);
            u.gunesAciyor += new Ucak.HavaDurumuDegisimi(u_gunesAciyor);
            u.havalandi += new Ucak.YukseklikOlcer(u_havalandi);
            u.hizlandi += new Ucak.HizOlcer(u_hizlandi);
            u.inisYapti += new Ucak.YukseklikOlcer(u_inisYapti);
            u.karYagiyor += new Ucak.HavaDurumuDegisimi(u_karYagiyor);
            u.ruzgarEsiyor += new Ucak.HavaDurumuDegisimi(u_ruzgarEsiyor);
            u.sicaklikArtti += new Ucak.HavaSicakligiDegisimi(u_sicaklikArtti);
            u.sicaklikDustu += new Ucak.HavaSicakligiDegisimi(u_sicaklikDustu);
            u.sicaklikNormal += new Ucak.HavaSicakligiDegisimi(u_sicaklikNormal);
            u.yagmurYagiyor += new Ucak.HavaDurumuDegisimi(u_yagmurYagiyor);
            u.yavasladi += new Ucak.HizOlcer(u_yavasladi);
            u.yukseldi += new Ucak.YukseklikOlcer(u_yukseldi);
            u.motorCalisti += new Ucak.MotorDurumu(u_motorCalisti);
            u.motorDurdu += new Ucak.MotorDurumu(u_motorDurdu);

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void u_motorDurdu(int motorNo)
        {
            if (motorNo == 1)
            {
                calisanMotorSayisi--;
                btnMotor1Calistir.Text = "ÇALIŞTIR";
                pnlMotor1CalisiyorMu.BackColor = Color.Red;
            }
            else if (motorNo == 2)
            {
                calisanMotorSayisi--;
                btnMotor2Calistir.Text = "ÇALIŞTIR";
                pnlMotor2CalisiyorMu.BackColor = Color.Red;
            }
            if (calisanMotorSayisi == 0)
            {
                timer1.Stop();
            }   
        }

        void u_motorCalisti(int motorNo)
        {
            if (motorNo == 1)
            {
                calisanMotorSayisi++;
                btnMotor1Calistir.Text = "DURDUR";
                pnlMotor1CalisiyorMu.BackColor = Color.Green;
            }
            else if (motorNo == 2)
            {
                calisanMotorSayisi++;
                btnMotor2Calistir.Text = "DURDUR";
                pnlMotor2CalisiyorMu.BackColor = Color.Green;
            }
            btnMotorGaz.Enabled = true;
        }

        void u_yukseldi(int yukseklik)
        {
            txtUcakYukseklik.Text = "Yükseliyor...";
            txtUcakYukseklik.BackColor = Color.DarkOrange;
        }

        void u_yavasladi(int hiz)
        {
            txtUcakHiz.Text = "Yavaş Gidiyor...";
            txtUcakHiz.BackColor = Color.DarkSlateBlue;
        }

        void u_yagmurYagiyor(string havaDurumu)
        {
            throw new NotImplementedException();
        }

        void u_sicaklikNormal(int havaSicakligi)
        {
          
        }

        void u_sicaklikDustu(int havaSicakligi)
        {
            
        }

        void u_sicaklikArtti(int havaSicakligi)
        {
            
        }

        void u_ruzgarEsiyor(string havaDurumu)
        {
            throw new NotImplementedException();
        }

        void u_karYagiyor(string havaDurumu)
        {
            throw new NotImplementedException();
        }

        void u_inisYapti(int yukseklik)
        {
            txtUcakYukseklik.Text = "Piste İndi";
            txtUcakYukseklik.BackColor = Color.Green;
        }

        void u_hizlandi(int hiz)
        {
            txtUcakHiz.Text = "hızlandı";
            txtUcakHiz.BackColor = Color.Red;
        }

        void u_havalandi(int yukseklik)
        {
            txtUcakYukseklik.Text = "havalandı";
            txtUcakYukseklik.BackColor = Color.BlueViolet;
            btnAlcal.Enabled = true;
        }

        void u_gunesAciyor(string havaDurumu)
        {
            throw new NotImplementedException();
        }

        void u_benzinNormal(int benzinMiktari)
        {
            txtUcakBenzin.Text = "Normal Seviye.";
            txtUcakBenzin.BackColor = Color.Green;
        }

        void u_benzinBitti(int benzinMiktari)
        {
            timer2.Stop();
            timer2.Stop();
            txtUcakBenzin.Text = "Benzin Bitti!";
            txtUcakBenzin.BackColor = Color.Red;
            
        }

        void u_benzinAzaldi(int benzinMiktari)
        {
            txtUcakBenzin.Text = "Benzin Azaldı...";
            timer2.Start();
        }

        void u_alcaldi(int yukseklik)
        {
            txtUcakYukseklik.Text = "Düşük İrtifa";
            txtUcakYukseklik.BackColor = Color.DarkGoldenrod;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnMotor1Calistir_Click(object sender, EventArgs e)
        {
            if (cmbPilotAdi.SelectedItem != null && cmbCoPilotAdi.SelectedItem != null && cmbKalkisYeri.SelectedItem!=null&&cmbVarisYeri.SelectedItem!=null && cmbYolcuSayisi.SelectedItem!=null && cmbPersonelSayisi.SelectedItem!=null)
            {
                cmbCoPilotAdi.Enabled = false;
                cmbPilotAdi.Enabled = false;
                cmbVarisYeri.Enabled = false;
                cmbKalkisYeri.Enabled = false;
                cmbPersonelSayisi.Enabled = false;
                cmbYolcuSayisi.Enabled = false;

                if (btnMotor1Calistir.Text == "DURDUR")
                {
                    u.Motor1Calisiyor = false;
                }
                else
                {
                    u.Motor1Calisiyor = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayınız!");
            }
        }
        private void btnMotor2Calistir_Click(object sender, EventArgs e)
        {
            if (cmbPilotAdi.SelectedItem != null && cmbCoPilotAdi.SelectedItem != null && cmbKalkisYeri.SelectedItem != null && cmbVarisYeri.SelectedItem != null)
            {
                cmbCoPilotAdi.Enabled = false;
                cmbPilotAdi.Enabled = false;
                cmbVarisYeri.Enabled = false;
                cmbKalkisYeri.Enabled = false;

                txtUcakYerelSaat.Text = DateTime.Now.ToShortTimeString();

                if (btnMotor2Calistir.Text == "DURDUR")
                {
                    u.Motor2Calisiyor = false;
                }
                else
                {
                    u.Motor2Calisiyor = true;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Bilgileri Tamamlayınız!");
            }
        }
      
        private void btnMotorGaz_Click(object sender, EventArgs e)
        {
            u.Hiz += 50;
            if (u.Hiz > 299)
            {
                btnYuksel.Enabled = true;
            }
            btnMotorFren.Enabled = true;
            gostergeGuncelle();
            txtUcakUcusSuresi.Text = u.UcusSuresi.Hour + ":" + u.UcusSuresi.Minute + ":" + u.UcusSuresi.Second;
            timer1.Start();
        }

        private void btnMotorFren_Click(object sender, EventArgs e)
        {
            if (u.Hiz > 0)
            {
                u.Hiz -= 50;
                gostergeGuncelle();
            }
            if (u.Hiz < 300)
            {
                btnYuksel.Enabled = false;
            }
            if (u.Hiz == 0)
            {
                timer1.Stop();
            }
        }

        public void gostergeGuncelle()
        {
            lblUcakBenzin.Text = u.Benzin.ToString();
            lblUcakHiz.Text = u.Hiz.ToString();
            lblUcakYukseklik.Text = u.Yukseklik.ToString();
        }

        private void btnYuksel_Click(object sender, EventArgs e)
        {
            
            if (u.Yukseklik < 2000)
            {
                u.Yukseklik += 100;
                u.HavaSicakligi -= 1;
            }
            else
            {
                u.Yukseklik += 500;
                u.HavaSicakligi -= 5;
            }
            gostergeGuncelle();
        }

        private void btnAlcal_Click(object sender, EventArgs e)
        {
            if(u.Yukseklik>0)
            {
                if (u.Yukseklik < 200)
                {
                    u.Yukseklik -= 25;
                    u.HavaSicakligi += 1;
                }
                else if (u.Yukseklik < 1000)
                {
                    u.Yukseklik -= 50;
                    u.HavaSicakligi += 1;
                }
                else if (u.Yukseklik < 5000)
                {
                    u.Yukseklik -= 100;
                    u.HavaSicakligi += 1;
                }
                else
                { 
                u.Yukseklik-=500;
                }
                gostergeGuncelle();
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            u.AlinanYol += (Convert.ToDecimal(u.Hiz) / 3600.00M);
            txtUcakGidilenMesafe.Text = u.AlinanYol.ToString();
            txtUcakYerelSaat.Text = DateTime.Now.ToLongTimeString();
            
            long saniye = u.UcusSuresi.Ticks-10000000;
            u.UcusSuresi = new DateTime(saniye);
            txtUcakKalanSure.Text = u.UcusSuresi.ToLongTimeString();

            if(u.Benzin<500)
            {
                timer2.Interval = 50;
                if (u.Benzin > 40)
                {
                    u.Benzin -= 20;
                }
                else
                {
                    u.Benzin -= 1;
                    if(u.Benzin==0)
                    { 
                        timer1.Stop();
                        timer2.Stop();
                        u.Motor2Calisiyor = false;
                        u.Motor1Calisiyor = false;    
                        txtUcakBenzin.Text = "Benzin Bitti";
                    }
                }
            }
            else if (u.Benzin > 0)
            {
                u.Benzin -= (u.Hiz + u.Yukseklik) *calisanMotorSayisi* 10 / 1000;
            }
            gostergeGuncelle();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txtUcakBenzin.BackColor == Color.Red)
            {
                txtUcakBenzin.BackColor = Color.PowderBlue;
            }
            else
            {
                txtUcakBenzin.BackColor = Color.Red;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void cmbKalkisYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            u.KalkisYeri = cmbKalkisYeri.SelectedItem.ToString();
        }

        private void cmbVarisYeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            u.VarisYeri = cmbVarisYeri.SelectedItem.ToString();
        }

        private void cmbUcakTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUcakTipi.SelectedItem.ToString()=="Boieng 1")
            {
                //cmbPilotAdi
                cmbPilotAdi.Text = "";
                cmbPilotAdi.Items.Clear();
                cmbPilotAdi.Items.Add("Co-Fatih YILDIZHAN B1");
                cmbPilotAdi.Items.Add("Co-FyDoxa B1");
                cmbPilotAdi.Items.Add("Co-Pilot1 B1");

                //cmbPersonelSayisi
                cmbPersonelSayisi.Text = "";
                cmbPersonelSayisi.Items.Clear();
                cmbPersonelSayisi.Items.Add(5);
                cmbPersonelSayisi.Items.Add(6);
                cmbPersonelSayisi.Items.Add(7);

                //cmbCoPilotAdi
                cmbCoPilotAdi.Text = "";
                cmbCoPilotAdi.Items.Clear();
                cmbCoPilotAdi.Items.Add("Fatih YILDIZHAN B1");
                cmbCoPilotAdi.Items.Add("FyDoxa B1");
                cmbCoPilotAdi.Items.Add("Pilot2 B1");

                //cmbYolcuSayisi
                cmbYolcuSayisi.Text = "";
                cmbYolcuSayisi.Items.Clear();
                cmbYolcuSayisi.Items.Add(75);
                cmbYolcuSayisi.Items.Add(100);
                cmbYolcuSayisi.Items.Add(125);
                cmbYolcuSayisi.Items.Add(150);

            }
            else if (cmbUcakTipi.SelectedItem.ToString() == "Boieng 2")
            {
                //cmbPilotAdi
                cmbPilotAdi.Text = "";
                cmbPilotAdi.Items.Clear();
                cmbPilotAdi.Items.Add("Co-FY Boeing2");
                cmbPilotAdi.Items.Add("Co-FyDoxa Boeing2");
                cmbPilotAdi.Items.Add("Co-Pilot1 Boeing2");

                //cmbPersonelSayisi
                cmbPersonelSayisi.Text = "";
                cmbPersonelSayisi.Items.Clear();
                cmbPersonelSayisi.Items.Add(8);
                cmbPersonelSayisi.Items.Add(9);
                cmbPersonelSayisi.Items.Add(10);

                //cmbCoPilotAdi
                cmbCoPilotAdi.Text = "";
                cmbCoPilotAdi.Items.Clear();
                cmbCoPilotAdi.Items.Add("Fatih YILDIZHAN B2");
                cmbCoPilotAdi.Items.Add("FyDoxa B2");
                cmbCoPilotAdi.Items.Add("Pilot2 B2");

                //cmbYolcuSayisi
                cmbYolcuSayisi.Text = "";
                cmbYolcuSayisi.Items.Clear();
                cmbYolcuSayisi.Items.Add(125);
                cmbYolcuSayisi.Items.Add(150);
                cmbYolcuSayisi.Items.Add(175);
                cmbYolcuSayisi.Items.Add(200);

            }
            else if (cmbUcakTipi.SelectedItem.ToString().Equals("Gösteri Uçağı"))
            {
                //cmbCoPilotAdi
                cmbCoPilotAdi.Items.Clear();
                cmbCoPilotAdi.Text = "";
                cmbCoPilotAdi.Items.Add("Co-Gösteri1");
                cmbCoPilotAdi.Items.Add("Co-Gösteri2");
                cmbCoPilotAdi.Items.Add("Co-Gösteri3");

                //cmbPersonelSayisi
                cmbPersonelSayisi.Text = "";
                cmbPersonelSayisi.Items.Clear();
                cmbPersonelSayisi.Items.Add(1);
                cmbPersonelSayisi.Items.Add(2);
                cmbPersonelSayisi.Items.Add(3);

                //cmbPilotAdi
                cmbPilotAdi.Text = "";
                cmbPilotAdi.Items.Clear();
                cmbPilotAdi.Items.Add("Gösteri1 G1");
                cmbPilotAdi.Items.Add("Gösteri2 G1");
                cmbPilotAdi.Items.Add("Gösteri3 G1");

                //cmbYolcuSayisi
                cmbYolcuSayisi.Text = "";
                cmbYolcuSayisi.Items.Clear();
                cmbYolcuSayisi.Items.Add(2);
                cmbYolcuSayisi.Items.Add(3);
                cmbYolcuSayisi.Items.Add(4);
                cmbYolcuSayisi.Items.Add(5);

            }
            else if (cmbUcakTipi.SelectedItem.ToString() == "Helikopter")
            {
                //cmbCoPilotAdi
                cmbCoPilotAdi.Items.Clear();
                cmbCoPilotAdi.Text = "";
                cmbCoPilotAdi.Items.Add("Co-He1");
                cmbCoPilotAdi.Items.Add("Co-He2");
                cmbCoPilotAdi.Items.Add("Co-He3");

                //cmbPersonelSayisi
                cmbPersonelSayisi.Text = "";
                cmbPersonelSayisi.Items.Clear();
                cmbPersonelSayisi.Items.Add(1);
                cmbPersonelSayisi.Items.Add(2);
                cmbPersonelSayisi.Items.Add(3);

                //cmbPilotAdi
                cmbPilotAdi.Text = "";
                cmbPilotAdi.Items.Clear();
                cmbPilotAdi.Items.Add("H1");
                cmbPilotAdi.Items.Add("H2");
                cmbPilotAdi.Items.Add("H3");

                //cmbYolcuSayisi
                cmbYolcuSayisi.Text = "";
                cmbYolcuSayisi.Items.Clear();
                cmbYolcuSayisi.Items.Add(1);
                cmbYolcuSayisi.Items.Add(2);
                cmbYolcuSayisi.Items.Add(4);
                cmbYolcuSayisi.Items.Add(6);
            }
            else if (cmbUcakTipi.SelectedItem.ToString() == "Özel Uçak")
            {
                //cmbCoPilotAdi
                cmbCoPilotAdi.Items.Clear();
                cmbCoPilotAdi.Text = "";
                cmbCoPilotAdi.Items.Add("Co-Özel1");
                cmbCoPilotAdi.Items.Add("Co-Özel2");
                cmbCoPilotAdi.Items.Add("Co-Özel3");

                //cmbPersonelSayisi
                cmbPersonelSayisi.Text = "";
                cmbPersonelSayisi.Items.Clear();
                cmbPersonelSayisi.Items.Add(2);
                cmbPersonelSayisi.Items.Add(4);
                cmbPersonelSayisi.Items.Add(5);

                //cmbPilotAdi
                cmbPilotAdi.Text = "";
                cmbPilotAdi.Items.Clear();
                cmbPilotAdi.Items.Add("Özel 1");
                cmbPilotAdi.Items.Add("Özel 2");
                cmbPilotAdi.Items.Add("Özel 3");

                //cmbYolcuSayisi
                cmbYolcuSayisi.Text = "";
                cmbYolcuSayisi.Items.Clear();
                cmbYolcuSayisi.Items.Add(2);
                cmbYolcuSayisi.Items.Add(4);
                cmbYolcuSayisi.Items.Add(8);
                cmbYolcuSayisi.Items.Add(10);
            }
        }
    }
}
