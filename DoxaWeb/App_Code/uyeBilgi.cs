using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for uyeBilgi
/// </summary>
/// 
[Serializable]
public class uyeBilgi
{
    #region TemelBilgiler
    string onayKodu;
   
    string ad;
    string soyad;
    string cinsiyet;
    string dogumTarihi;
    string memleket;

    public string OnayKodu
    {
        get { return onayKodu; }
        set { onayKodu = value; }
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
    public string Cinsiyet
    {
        get { return cinsiyet; }
        set { cinsiyet = value; }
    }
    public string DogumTarihi
    {
        get { return dogumTarihi; }
        set { dogumTarihi = value; }
    }
    public string Memleket
    {
        get { return memleket; }
        set { memleket = value; }
    }
    #endregion

    #region KisiselBilgiler
    string favoriSozu;
    string aktivite;
    string ilgiAlani;

    public string FavoriSozu
    {
        get { return favoriSozu; }
        set { favoriSozu = value; }
    }
    public string Aktivite
    {
        get { return aktivite; }
        set { aktivite = value; }
    }
    public string IlgiAlani
    {
        get { return ilgiAlani; }
        set { ilgiAlani = value; }
    }
    #endregion

    #region iletisimBilgileri
    string msn;
    string cepno;
    string yasadigiSehir;
    string websitesi;
    string nickname;
    string ruhDurumu;


    public string Msn
    {
        get { return msn; }
        set { msn = value; }
    }
    public string Cepno
    {
        get { return cepno; }
        set { cepno = value; }
    }
    public string YasadigiSehir
    {
        get { return yasadigiSehir; }
        set { yasadigiSehir = value; }
    }
    public string Websitesi
    {
        get { return websitesi; }
        set { websitesi = value; }
    }
    public string Nickname
    {
        get { return nickname; }
        set { nickname = value; }
    }
    public string RuhDurumu
    {
        get { return ruhDurumu; }
        set { ruhDurumu = value; }
    }
    #endregion

    #region EgitimVeIsBilgileri
    string universite;
    string uniBolum;
    string lise;
    string meslek;

    public string Universite
    {
        get { return universite; }
        set { universite = value; }
    }
    public string UniBolum
    {
        get { return uniBolum; }
        set { uniBolum = value; }
    }
    public string Lise
    {
        get { return lise; }
        set { lise = value; }
    }
    public string Meslek
    {
        get { return meslek; }
        set { meslek = value; }
    }
    #endregion
}
