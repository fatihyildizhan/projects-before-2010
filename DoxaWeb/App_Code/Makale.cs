using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Makale
/// </summary>
public class Makale
{
    int makaleId;
    int konuId;
    string makaleAd;
    string yazar;
    string ozet;
    DateTime eklemeTarihi;
    int puan;
    int oyKullananSayisi;
    int okunmaSayisi;
    string aciklama;
    string link;


    public int MakaleId
    {
        get { return makaleId; }
        set { makaleId = value; }
    }
    public int KonuId
    {
        get { return konuId; }
        set { konuId = value; }
    }
    public string MakaleAd
    {
        get { return makaleAd; }
        set { makaleAd = value; }
    }
    public string Yazar
    {
        get { return yazar; }
        set { yazar = value; }
    }
    public string Ozet
    {
        get { return ozet; }
        set { ozet = value; }
    }
    public DateTime EklemeTarihi
    {
        get { return eklemeTarihi; }
        set { eklemeTarihi = value; }
    }   
    public int Puan
    {
        get { return puan; }
        set { puan = value; }
    }
    public int OyKullananSayisi
    {
        get { return oyKullananSayisi; }
        set { oyKullananSayisi = value; }
    }
    public int OkunmaSayisi
    {
        get { return okunmaSayisi; }
        set { okunmaSayisi = value; }
    }
    public string Aciklama
    {
        get { return aciklama; }
        set { aciklama = value; }
    }
    public string Link
    {
        get { return link; }
        set { link = value; }
    }
}
