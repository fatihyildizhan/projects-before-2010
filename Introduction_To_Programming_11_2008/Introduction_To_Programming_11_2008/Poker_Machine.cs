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
    public partial class Poker_Machine : Form
    {
        public Poker_Machine()
        {
            InitializeComponent();
        }
        //Metod Tanımları
        string KartSorgusu(string[] ara, string[] kartlar)
        {
            int limit = 0;
            string str;
            for (int i = 0; i < kartlar.Length; i++)
            {
                int sayac = 0;
                // oyuncunun elinde en fazla kaç tane kartın aynı olduğu bulunur
                for (int j = 0; j < ara.Length; j++)
                {
                    if (kartlar[i] == ara[j])
                    {
                        sayac++;
                    }
                }
                if (sayac > limit)
                {
                    limit = sayac;
                }
            }
            // kullanıcının elindeki aynı kart sayısına göre koşullar çalışır..
            if (limit == 5)
            {
                str="Elinizde bir beşli var";
            }
            else if (limit == 4)
            {
                str = "Elinizde bir dörtlü var";
            }
            else if (limit == 3)
            {
                str = "Elinizde üçlü var"; 
            }
            else if (limit == 2)
            {
                str = "Elinizde ikili var"; 
            }
            else
            {
                str = "Elinizde bişey yok";
            }
            return str; // çalışan koşula göre geriye str nin değeri döndürülür...
        }
        //Dizi Tanımları
        string[] kartTur = new string[] { "Maça", "Karo", "Sinek", "Kupa" };
        string[] kartNo  = new string[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        string[] kartlar = new string[52]; // tüm kartların tutulacağı dizi
        int[]    sayi20  = new int[0]; // oyunculara rastgele ve farklı kart dağıtılmada kullanılan dizi
        //her bir oyuncuya dağılan kartlar için kullanılan diziler
        string[] oync1dizi = new string[11];
        string[] oync2dizi = new string[11];
        string[] oync3dizi = new string[11];
        string[] oync4dizi = new string[11];
        //Sayı Üretme
        Random r = new Random();  
        //her bir oyuncuya gelen kartların birleşik hali
        string oyuncu1Kartlar;
        string oyuncu2Kartlar;
        string oyuncu3Kartlar;
        string oyuncu4Kartlar;   
        // Dağıt Butonu
        private void btnDagit_Click(object sender, EventArgs e)
        {
            // her oyun öncesi Biras temislik Şart !
            lstBoxOync1.Items.Clear();
            oyuncu1Kartlar = "";
            lstBoxOync2.Items.Clear();
            oyuncu2Kartlar = "";
            lstBoxOync3.Items.Clear();
            oyuncu3Kartlar = "";
            lstBoxOync4.Items.Clear();
            oyuncu4Kartlar = "";
            //Oyunculara rastgele ve farklı kartlar dağıtmak için 20 sayı üretme
            for (int i = 0; i < 20; ) 
            {
                int randomNumbers = r.Next(0, kartlar.Length);
                Array.Resize(ref sayi20, i + 1);
                if (Array.IndexOf(sayi20, randomNumbers) == -1)
                {
                    sayi20[i] = randomNumbers;
                    i++;
                }
            }
            // oyunculara kartlarını dağıtma zamanı
            // üretilen 20 sayı 5  erli olarak kartlar dizisinden rastgele alınarak herbir oyuncuya dağıtılır
            // aynı zamanda daha sonra kullanılmak üzere oyuncuKartlar Dizilerine birleştirilerek atılır
            for (int i = 0; i < 5; i++)
            {
                lstBoxOync1.Items.Add(kartlar[sayi20[i]]);                
                lstBoxOync2.Items.Add(kartlar[sayi20[i + 5]]);                
                lstBoxOync3.Items.Add(kartlar[sayi20[i + 10]]);
                lstBoxOync4.Items.Add(kartlar[sayi20[i + 15]]);
               
                    oyuncu1Kartlar += kartlar[sayi20[i]] + "-";
                    oyuncu2Kartlar += kartlar[sayi20[i + 5]] + "-";
                    oyuncu3Kartlar += kartlar[sayi20[i + 10]] + "-";
                    oyuncu4Kartlar += kartlar[sayi20[i + 15]] + "-";
            }
                // her bir oyuncunun elinde neler olduğunu oyuncuya göstermek için kart bilgileri ayrılarak dizilerde tutulur...
                oync1dizi = oyuncu1Kartlar.Split('-');
                oync2dizi = oyuncu2Kartlar.Split('-');
                oync4dizi = oyuncu3Kartlar.Split('-');
                oync3dizi = oyuncu4Kartlar.Split('-');

        }
        // Formun load esnasında kartlar oluşturulur..
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kartTur.Length; i++)
            {
                for (int x = 0; x < kartNo.Length; x++)
                {
                    kartlar[i * 13 + x] = kartTur[i] + "-" + kartNo[x];
                }
            }
        }
        // Listbox ların MouseHover özelliği sayesinde kullanıcıya elinde kartların bilgisi KartSorgusu metodu ile gösterilir
        // Mouse leave olduğunda oyuncuların altında poker 2008 yazdırılır...
        private void lstBoxOync1_MouseHover(object sender, EventArgs e)
        {
            label5.Text = KartSorgusu(oync1dizi, kartNo);
        }
        private void lstBoxOync1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text="Poker2008";
        }
        private void lstBoxOync2_MouseHover(object sender, EventArgs e)
        {
            label7.Text = KartSorgusu(oync2dizi, kartNo);
        }
        private void lstBoxOync2_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "Poker2008";
        }
        private void lstBoxOync3_MouseHover(object sender, EventArgs e)
        {
            label6.Text = KartSorgusu(oync3dizi, kartNo);
        }
        private void lstBoxOync3_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "Poker2008";
        }
        private void lstBoxOync4_MouseHover(object sender, EventArgs e)
        {
            label8.Text = KartSorgusu(oync4dizi, kartNo);
        }
        private void lstBoxOync4_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "Poker2008";
        }
            }
}
