using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace DoxaKutuphaneDAL.Facade
{
    public static class Yazar
    {
          public static SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
          public static SqlDataAdapter da;
          public static DataTable dt;
   
        public static DataTable YazarGetir(int pYazarId,string pAd,string pSoyad,int pYayinEviId)
        { 
            SqlCommand com = new SqlCommand("YazarGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@YazarId",pYazarId);
            com.Parameters.AddWithValue("@Ad",pAd);
            com.Parameters.AddWithValue("@Soyad",pSoyad);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable YazarlariGetir()
        { 
            SqlCommand com = new SqlCommand("select * from Yazar", con);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool YazarEkle(string pAd, string pSoyad, int pYayinEviId)
        {
            SqlCommand com = new SqlCommand("YazarEkle",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Ad",pAd);
            com.Parameters.AddWithValue("@Soyad",pSoyad);
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);

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
        public static bool YazarSil(int pYazarId)
        {
            SqlCommand com = new SqlCommand("YazarSil",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@YazarId",pYazarId);

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
