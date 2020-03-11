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
    public partial class unlu_uyumu : Form
    {
        public unlu_uyumu()
        {
            InitializeComponent();
        }
        //Dizi Tanımları
        char[] inceSesli = new char[] { 'e', 'i', 'ü', 'ö'};
        char[] kalinSesli = new char[] { 'a', 'ı', 'u', 'o'};
        char[] sesliHarfler = new char[] { 'e', 'i', 'ü', 'ö', 'a', 'ı', 'u', 'o' };
        // Method Tanımları
        //sesKontrol Metodu textbox a girilen kelimedeki sesli harfleri alır , Boşluk varsa Uyarı verir
        //panel metodu aldığı değere göre panelin rengini değiştirir
        char[] sesKontrol(string yazi, char[] harfDizisi)
        {
            int sayac=0;
            char[] harfTipi = new char[0];
           
                for (int i = 0; i < yazi.Length; i++)
                {
                    if (yazi[i].ToString() == " ")
                    {
                        MessageBox.Show("Lütfen Boşluk Bırakmayınız");
                        break;
                    }
                    else
                    {
                        for (int j = 0; j < harfDizisi.Length; j++)
                        {
                            if (harfDizisi[j] == yazi[i])
                            {
                                Array.Resize(ref harfTipi, sayac + 1);
                                harfTipi[sayac] = harfDizisi[j];
                                sayac++;
                            }
                            else { }
                        }  
                    }
                }  
            return harfTipi;
        }
        void panel(bool kontrol)
        {
            pnlDurum.Visible = true;
            if (kontrol == true)
            {
                pnlDurum.BackColor = Color.Lime;
            }
            else
            {
                pnlDurum.BackColor = Color.Red;
            }
        }
        //kontrol et butonu
        //Programın beyni beyni :D
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            btnKontrol.Enabled = false;
            if (textBox1.Text != "")
            {
                char[] harfler = sesKontrol(textBox1.Text.ToLower(), sesliHarfler);
                bool sesKalinMi = true;
                bool sesVarMi = true;
                int sayacHarf = harfler.Length;
                for (int i = 0; i < 3; i++)  // ilk harfin ince sesli mi kalin sesli mi olduğu belirlenir
                {
                    if (sayacHarf == 0)
                    {
                        MessageBox.Show("insan ol sesli harf gir");
                        sesVarMi = false;
                        break;
                    }
                    else if (harfler[0] == inceSesli[i])
                    {
                        sesKalinMi = false;
                        break;
                    }
                    else { }
                }
                if (sesKalinMi == true && sesVarMi == true) // ilk sesli harf kalın ise bu koşul çalışır
                {
                    bool digerSslrKlnMi = true;
                    for (int i = 0; i < harfler.Length; i++)
                    {
                        int sesKontrol1 = Array.IndexOf(kalinSesli, harfler[i]); //Diğer sesli harfler kalın mı ?
                        if (sesKontrol1 == -1)
                        {
                            digerSslrKlnMi = false;
                        }
                    }
                    if (digerSslrKlnMi == true)
                    {
                        panel(true);
                        lblMesaj.Text = "B.Ü.U 'na uygundur.";
                    }
                    else
                    {
                        panel(false);
                        lblMesaj.Text = "B.Ü.U'na uygun değildir.";
                    }
                }
                else if (sesKalinMi == false && sesVarMi == true) // ilk sesli harf ince ise bu koşul çalışır
                {
                    bool dgrSslrIncMi = true;
                    for (int i = 0; i < harfler.Length; i++)
                    {
                        int sesKontrol2 = Array.IndexOf(inceSesli, harfler[i]); //Diğer sesli harfler ince mi ?
                        if (sesKontrol2 == -1)
                        {
                            dgrSslrIncMi = false;
                        }
                    }
                    if (dgrSslrIncMi == true)
                    {
                        panel(true);
                        lblMesaj.Text = "B.Ü.U 'na uygundur.";
                    }
                    else
                    {
                        panel(false);
                        lblMesaj.Text = "B.Ü.U'na uygun değildir.";
                    }
                }
                else
                { }
            }
            else // Eğer hiçbirşey yazılmazsa bu koşul çalışır.
            {
                MessageBox.Show("Lütfen bir kelime giriniz!");
            }
        }
        //texbox ın yazısının değişmesi halinde Kontrol Et butonu aktif olur
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnKontrol.Enabled = true;
        }
        //textbox a tıklanması halinde texbox temizlenir
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }
     }
}
