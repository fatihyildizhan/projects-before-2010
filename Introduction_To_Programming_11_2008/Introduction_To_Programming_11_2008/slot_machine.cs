using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Introduction_To_Programming_11_2008
{
    public partial class slot_machine : Form
    {
        public slot_machine()
        {
            InitializeComponent();
        }
        // kasadaki para , jeton , kazanılan para , daha önce para verilmiş mi kontrolü , timerlar için sayaç 
        // kazanma oranları için int tanımları
        int kasadakiJeton = 6;
        int oyuncudakiJeton = 20;
        int kazanilanPara = 20;
        bool odul = false;
        Random r = new Random();
        int sayacTimers = 0;
        int sayacTimer2 = 0;
        int oran1;
        int oran2;
        //Oyna Butonu
        private void btnOyna_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            btnOyna.Enabled = false; // buton oynanan el bitene kadar kullanılamaz hale getirilir
            if (oyuncudakiJeton <= 0) // Eğer Jeton Bitmiş İşe Uyarı verilir
            {
                btnOyna.Enabled = false;
                MessageBox.Show("Jetonunuz bitmiştir!"); 
            }
            else // Yeterli Jeton varsa oyun başlar ekrana ilk değerler yazılır
            {
                kasadakiJeton++;
                oyuncudakiJeton--;
                lblKasaJeton.Text = kasadakiJeton.ToString();
                lblJetonOyuncu.Text = oyuncudakiJeton.ToString();
                lblPara.Text = kazanilanPara.ToString() + " YTL";
                if (kasadakiJeton<10) // eğer kasadaki jeton 10 dan az ise bu koşul timer 1 i tetikler
                {
                    sayacTimers = 25;
                    timer1.Interval =80;
                    timer1.Start();
                    lblOran.Text = "%0";   
                }
                else // eğer kasadaki jeton 10 veya fazla ise
                {
                    if (odul == false) // daha önce ödül verilmediyse bu koşul timer 2 yi tetikler
                    {
                        sayacTimer2 = 30;
                        timer2.Interval = 80;
                        timer2.Start();
                        lblOran.Text = "%20";
                        oran1 = r.Next(0, 5);
                    }
                    else // daha önce ödül verildiyse bu koşul timer 3 ü tetikler
                    {
                        sayacTimers = 35;
                        timer3.Interval = 80;
                        timer3.Start();
                        lblOran.Text = "%5";
                        oran2 = r.Next(0, 20);
                    }
                }
                if (oyuncudakiJeton <= 0) // jeton kontrolü
                {
                    btnOyna.Enabled = false;
                    MessageBox.Show("Jetonunuz bitmiştir!");
                }
            }
        }
        // timer 1
        // timer 1 kasadaki jeton sayısı 10 dan az olduğunda çalışacağı için
        // hiçbir zaman resimler aynı gelmeyecek ve  oyuncu kaybedecektir
        private void timer1_Tick(object sender, EventArgs e) 
        {
            int rsmNo1 = r.Next(0, ımageList1.Images.Count);
            int rsmNo2 = r.Next(0, ımageList1.Images.Count);
            int rsmNo3 = r.Next(0, ımageList1.Images.Count);
            int rsmNo4 = r.Next(0, ımageList1.Images.Count);
            pictureBox1.Image = ımageList1.Images[rsmNo1];
            pictureBox2.Image = ımageList1.Images[rsmNo2];
            pictureBox3.Image = ımageList1.Images[rsmNo3];
            pictureBox4.Image = ımageList1.Images[rsmNo4];
            if (sayacTimers == 0)
            {
                timer1.Stop();
                pictureBox1.Image = ımageList1.Images[0];
                pictureBox2.Image = ımageList1.Images[1];
                pictureBox3.Image = ımageList1.Images[2];
                pictureBox4.Image = ımageList1.Images[3];
                lblSonuc.Text = "Kaybettiniz!";
                btnOyna.Enabled = true; 
            }
            // sayac 0 olduğunca timer ın durması için gereken koşul ve
            // resimlerin yavaşlayarak durması için intervalin azaltılması
            else  
            {
                sayacTimers--;
                timer1.Interval+=15;
            }
        }
        // timer 2
        // timer 2 kasadaki jeton 10 ve fazla ise VE daha önce ödül verilmediyse çalışır
        private void timer2_Tick(object sender, EventArgs e)
        {
            int rsmNo1 = r.Next(0, ımageList1.Images.Count);
            int rsmNo2 = r.Next(0, ımageList1.Images.Count);
            int rsmNo3 = r.Next(0, ımageList1.Images.Count);
            int rsmNo4 = r.Next(0, ımageList1.Images.Count);
            pictureBox1.Image = ımageList1.Images[rsmNo1];
            pictureBox2.Image = ımageList1.Images[rsmNo2];
            pictureBox3.Image = ımageList1.Images[rsmNo3];
            pictureBox4.Image = ımageList1.Images[rsmNo4];
            if (sayacTimer2 == 0)
            {
                if (oran1 == 0) // butona her tıklandığında yeni ve rastgele üretilen sayı 0 ise oyuncu kazanır -- oran %20 dir 
                {
                    timer2.Stop();
                    pictureBox1.Image = ımageList1.Images[3];
                    pictureBox2.Image = ımageList1.Images[3];
                    pictureBox3.Image = ımageList1.Images[3];
                    pictureBox4.Image = ımageList1.Images[3];
                    lblSonuc.Text = "Tebrikler Kazandınız!";
                    lblOran.Text = "%5";
                    kazanilanPara += 5;
                    lblPara.Text = kazanilanPara.ToString() + " YTL"; // kazanılan paraya 5 YTL ekler
                    odul = true; // ödül verildiği için bool u true yapar bu da oranı %5 e düşürür
                    btnOyna.Enabled = true; // buton aktif hale getirilir ki vatandaş oynasın :D
                }
                else // eğer üretilen sayı 0 değil ise oyuncu kaybeder :(
                {
                    timer2.Stop();
                    pictureBox1.Image = ımageList1.Images[0];
                    pictureBox2.Image = ımageList1.Images[0];
                    pictureBox3.Image = ımageList1.Images[0];
                    pictureBox4.Image = ımageList1.Images[3];
                    lblSonuc.Text = "Kaybettiniz!";
                    btnOyna.Enabled = true;
                }
            }
            // sayac 0 olduğunca timer ın durması için gereken koşul ve
            // resimlerin yavaşlayarak durması için intervalin azaltılması
            else
            {
                sayacTimer2--;
                timer2.Interval += 15;
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            int rsmNo1 = r.Next(0, ımageList1.Images.Count);
            int rsmNo2 = r.Next(0, ımageList1.Images.Count);
            int rsmNo3 = r.Next(0, ımageList1.Images.Count);
            int rsmNo4 = r.Next(0, ımageList1.Images.Count);
            pictureBox1.Image = ımageList1.Images[rsmNo1];
            pictureBox2.Image = ımageList1.Images[rsmNo2];
            pictureBox3.Image = ımageList1.Images[rsmNo3];
            pictureBox4.Image = ımageList1.Images[rsmNo4];
            if (sayacTimers == 0)
            {
                timer3.Stop();
                if (oran2 == 18)
                {
                    pictureBox1.Image = ımageList1.Images[1];
                    pictureBox2.Image = ımageList1.Images[1];
                    pictureBox3.Image = ımageList1.Images[1];
                    pictureBox4.Image = ımageList1.Images[1];
                    lblSonuc.Text = "Tebrikler Kazandınız!";
                    kazanilanPara += 5;
                    lblPara.Text = kazanilanPara.ToString()+" YTL";
                    odul = true;
                    btnOyna.Enabled = true;
                }
                else
                {
                    timer3.Stop();
                    pictureBox1.Image = ımageList1.Images[2];
                    pictureBox2.Image = ımageList1.Images[1];
                    pictureBox3.Image = ımageList1.Images[2];
                    pictureBox4.Image = ımageList1.Images[1];
                    lblSonuc.Text = "Kaybettiniz!";
                    btnOyna.Enabled = true;
                }
            }
            else
            {
                sayacTimers--;
                timer3.Interval += 15;
            }
        }
        // Jeton Al Butonu
        // Eğer oyuncu para kazandıysa bu parayı jetona çevirip 
        // oynamaya devam edebilir...
        private void btnJetonAl_Click(object sender, EventArgs e)
        {
            if (kazanilanPara >= numericUpDown1.Value*5) // eğer kazanılan para yeterli ise işlem gerçekleşir
            {
                oyuncudakiJeton += Convert.ToInt32(numericUpDown1.Value);
                lblJetonOyuncu.Text = oyuncudakiJeton.ToString();
                kazanilanPara -= (Convert.ToInt32(numericUpDown1.Value)) * 5;
                lblPara.Text = kazanilanPara.ToString(); // kalan para ekranda gösterilir
                lblSonuc.Text = numericUpDown1.Value.ToString()+" Tane Jeton Aldınız!"; // işlem bilgisi ekranda gösterilir
            }
            else // oyuncunun parası yetersiz ise uyarı verilir
            {
                lblSonuc.Text = "Paranız Yetersiz !";
            }
        }
    }
}
