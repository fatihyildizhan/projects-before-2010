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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Dizi Tanımları
        string[] kartTur = new string[] { "Maça", "Karo", "Sinek", "Kupa" };
        string[] kartNo = new string[] { "As", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Vale", "Kız", "Papaz" };
        string[] kartlar = new string[52];
        int[] sayi20=new int[20];
        
        //Sayı Üretme
        Random r = new Random();
        
        //Diğer Tanımlamalar
        string oyuncu1Kartlar;
        string oyuncu2Kartlar;
        string oyuncu3Kartlar;
        string oyuncu4Kartlar;
        string kntrlOync1 = "";
        string kntrlOync2 = "";
        string kntrlOync3 = "";
        string kntrlOync4 = "";
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            oyuncu1Kartlar = "";
            listBox2.Items.Clear();
            oyuncu2Kartlar = "";
            listBox3.Items.Clear();
            oyuncu3Kartlar = "";
            listBox4.Items.Clear();
            oyuncu4Kartlar = "";
            
            for (int i = 0; i < 20; )
            {
                int uretilen = r.Next(0, kartlar.Length);

                if (Array.IndexOf(sayi20, uretilen) == -1)
                {
                    sayi20[i] = uretilen;
                    i++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                listBox1.Items.Add(kartlar[sayi20[i]]);
                oyuncu1Kartlar += kartlar[sayi20[i]] + "-";
                listBox2.Items.Add(kartlar[sayi20[i + 5]]);
                oyuncu2Kartlar += kartlar[sayi20[i + 5]] + "-";
                listBox3.Items.Add(kartlar[sayi20[i + 10]]);
                oyuncu3Kartlar += kartlar[sayi20[i + 10]] + "-";
                listBox4.Items.Add(kartlar[sayi20[i + 15]]);
                oyuncu4Kartlar += kartlar[sayi20[i + 15]] + "-";
            }
            
            string[] oync1dizi = oyuncu1Kartlar.Split('-');
            string[] oync2dizi = oyuncu2Kartlar.Split('-');
            string[] oync3dizi = oyuncu3Kartlar.Split('-');
            string[] oync4dizi = oyuncu4Kartlar.Split('-');
            for (int i = 1; i + 8 < 10; i += 2)
            {
                if (oync1dizi[i] == oync1dizi[i + 2] && oync1dizi[i] == oync1dizi[i + 4] && oync1dizi[i] == oync1dizi[i + 6] || oync1dizi[i] == oync1dizi[i + 2] && oync1dizi[i] == oync1dizi[i + 4] && oync1dizi[i] == oync1dizi[i + 8] || oync1dizi[i + 2] == oync1dizi[i + 4] && oync1dizi[i + 2] == oync1dizi[i + 6] && oync1dizi[i + 2] == oync1dizi[i + 8])
                {
                    kntrlOync1 = "4'lü Var";
                }
                else if (oync1dizi[i] == oync1dizi[i + 2] && oync1dizi[i] == oync1dizi[i + 4] || oync1dizi[i] == oync1dizi[i + 2] && oync1dizi[i] == oync1dizi[i + 6] || oync1dizi[i] == oync1dizi[i + 2] && oync1dizi[i] == oync1dizi[i + 8] || oync1dizi[i + 2] == oync1dizi[i + 4] && oync1dizi[i + 2] == oync1dizi[i + 6] || oync1dizi[i + 2] == oync1dizi[i + 4] && oync1dizi[i + 2] == oync1dizi[i + 8] || oync1dizi[i + 4] == oync1dizi[i + 6] && oync1dizi[i + 4] == oync1dizi[i + 8])
                {
                    kntrlOync1 = "3'lü Var";
                }
                else if (oync1dizi[i] == oync1dizi[i + 2] || oync1dizi[i] == oync1dizi[i + 4] || oync1dizi[i] == oync1dizi[i + 6] || oync1dizi[i] == oync1dizi[i + 8] || oync1dizi[i + 2] == oync1dizi[i + 4] || oync1dizi[i + 2] == oync1dizi[i + 6] || oync1dizi[i + 2] == oync1dizi[i + 8] || oync1dizi[i + 4] == oync1dizi[i + 6] || oync1dizi[i + 4] == oync1dizi[i + 8] || oync1dizi[i + 6] == oync1dizi[i + 8])
                {
                    kntrlOync1 = "2'li Var";
                }
                else
                {
                    kntrlOync1 = "Bişey Yok!";
                }
            }
            for (int j = 1; j + 8 < 10; j += 2)
            {
                if (oync2dizi[j] == oync2dizi[j + 2] && oync2dizi[j] == oync2dizi[j + 4] && oync2dizi[j] == oync2dizi[j + 6] || oync2dizi[j] == oync2dizi[j + 2] && oync2dizi[j] == oync2dizi[j + 4] && oync2dizi[j] == oync2dizi[j + 8] || oync2dizi[j + 2] == oync2dizi[j + 4] && oync2dizi[j + 2] == oync2dizi[j + 6] && oync2dizi[j + 2] == oync2dizi[j + 8])
                {
                    kntrlOync2 = "4'lü Var";
                }
                else if (oync2dizi[j] == oync2dizi[j + 2] && oync2dizi[j] == oync2dizi[j + 4] || oync2dizi[j] == oync2dizi[j + 2] && oync2dizi[j] == oync2dizi[j + 6] || oync2dizi[j] == oync2dizi[j + 2] && oync2dizi[j] == oync2dizi[j + 8] || oync2dizi[j + 2] == oync2dizi[j + 4] && oync2dizi[j + 2] == oync2dizi[j + 6] || oync2dizi[j + 2] == oync2dizi[j + 4] && oync2dizi[j + 2] == oync2dizi[j + 8] || oync2dizi[j + 4] == oync2dizi[j + 6] && oync2dizi[j + 4] == oync2dizi[j + 8])
                {
                    kntrlOync2 = "3'lü Var";
                }
                else if (oync2dizi[j] == oync2dizi[j + 2] || oync2dizi[j] == oync2dizi[j + 4] || oync2dizi[j] == oync2dizi[j + 6] || oync2dizi[j] == oync2dizi[j + 8] || oync2dizi[j + 2] == oync2dizi[j + 4] || oync2dizi[j + 2] == oync2dizi[j + 6] || oync2dizi[j + 2] == oync2dizi[j + 8] || oync2dizi[j + 4] == oync2dizi[j + 6] || oync2dizi[j + 4] == oync2dizi[j + 8] || oync2dizi[j + 6] == oync2dizi[j + 8])
                {
                    kntrlOync2 = "2'li Var";
                }
                else
                {
                    kntrlOync2 = "Bişey Yok!";
                }
            }
            for (int j = 1; j + 8 < 10; j += 2)
            {
                if (oync3dizi[j] == oync3dizi[j + 2] && oync3dizi[j] == oync3dizi[j + 4] && oync3dizi[j] == oync3dizi[j + 6] || oync3dizi[j] == oync3dizi[j + 2] && oync3dizi[j] == oync3dizi[j + 4] && oync3dizi[j] == oync3dizi[j + 8] || oync3dizi[j + 2] == oync3dizi[j + 4] && oync3dizi[j + 2] == oync3dizi[j + 6] && oync3dizi[j + 2] == oync3dizi[j + 8])
                {
                    kntrlOync3 = "4'lü Var";
                }
                else if (oync3dizi[j] == oync3dizi[j + 2] && oync3dizi[j] == oync3dizi[j + 4] || oync3dizi[j] == oync3dizi[j + 2] && oync3dizi[j] == oync3dizi[j + 6] || oync3dizi[j] == oync3dizi[j + 2] && oync3dizi[j] == oync3dizi[j + 8] || oync3dizi[j + 2] == oync3dizi[j + 4] && oync3dizi[j + 2] == oync3dizi[j + 6] || oync3dizi[j + 2] == oync3dizi[j + 4] && oync3dizi[j + 2] == oync3dizi[j + 8] || oync3dizi[j + 4] == oync3dizi[j + 6] && oync3dizi[j + 4] == oync3dizi[j + 8])
                {
                    kntrlOync3 = "3'lü Var";
                }
                else if (oync3dizi[j] == oync3dizi[j + 2] || oync3dizi[j] == oync3dizi[j + 4] || oync3dizi[j] == oync3dizi[j + 6] || oync3dizi[j] == oync3dizi[j + 8] || oync3dizi[j + 2] == oync3dizi[j + 4] || oync3dizi[j + 2] == oync3dizi[j + 6] || oync3dizi[j + 2] == oync3dizi[j + 8] || oync3dizi[j + 4] == oync3dizi[j + 6] || oync3dizi[j + 4] == oync3dizi[j + 8] || oync3dizi[j + 6] == oync3dizi[j + 8])
                {
                    kntrlOync3 = "2'li Var";
                }
                else
                {
                    kntrlOync3 = "Bişey Yok!";
                }
            }
            for (int j = 1; j + 8 < 10; j += 2)
            {
                if (oync4dizi[j] == oync4dizi[j + 2] && oync4dizi[j] == oync4dizi[j + 4] && oync4dizi[j] == oync4dizi[j + 6] || oync4dizi[j] == oync4dizi[j + 2] && oync4dizi[j] == oync4dizi[j + 4] && oync4dizi[j] == oync4dizi[j + 8] || oync4dizi[j + 2] == oync4dizi[j + 4] && oync4dizi[j + 2] == oync4dizi[j + 6] && oync4dizi[j + 2] == oync4dizi[j + 8])
                {
                    kntrlOync4 = "4'lü Var";
                }
                else if (oync4dizi[j] == oync4dizi[j + 2] && oync4dizi[j] == oync4dizi[j + 4] || oync4dizi[j] == oync4dizi[j + 2] && oync4dizi[j] == oync4dizi[j + 6] || oync4dizi[j] == oync4dizi[j + 2] && oync4dizi[j] == oync4dizi[j + 8] || oync4dizi[j + 2] == oync4dizi[j + 4] && oync4dizi[j + 2] == oync4dizi[j + 6] || oync4dizi[j + 2] == oync4dizi[j + 4] && oync4dizi[j + 2] == oync4dizi[j + 8] || oync4dizi[j + 4] == oync4dizi[j + 6] && oync4dizi[j + 4] == oync4dizi[j + 8])
                {
                    kntrlOync4 = "3'lü Var";
                }
                else if (oync4dizi[j] == oync4dizi[j + 2] || oync4dizi[j] == oync4dizi[j + 4] || oync4dizi[j] == oync4dizi[j + 6] || oync4dizi[j] == oync4dizi[j + 8] || oync4dizi[j + 2] == oync4dizi[j + 4] || oync4dizi[j + 2] == oync4dizi[j + 6] || oync4dizi[j + 2] == oync4dizi[j + 8] || oync4dizi[j + 4] == oync4dizi[j + 6] || oync4dizi[j + 4] == oync4dizi[j + 8] || oync4dizi[j + 6] == oync4dizi[j + 8])
                {
                    kntrlOync4 = "2'li Var";
                }
                else
                {
                    kntrlOync4 = "Bişey Yok!";
                }
            }
        }
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
        private void listBox1_MouseHover(object sender, EventArgs e)
        {
            
            label5.Text = kntrlOync1;
        }
        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            label5.Text="Poker2008";
        }
        private void listBox2_MouseHover(object sender, EventArgs e)
        {
            label7.Text = kntrlOync2;
        }
        private void listBox2_MouseLeave(object sender, EventArgs e)
        {
            label7.Text = "Poker2008";
        }
        private void listBox3_MouseHover(object sender, EventArgs e)
        {
            label6.Text = kntrlOync3;
        }
        private void listBox3_MouseLeave(object sender, EventArgs e)
        {
            label6.Text = "Poker2008";
        }
        private void listBox4_MouseHover(object sender, EventArgs e)
        {
            label8.Text = kntrlOync4;
        }
        private void listBox4_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = "Poker2008";
        }
            }
}
