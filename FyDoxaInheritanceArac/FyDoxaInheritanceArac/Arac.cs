using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaInheritanceArac
{
    abstract class Arac
    {
        #region constructor
       
        #endregion

        #region fields
        private double aracFiyati;
        private string aracSahibiAd;
        private string aracSahibiSoyad;
        private string aracSahibiTcNo;
        private DateTime aracAlinmaTarihi;
        private string aracTipi; //tekne,araba,bisiklet
        private string uretimYeri;
        #endregion

        #region properties
        public double AracFiyati
        {
            get { return aracFiyati; }
            set { aracFiyati = value; }
        }
        public string AracSahibiAd
        {
            get { return aracSahibiAd; }
            set { aracSahibiAd = value; }
        }
        public string AracSahibiSoyad
        {
            get { return aracSahibiSoyad; }
            set { aracSahibiSoyad = value; }
        }
        public string AracSahibiTcNo
        {
            get { return aracSahibiTcNo; }
            set { aracSahibiTcNo = value; }
        }
        public DateTime AracAlinmaTarihi
        {
            get { return aracAlinmaTarihi; }
            set { aracAlinmaTarihi = value; }
        }
        public string AracTipi
        {
            get { return aracTipi; }
            set { aracTipi = value; }
        }
        public string UretimYeri
        {
            get { return uretimYeri; }
            set { uretimYeri = value; }
        }
        #endregion
    }
}
