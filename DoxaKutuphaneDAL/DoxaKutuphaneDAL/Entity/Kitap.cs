using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoxaKutuphaneDAL.Entity
{
    public class Kitap
    {
        #region constructor
        public Kitap()
        {

        }
        #endregion
        
        #region fields
        int kitapId;
        string kitapAd;
        int kategoriId;
        int yazarId;
        int yayinEviId;
        #endregion

        #region properties
        public int KitapId
        {
            get { return kitapId; }
            set { kitapId = value; }
        }
        public string KitapAd
        {
            get { return kitapAd; }
            set { kitapAd = value; }
        }
        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }
        public int YazarId
        {
            get { return yazarId; }
            set { yazarId = value; }
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
            return kitapAd;
        }
        #endregion
    }
}
