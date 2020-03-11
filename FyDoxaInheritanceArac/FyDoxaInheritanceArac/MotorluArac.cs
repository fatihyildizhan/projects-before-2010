using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaInheritanceArac
{
    class MotorluArac:Arac
    {
        public static List<MotorluArac> MotorluAracListesi = new List<MotorluArac>();

        #region constructor
        public MotorluArac()
        {

        }

        public MotorluArac(int pbeygirGucu, string psinifi, string pyakitTuru, double pAracFiyati, string pAracSahibiAd, string pAracSahibiSoyad, string pAracSahibiTcNo, DateTime pAracAlinmaTarihi, string pAracTipi, string pUretimYeri)
        {
            AracAlinmaTarihi = pAracAlinmaTarihi;
            AracFiyati = pAracFiyati;
            AracSahibiAd = pAracSahibiAd;
            AracSahibiSoyad = pAracSahibiSoyad;
            AracSahibiTcNo = pAracSahibiTcNo;
            AracTipi = pAracTipi;
            UretimYeri = pUretimYeri;
            BeygirGucu = pbeygirGucu;
            Sinifi = psinifi;
            YakitTuru = pyakitTuru;
        }
        #endregion

        #region fields
        private int beygirGucu;
        private string sinifi; // lüks,süper,günlük
        private string yakitTuru; //benzin,mazot
        protected double motorluAracVergisi;
        #endregion

        #region properties
        public int BeygirGucu
        {
            get { return beygirGucu; }
            set { beygirGucu = value; }
        }
        public string Sinifi
        {
            get { return sinifi; }
            set { sinifi = value; }
        }
        public string YakitTuru
        {
            get { return yakitTuru; }
            set { yakitTuru = value; }
        }
        #endregion

        #region Methods
        public void VergiHesapla(int pBeygirGucu, string pSinifi, string pYakitTuru)
        {
            double yakitTuruFiyat=1;
            double sinifiFiyat=1;

            if (pYakitTuru.Equals("Benzin"))
            {
                yakitTuruFiyat = 100.0;
            }
            else if (pYakitTuru.Equals("Dizel"))
            {
                yakitTuruFiyat = 75.0;
            }
            else if (pYakitTuru.Equals("Tüplü"))
            {
                yakitTuruFiyat = 50.0;
            }
            else
            {
                yakitTuruFiyat = 25.0;
            }

            if(pSinifi.Equals("UltraLüks"))
            {
                sinifiFiyat = 250.0;
            }
            else if (pSinifi.Equals("Lüks"))
            {
                sinifiFiyat = 150.0;
            }
            else if (pSinifi.Equals("Normal"))
            {
                sinifiFiyat = 75.0;
            }
            else
            {
                sinifiFiyat = 25.0;
            }

            motorluAracVergisi = sinifiFiyat * yakitTuruFiyat * pBeygirGucu;
        }
        
        #endregion
    }
}
