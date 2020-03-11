using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaPcKapatici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // sayac girilen dakikayı saniyeye çevirmek için kullanılmıştır
        //gerisayım ve sayac2 ekranda kalan dakikayı göstermek için kullanılmıştır
        int sayac = 0;
        decimal geriSayim = 0;
        int sayac2 = 0;
        //timer 1
        // labelların ekrandaki görüntüleri kaldırılmıştır
        // girilen dadika kadar süre geçmiş ise pc kapatma işlemi başlar aksi halde ekrana kalan zaman yazılır
        //kapat butonu
        //local zaman ve kullanıcının belirlediği zamanlar saklanır
        // eğer kullanıcı dakika girmiş ise birinci koşul eğer saati datetimepicker dan vermiş ise ikinci koşul aksi halde else çalışır
        //koşullarda butonların enable özellikleri ve labellerin visible özellikleri bunun yanında timerlar çalıştırılmıştır
        private void btnKapat_Click(object sender, EventArgs e)
        {

            string now = DateTime.Now.ToShortTimeString();
            string userTime = dateTimePicker1.Value.ToShortTimeString();

            if (nu_dakika.Value != 0)
            {
                lblDurum.Text = "Kapatma İşlemi Başlamıştır !";
                lblDkSnrKpn.Visible = true;
                btnKapat.Enabled = false;
                btnIptal.Enabled = true;
                decimal dakika = nu_dakika.Value * 60; //kullanıcının girmiş olduğu dadika saniyeye çevrilmiştir.
                geriSayim = nu_dakika.Value;
                sayac = Convert.ToInt32(dakika);
                timer1.Start();
            }
            else if (now != userTime && nu_dakika.Value == 0)
            {
                lblDurum.Text = "Kapatma İşlemi Başlamıştır !";
                lblKapanmaSaati.Visible = true;
                btnKapat.Enabled = false;
                btnIptal.Enabled = true;
                timer2.Start();
            }
            else
            {
                MessageBox.Show("Kapanma Saatini Belirleyiniz!");
                lblDkSnrKpn.Visible = false;
                lblDurum.Text = "Kapanma Saatini Belirleyiniz !";
                lblKapanmaSaati.Visible = false;
                btnKapat.Enabled = true;
                btnIptal.Enabled = false;
            }
        }
        // iptal butonu
        // girilen dadika sıfırlanır aksi halde iki sayaçta aktif hale gelecektir
        // labelların ekrandaki görüntüleri düzeltilir ve butonların enable olma durumları değiştirilir
        // uyarı verilir ve timerlar durdurulur
        private void btnIptal_Click(object sender, EventArgs e)
        {
            nu_dakika.Value = 0;
            lblDkSnrKpn.Visible = false;
            lblDurum.Text = "Kapanma Saatini Belirleyiniz !";
            lblKapanmaSaati.Visible = false;
            btnKapat.Enabled = true;
            btnIptal.Enabled = false;
            System.Diagnostics.Process.Start("shutdown", "-a");
            MessageBox.Show("Kapatma işlemi iptal edilmiştir!");
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDkSnrKpn.Visible = true;
            lblKapanmaSaati.Visible = false;
            sayac--;
            sayac2++;
            if (sayac == 0)
            {
                timer1.Stop();
                System.Diagnostics.Process.Start("shutdown", "-s -t 50");
            }
            else
            {
                lblDkSnrKpn.Text = "Bilgisayarınız " + geriSayim + " dakika sonra kapanacaktır!";
                if (sayac2 == 60)
                {
                    geriSayim--;
                    lblDkSnrKpn.Text = "Bilgisayarınız " + geriSayim + " dakika sonra kapanacaktır!";
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblKapanmaSaati.Visible = true;
            lblDkSnrKpn.Visible = false;
            string now = DateTime.Now.ToLongTimeString();
            string userTime = dateTimePicker1.Value.ToLongTimeString();
            if (now == userTime)
            {
                System.Diagnostics.Process.Start("shutdown", "-s -t 50");
                timer2.Stop();
            }
            else
            {
                lblKapanmaSaati.Text = "Bilgisayarınız saat " + userTime + " olunca kapanacaktır!";
            }
        }
        // Programın loading olması
        //labelların visible butonların enable olma durumları ayarlanmıştır.
        private void Form1_Load(object sender, EventArgs e)
        {
            lblDkSnrKpn.Visible = false;
            lblDurum.Text = "Kapanma Saatini Belirleyiniz !";
            lblKapanmaSaati.Visible = false;
            btnIptal.Enabled = false;
        }
    }
    //Fatih Yıldızhan && DoXa && 09'
    //fatih@yildizhanlar.com
    //www.fatihyildizhan.com
}
