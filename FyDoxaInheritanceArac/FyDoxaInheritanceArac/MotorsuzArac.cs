using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaInheritanceArac
{
    class MotorsuzArac:Arac
    {
        #region constructor
        public MotorsuzArac(double pAracFiyati, string pAracSahibiAd, string pAracSahibiSoyad, string pAracSahibiTcNo, DateTime pAracAlinmaTarihi, string pAracTipi, string pUretimYeri)
        {
            AracAlinmaTarihi = pAracAlinmaTarihi;
            AracFiyati = pAracFiyati;
            AracSahibiAd = pAracSahibiAd;
            AracSahibiSoyad = pAracSahibiSoyad;
            AracSahibiTcNo = pAracSahibiTcNo;
            AracTipi = pAracTipi;
            UretimYeri = pUretimYeri;
        }
        #endregion
    }
}
