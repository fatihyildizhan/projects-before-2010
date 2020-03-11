using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoxaKutuphaneDAL.Entity
{
    public class Kullanici
    {
        #region constructor
        public Kullanici()
        { 
        
        }
        #endregion

        #region fields
        int kullanciId;
        string gercekAd;
        string soyad;
        string kullaniciAd;
        string sifre;
        string mail;
        string avatar;
        #endregion

        #region properties
        public int KullanciId
        {
            get { return kullanciId; }
            set { kullanciId = value; }
        }
        public string GercekAd
        {
            get { return gercekAd; }
            set { gercekAd = value; }
        }
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
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
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        
        #endregion

    }
}
