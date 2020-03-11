using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaBinaryFormat
{
    [Serializable]
    class Ogrenci
    {
        #region fields
        string ogrAd;
        string ogrSoyad;
        int ogrNo;
        string bolumAd;
        #endregion

        #region properties
        public string OgrAd
        {
            get { return ogrAd; }
            set { ogrAd = value; }
        }
        public string OgrSoyad
        {
            get { return ogrSoyad; }
            set { ogrSoyad = value; }
        }
        public int OgrNo
        {
            get { return ogrNo; }
            set { ogrNo = value; }
        }
        public string BolumAd
        {
            get { return bolumAd; }
            set { bolumAd = value; }
        }
        #endregion
    }
}
