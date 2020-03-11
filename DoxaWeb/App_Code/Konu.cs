using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Konu
/// </summary>
public class Konu
{
    int konuId;
    string konuAd;
    string aciklama;

    public int KonuId
    {
        get { return konuId; }
        set { konuId = value; }
    }  
    public string KonuAd
    {
        get { return konuAd; }
        set { konuAd = value; }
    }
    public string Aciklama
    {
        get { return aciklama; }
        set { aciklama = value; }
    }

    public override string ToString()
    {
        return konuAd;
    }
}
