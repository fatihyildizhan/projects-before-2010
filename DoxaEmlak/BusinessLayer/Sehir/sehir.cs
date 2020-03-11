using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class sehir
    {
        int sehirId;

        public int SehirId
        {
            get { return sehirId; }
            set { sehirId = value; }
        }
        string sehirAd;

        public string SehirAd
        {
            get { return sehirAd; }
            set { sehirAd = value; }
        }
        int postaKodu;

        public int PostaKodu
        {
            get { return postaKodu; }
            set { postaKodu = value; }
        }
    }
}
