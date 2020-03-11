using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoxaKutuphaneDAL.Entity
{
    public class Yazar
    {
        #region fields
        int yazarId;
        string ad;
        string soyad;
        int yayinEviId;
        #endregion

        #region properties
        public int YazarId
        {
            get { return yazarId; }
            set { yazarId = value; }
        }
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YayinEviId
        {
            get { return yayinEviId; }
            set { yayinEviId = value; }
        }
        #endregion
        #region methods
        public override string ToString()
        {
            return ad+" "+soyad;
        }
        #endregion
    }
}
