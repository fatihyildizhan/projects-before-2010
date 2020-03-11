using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FyDoxaToplanti
{
    class Kullanici
    {
        #region field
       
        private int kullaniciId;
        private string kullaniciAd;
       
        #endregion

        #region properties
       
        public int KullaniciId
        {
            get { return kullaniciId; }
            set { kullaniciId = value; }
        }
        public string KullaniciAd
        {
            get { return kullaniciAd; }
            set { kullaniciAd = value; }
        }
      
        #endregion

        #region Overrided Methods

        public override string ToString()
        {
            return KullaniciAd;
        }

        #endregion
    }
}
