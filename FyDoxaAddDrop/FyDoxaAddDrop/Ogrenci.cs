using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaAddDrop
{
    [Serializable]
    class Ogrenci
    {
        string ogrenciAd;
        int xKor;
        int yKor;

        public string OgrenciAd
        {
            get { return ogrenciAd; }
            set { ogrenciAd = value; }
        }
        
        public int XKor
        {
            get { return xKor; }
            set { xKor = value; }
        }
        
        public int YKor
        {
            get { return yKor; }
            set { yKor = value; }
        }
    }
}
