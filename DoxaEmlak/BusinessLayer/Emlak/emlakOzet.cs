using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class emlakOzet
    {
        int emlakId;
        string emlakTipAd;
        string emlakBaslik;
        int emlakReferansNo;
        string emlakM2;
        string ilkResimKucuk;
        string ilkResimBuyuk;
        int fiyatTL;
        string adres;
        string kategoriAd;

        public string KategoriAd
        {
            get { return kategoriAd; }
            set { kategoriAd = value; }
        }

        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        public string EmlakTipAd
        {
            get { return emlakTipAd; }
            set { emlakTipAd = value; }
        }
        public string EmlakBaslik
        {
            get { return emlakBaslik; }
            set { emlakBaslik = value; }
        }
        public int EmlakReferansNo
        {
            get { return emlakReferansNo; }
            set { emlakReferansNo = value; }
        }
        public string EmlakM2
        {
            get { return emlakM2; }
            set { emlakM2 = value; }
        }
        public string IlkResimKucuk
        {
            get { return ilkResimKucuk; }
            set { ilkResimKucuk = value; }
        }
        public string IlkResimBuyuk
        {
            get { return ilkResimBuyuk; }
            set { ilkResimBuyuk = value; }
        }
        public int FiyatTL
        {
            get { return fiyatTL; }
            set { fiyatTL = value; }
        }
        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
    }
}
