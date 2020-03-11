using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

/// <summary>
/// Summary description for Fonksiyon
/// </summary>
public static class Fonksiyon
{
    static SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["TakisogluConnectionString"].ToString());


    public static DataTable UrunGetir()
    {
        SqlCommand com = new SqlCommand("select KategoriAd,UrunId,UrunAd,u.Aciklama,Baslik,Resim from Urun u inner join Kategori k on k.KategoriId=u.KategoriId", con);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
    }


    public static DataTable UrunGetirId(int Id)
    {
        SqlCommand com = new SqlCommand("select KategoriAd,Baslik,UrunId,UrunAd,u.Aciklama,Resim from Urun u full join Kategori k on k.KategoriId=u.KategoriId where k.KategoriId=@Id", con);
        com.Parameters.AddWithValue("@Id",Id);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
    }

    public static DataTable UrunDetayGetirId(int Id)
    {
        SqlCommand com = new SqlCommand("UrunDetayGetir", con);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@Id", Id);
        SqlDataAdapter da = new SqlDataAdapter(com);
        DataTable dt = new DataTable();
        da.Fill(dt);

        return dt;
    }



}
