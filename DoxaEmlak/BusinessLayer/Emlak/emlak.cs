using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class emlak
    {
        #region
        int emlakId;
        int emlakTipId;
        string emlakBaslik;
        int emlakReferansNo;
        string emlakM2;
        string odaSayisi;
        string banyoSayisi;
        int binaYasi;
        int binadakiKatSayisi;
        int bulunduguKat;
        int isitmaTipId;
        bool krediyeUygun;
        string durumu;
        string tapuDurumu;
        string emlakAciklama;
        DateTime emlakEklenmeTarihi;
        string aidat;
        string deposit;
        int kategoriId;
        int balkonSayisi;

        #endregion

        #region properties
        public int EmlakId
        {
            get { return emlakId; }
            set { emlakId = value; }
        }
        public int EmlakTipId
        {
            get { return emlakTipId; }
            set { emlakTipId = value; }
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
        public string OdaSayisi
        {
            get { return odaSayisi; }
            set { odaSayisi = value; }
        }
        public string BanyoSayisi
        {
            get { return banyoSayisi; }
            set { banyoSayisi = value; }
        }
        public int BinaYasi
        {
            get { return binaYasi; }
            set { binaYasi = value; }
        }
        public int BinadakiKatSayisi
        {
            get { return binadakiKatSayisi; }
            set { binadakiKatSayisi = value; }
        }
        public int BulunduguKat
        {
            get { return bulunduguKat; }
            set { bulunduguKat = value; }
        }
        public int IsitmaTipId
        {
            get { return isitmaTipId; }
            set { isitmaTipId = value; }
        }
        public bool KrediyeUygun
        {
            get { return krediyeUygun; }
            set { krediyeUygun = value; }
        }
        public string Durumu
        {
            get { return durumu; }
            set { durumu = value; }
        }
        public string TapuDurumu
        {
            get { return tapuDurumu; }
            set { tapuDurumu = value; }
        }
        public string EmlakAciklama
        {
            get { return emlakAciklama; }
            set { emlakAciklama = value; }
        }
        public DateTime EmlakEklenmeTarihi
        {
            get { return emlakEklenmeTarihi; }
            set { emlakEklenmeTarihi = value; }
        }
        public string Aidat
        {
            get { return aidat; }
            set { aidat = value; }
        }
        public string Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public int KategoriId
        {
            get { return kategoriId; }
            set { kategoriId = value; }
        }
        public int BalkonSayisi
        {
            get { return balkonSayisi; }
            set { balkonSayisi = value; }
        }
        #endregion
    }
}
