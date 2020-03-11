using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaDelegeEventUcakSimulasyonu
{
    class Ucak
    {
        public delegate void HizOlcer(int hiz);
        public event HizOlcer hizlandi;
        public event HizOlcer yavasladi;

        public delegate void YukseklikOlcer(int yukseklik);
        public event YukseklikOlcer alcaldi;
        public event YukseklikOlcer inisYapti;
        public event YukseklikOlcer havalandi;
        public event YukseklikOlcer yukseldi;

        public delegate void BenzinOlcer(int benzinMiktari);
        public event BenzinOlcer benzinAzaldi;
        public event BenzinOlcer benzinNormal;
        public event BenzinOlcer benzinBitti;

        public delegate void HavaDurumuDegisimi(string havaDurumu);
        public event HavaDurumuDegisimi yagmurYagiyor;
        public event HavaDurumuDegisimi karYagiyor;
        public event HavaDurumuDegisimi ruzgarEsiyor;
        public event HavaDurumuDegisimi gunesAciyor;

        public delegate void HavaSicakligiDegisimi(int havaSicakligi);
        public event HavaSicakligiDegisimi sicaklikArtti;
        public event HavaSicakligiDegisimi sicaklikDustu;
        public event HavaSicakligiDegisimi sicaklikNormal;

        public delegate void MotorDurumu(int motorNo);
        public event MotorDurumu motorCalisti;
        public event MotorDurumu motorDurdu;

        //public delegate void AlinanYolMesafesi(int alinanYol);
        //public event AlinanYolMesafesi iniseGeciyoruz;
        

        #region fields
        bool motor1Calisiyor;
        bool motor2Calisiyor;
        int hiz=0;
        int benzin=10000;
        int yukseklik=0;
        int havaSicakligi;
        int yolcuSayisi;
        int personelSayisi;
        decimal alinanYol=0.00M;
        DateTime ucusSuresi;
        DateTime yerelSaat;
        string havaDurumu;
        string pilotAdiSoyadi="Fatih YILDIZHAN";
        string cooPilotAdiSoyadi="FyDoxa";
        string kalkisYeri;
        string varisYeri;
        #endregion

        #region properties
        public bool Motor1Calisiyor
        {
            get { return motor1Calisiyor; }
            set 
            {
                motor1Calisiyor = value;
                if (motor1Calisiyor)
                {
                    motorCalisti(1);
                }
                else
                {
                    motorDurdu(1);
                }
            }
        }
        public bool Motor2Calisiyor
        {
            get { return motor2Calisiyor; }
            set
            {
                motor2Calisiyor = value;
                if (motor2Calisiyor)
                {
                    motorCalisti(2);
                }
                else
                {
                    motorDurdu(2);
                }
            }
        }
        public int Hiz
        {
            get { return hiz; }
            set 
            {
                hiz = value;
                if (hiz > 800)
                {
                    hizlandi(hiz);
                }
                else if (hiz < 600)
                {
                    yavasladi(hiz);
                }
            }
        }
        public int Benzin
        {
            get { return benzin; }
            set 
            {
                benzin = value;
                if(benzin>8000)
                {
                    benzinNormal(benzin);
                }
                else if(benzin<3000)
                {
                    benzinAzaldi(benzin);
                }
                else if(benzin==0)
                {
                    benzinBitti(benzin);
                }
                
            }
        }
        public int Yukseklik
        {
            get { return yukseklik; }
            set 
            {
                yukseklik = value;
                if (yukseklik > 100)
                {
                    havalandi(yukseklik);
                }
                else
                {
                    inisYapti(yukseklik);
                }
                if(yukseklik>10000)
                {
                    yukseldi(yukseklik);
                }
                if(yukseklik<1000)
                {
                    alcaldi(yukseklik);
                }
                
            }
        }
        public int HavaSicakligi
        {
            get { return havaSicakligi; }
            set 
            {
                if (havaSicakligi > 40)
                {
                    sicaklikArtti(havaSicakligi);
                }
                else if (havaSicakligi < 20)
                {
                    sicaklikDustu(havaSicakligi);
                }
                else
                {
                    sicaklikNormal(havaSicakligi);
                }
                
                havaSicakligi = value;
            }
        }
        public int YolcuSayisi
        {
            get { return yolcuSayisi; }
            set { yolcuSayisi = value; }
        }
        public int PersonelSayisi
        {
            get { return personelSayisi; }
            set { personelSayisi = value; }
        }
        public decimal AlinanYol
        {
            get { return alinanYol; }
            set { alinanYol = value; }
        }
        public DateTime UcusSuresi
        {
            get { return ucusSuresi; }
            set { ucusSuresi = value; }
        }
        public DateTime YerelSaat
        {
            get { return yerelSaat; }
            set { yerelSaat = value; }
        }
        public string HavaDurumu
        {
            get { return havaDurumu; }
            set 
            {
                if (havaDurumu == "Yağışlı Hava")
                {
                    yagmurYagiyor(havaDurumu);
                }
                else if (havaDurumu == "Karlı Hava")
                {
                    karYagiyor(havaDurumu);
                }
                else if (havaDurumu == "Rüzgârlı Hava")
                {
                    ruzgarEsiyor(havaDurumu);
                }
                else if (havaDurumu == "Güneşli Hava")
                {
                    gunesAciyor(havaDurumu);
                }
                havaDurumu = value;
            }
        }
        public string PilotAdiSoyadi
        {
            get { return pilotAdiSoyadi; }
            set { pilotAdiSoyadi = value; }
        }
        public string CooPilotAdiSoyadi
        {
            get { return cooPilotAdiSoyadi; }
            set { cooPilotAdiSoyadi = value; }
        }
        public string KalkisYeri
        {
            get { return kalkisYeri; }
            set { kalkisYeri = value; }
        }
        public string VarisYeri
        {
            get { return varisYeri; }
            set 
            {
                varisYeri = value;
                DateTime dt;
                if (varisYeri == "BODRUM")
                {
                    dt = new DateTime(2009,1,1,1,26,34);
                    ucusSuresi = dt;
                }
                else if (varisYeri == "İZMİR")
                {
                    dt = new DateTime(2009, 1, 1, 2, 36, 24);
                    ucusSuresi = dt;
                }
                else if (varisYeri == "İSTANBUL")
                {
                    dt = new DateTime(2009, 1, 1, 3, 54, 19);
                    ucusSuresi = dt;
                }
                else if (varisYeri == "FETHİYE")
                {
                    dt = new DateTime(2009, 1, 1, 2, 16, 37);
                    ucusSuresi = dt;
                }
            }
            
        }
        #endregion
    }
}
