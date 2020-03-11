using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DoxaMarina
{
    class Musteri
    {
        public static ArrayList musteriListesi = new ArrayList();
        public static int IdSayac = 1;
        #region constructors
        public Musteri()
        {
            this.musteriId = IdSayac;
            IdSayac++;
        }


        public Musteri(string pAd, string pSoyad, DateTime pDogumTarih, Yat pMYat)
        {

           this.musteriId = IdSayac;
           this.musteriAd = pAd;
           this.musteriSoyad = pSoyad;
           this.dogumTarih = pDogumTarih;
           this.mYat = pMYat;
           IdSayac++;
        }
        #endregion
        #region fields
        int musteriId;
        string musteriAd;
        string musteriSoyad;
        DateTime dogumTarih;
        Yat mYat;
        #endregion
        #region properties
        public int MusteriId
        {
            get { return musteriId; }
        }
        public string MusteriAd
        {
            get { return musteriAd; }
            set { musteriAd = value; }
        }
        public string MusteriSoyad
        {
            get { return musteriSoyad; }
            set { musteriSoyad = value; }
        }
        public DateTime DogumTarih
        {
            get { return dogumTarih; }
            set { dogumTarih = value; }
        }
        internal Yat MYat
        {
            get { return mYat; }
            set { mYat = value; }
        }
        #endregion
    }
}
