using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoxaKutuphaneDAL.Entity
{
   public class Kategori
    {
        #region fields
        int kategoriId;
        string kategoriAd;
        #endregion
     
        #region properties
        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }
        

        public string KategoriAd
        {
            get { return kategoriAd; }
            set { kategoriAd = value; }
        }
        #endregion

       #region methods
        public override string ToString()
        {
            return kategoriAd;
        }
        #endregion
    }
}
