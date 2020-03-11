using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class emlakDetay
    {
        public emlakDetay()
        {
            fiyatlar = new fiyat();
            resimlerBuyuk = new List<string>();
            resimlerKucuk = new List<string>();
            ozellikler = new List<string>();
        }

        int emlakId;

        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        int emlakTipId;

        public int EmlakTipId
        {
            get { return emlakTipId; }
            set { emlakTipId = value; }
        }
        string emlakTipAd;

        public string EmlakTipAd
        {
            get { return emlakTipAd; }
            set { emlakTipAd = value; }
        }
        string emlakBaslik;

        public string EmlakBaslik
        {
            get { return emlakBaslik; }
            set { emlakBaslik = value; }
        }
        int emlakReferansNo;

        public int EmlakReferansNo
        {
            get { return emlakReferansNo; }
            set { emlakReferansNo = value; }
        }
        string emlakM2;

        public string EmlakM2
        {
            get { return emlakM2; }
            set { emlakM2 = value; }
        }
        string odaSayisi;

        public string OdaSayisi
        {
            get { return odaSayisi; }
            set { odaSayisi = value; }
        }
        string banyoSayisi;

        public string BanyoSayisi
        {
            get { return banyoSayisi; }
            set { banyoSayisi = value; }
        }
        int binaYasi;

        public int BinaYasi
        {
            get { return binaYasi; }
            set { binaYasi = value; }
        }
        int katSayisi;

        public int KatSayisi
        {
            get { return katSayisi; }
            set { katSayisi = value; }
        }
        int bulunduguKat;

        public int BulunduguKat
        {
            get { return bulunduguKat; }
            set { bulunduguKat = value; }
        }
        int isitmaTipId;

        public int IsitmaTipId
        {
            get { return isitmaTipId; }
            set { isitmaTipId = value; }
        }
        string isitmaTipAd;

        public string IsitmaTipAd
        {
            get { return isitmaTipAd; }
            set { isitmaTipAd = value; }
        }
        bool krediyeUygun;

        public bool KrediyeUygun
        {
            get { return krediyeUygun; }
            set { krediyeUygun = value; }
        }
        string durumu;

        public string Durumu
        {
            get { return durumu; }
            set { durumu = value; }
        }
        string tapuDurumu;

        public string TapuDurumu
        {
            get { return tapuDurumu; }
            set { tapuDurumu = value; }
        }
        string emlakAciklama;

        public string EmlakAciklama
        {
            get { return emlakAciklama; }
            set { emlakAciklama = value; }
        }
        DateTime emlakEklenmeTarihi;

        public DateTime EmlakEklenmeTarihi
        {
            get { return emlakEklenmeTarihi; }
            set { emlakEklenmeTarihi = value; }
        }
        string aidat;

        public string Aidat
        {
            get { return aidat; }
            set { aidat = value; }
        }
        string deposit;

        public string Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        fiyat fiyatlar;

        public fiyat Fiyatlar
        {
            get { return fiyatlar; }
            set { fiyatlar = value; }
        }
        List<string> ozellikler;

        public List<string> Ozellikler
        {
            get { return ozellikler; }
            set { ozellikler = value; }
        }
        List<string> resimlerKucuk;

        public List<string> ResimlerKucuk
        {
            get { return resimlerKucuk; }
            set { resimlerKucuk = value; }
        }
        List<string> resimlerBuyuk;

        public List<string> ResimlerBuyuk
        {
            get { return resimlerBuyuk; }
            set { resimlerBuyuk = value; }
        }

        string fiyatTL;

        public string FiyatTL
        {
            get { return fiyatTL; }
            set { fiyatTL = value; }
        }

        string adresTarifi;

        public string AdresTarifi
        {
            get { return adresTarifi; }
            set { adresTarifi = value; }
        }
        string sehirAd;

        public string SehirAd
        {
            get { return sehirAd; }
            set { sehirAd = value; }
        }
        string ilceAd;

        public string IlceAd
        {
            get { return ilceAd; }
            set { ilceAd = value; }
        }
        string semtAd;

        public string SemtAd
        {
            get { return semtAd; }
            set { semtAd = value; }
        }
        string caddeAd;

        public string CaddeAd
        {
            get { return caddeAd; }
            set { caddeAd = value; }
        }

        string ilkResimBuyuk;

        public string IlkResimBuyuk
        {
            get { return ilkResimBuyuk; }
            set { ilkResimBuyuk = value; }
        }
        string ilkResimKucuk;

        public string IlkResimKucuk
        {
            get { return ilkResimKucuk; }
            set { ilkResimKucuk = value; }
        }

        int kategoriId;

        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }
        string kategoriAd;

        public string KategoriAd
        {
            get { return kategoriAd; }
            set { kategoriAd = value; }
        }

        int balkonSayisi;

        public int BalkonSayisi
        {
            get { return balkonSayisi; }
            set { balkonSayisi = value; }
        }
    }
}
