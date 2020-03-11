using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace DoxaKutuphaneDAL.Facade
{ 
    public static class Kullanici
    {
        public static SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;uid=sa;pwd=123;");
        public static bool KullaniciEkle(string pGercekAd, string pSoyad, string pKullaniciAd, string pSifre, string pMail,string pAvatar)
        {
        SqlCommand com = new SqlCommand("KullaniciEkle", con);
        com.CommandType = CommandType.StoredProcedure;
        com.Parameters.AddWithValue("@GercekAd", pGercekAd);
        com.Parameters.AddWithValue("@Soyad",pSoyad);
        com.Parameters.AddWithValue("@KullaniciAd",pKullaniciAd);
        com.Parameters.AddWithValue("@Sifre",pSifre);
        com.Parameters.AddWithValue("@Mail",pMail);
        com.Parameters.AddWithValue("@Avatar",pAvatar);

        bool kontrol = true;
        try
        {
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            com.ExecuteNonQuery();
        }
        catch (Exception)
        {

            kontrol = false;
        }
        finally
        {
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
        }

        return kontrol;
        }  
    
    
    }
}
