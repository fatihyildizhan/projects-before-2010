using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;
using System.Xml;
using System.Text;

/// <summary>
/// Summary description for Functions
/// </summary>
public static class Functions
{
    static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString());

    public static string sonUyeGetir()
    {
        string ad = "";
        try
        {
            SqlCommand com = new SqlCommand("SonUyeGetir", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ad = dr["UserName"].ToString();
            }
            dr.Close();
        }
        catch
        {
            ad = "hata!";
        }
        finally
        {
            con.Close();
        }
        return ad;
    }
    public static bool MakaleEklee(Makale makale)
    {
        bool kontrol = true;
        try
        {
            SqlCommand com = new SqlCommand("MakaleEkle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KonuId", makale.KonuId);
            com.Parameters.AddWithValue("@MakaleAd", makale.MakaleAd);
            com.Parameters.AddWithValue("@Ozet", makale.Ozet);
            com.Parameters.AddWithValue("@Aciklama", makale.Aciklama);
            com.Parameters.AddWithValue("@Link", makale.Link);
            com.Parameters.AddWithValue("@Yazar", makale.Yazar);
            con.Open();
            com.ExecuteNonQuery();
        }
        catch
        {
            kontrol = false;   
        }
        finally
        {
            con.Close();
        }

        return kontrol;       
    }
    public static int ToplamKonuSayisi()
    {
        int sonuc=0;
        try
        {
            SqlCommand com = new SqlCommand("select count(*) from makale", con);
            con.Open();
            sonuc = Convert.ToInt32(com.ExecuteScalar());
        }
        catch (Exception)
        {
            return 0;
        }
        finally
        {
            con.Close();
        }
            return sonuc;  
    }
    public static void MakaleOkunmaSayisiArtir(int MakaleId)
    {
        try
        {
            SqlCommand com = new SqlCommand("MakaleOkunmaSayisiArtir", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MakaleId", MakaleId);
            con.Open();
            com.ExecuteNonQuery();
        }
        catch (Exception)
        {

        }
        finally
        {
            con.Close();
        }
    }
    public static void MakaleIndirmeSayisiArtir(int MakaleId)
    {
        try
        {
            SqlCommand com = new SqlCommand("MakaleIndirmeSayisiArtir", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@MakaleId", MakaleId);
            con.Open();
            com.ExecuteNonQuery();
        }
        catch (Exception)
        {

        }
        finally
        {
            con.Close();
        }
    }
    public static DataTable MakaleGetir(int pMakaleId)
    {
        SqlCommand com = new SqlCommand("MakaleGetir",con);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@MakaleId",pMakaleId);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public static List<RSS> rssOkuHurriyet(string rssLink)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(rssLink);
        XmlNodeList liste = xdom.SelectNodes("rss/channel/item");
        List<RSS> rssHURRIYET = new List<RSS>();
        foreach (XmlNode node in liste)
        {
            RSS rss = new RSS();
            rss.HURRIYETtitle = node["title"].InnerText;
            rss.HURRIYETdescription = node["description"].InnerText;
            rss.HURRIYETlink = node["link"].InnerText;
            rssHURRIYET.Add(rss);
        }
        return rssHURRIYET;
    }
    public static List<RSS> rssOkuNTV(string rssLink)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(rssLink);
        XmlNodeList liste = xdom.SelectNodes("rss/channel/item");
        List<RSS> rssNTV = new List<RSS>();
        foreach (XmlNode node in liste)
        {
            RSS rss = new RSS();
            if (node["title"]!= null)
            {
                rss.NTVtitle = node["title"].InnerText;
            }
            if (node["description"]!= null)
            {
                rss.NTVdescription = node["description"].InnerText;
            }
            if (node["link"]!= null)
            {
                rss.NTVlink = node["link"].InnerText;
            }
            rssNTV.Add(rss);
        }
        return rssNTV;
    }
    public static List<RSS> rssOkuEKOLAY(string rssLink)
    {
        XmlDocument xdom = new XmlDocument();
        xdom.Load(rssLink);
        XmlNodeList liste = xdom.SelectNodes("rss/channel/item");
        List<RSS> rssEKOLAY = new List<RSS>();
        foreach (XmlNode node in liste)
        {
            RSS rss = new RSS();
            if (node["title"] != null)
            {
                rss.EKOLAYtitle = node["title"].InnerText;
            }
            if (node["description"] != null)
            {
                rss.EKOLAYdescription = node["description"].InnerText;
            }
            if (node["link"] != null)
            {
                rss.EKOLAYlink = node["link"].InnerText;
            }
            rssEKOLAY.Add(rss);
        }
        return rssEKOLAY;
    }

  

}
