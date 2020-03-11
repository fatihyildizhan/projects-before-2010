using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinemaDAL.Entity
{
    public class Kullanici
    {
        #region constructor
        public Kullanici()
        { }
        #endregion

        #region fields
        int kullaniciId;
        string kullaniciAd;
        string sifre;
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
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        #endregion
    }
}
