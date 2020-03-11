using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaSystemIO
{
    class Dosya:IComparable
    {
        int dosyaId;
        string dosyaAd;
        string uzanti;
        DateTime tarih;
        byte[] dosyam;

        public int DosyaId
        {
            get { return dosyaId; }
            set { dosyaId = value; }
        }
        public string DosyaAd
        {
            get { return dosyaAd; }
            set { dosyaAd = value; }
        }
        public string Uzanti
        {
            get { return uzanti; }
            set { uzanti = value; }
        }
        public DateTime Tarih
        {
            get { return tarih; }
            set { tarih = value; }
        }
        public byte[] Dosyam
        {
            get { return dosyam; }
            set { dosyam = value; }
        }

        public static int deger = 1;
        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (this.Tarih < (obj as Dosya).Tarih)
            {
                return deger * -1;
            }
            else if (this.Tarih > (obj as Dosya).Tarih)
            {
                return deger * 1;
            }
            else
            {
                return 0;
            }
        }

        #endregion
    }
}
