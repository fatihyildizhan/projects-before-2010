using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DoxaKutuphaneDAL.Facade
{
    public static class YayinEvi
    {
        public static SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        public static bool YayinEviEkle(string pYayinEviAd, string pAdres)
        {
            SqlCommand com = new SqlCommand("YayinEviEkle",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@YayinEviAd",pYayinEviAd);
            com.Parameters.AddWithValue("@Adres",pAdres);

            bool kontrol = true;
            try
            {
                DoxaMethodsDAL.Facade.Connection.ConOpen(con);
                com.ExecuteNonQuery();
            }
            catch 
            {

                kontrol = false;
            }
            finally 
            {
                DoxaMethodsDAL.Facade.Connection.ConClose(con);
            }
            return kontrol;
        }
        public static bool YayinEviSil(int pYayinEvId)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "YayinEviSil";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@YayinEviId",pYayinEvId);

            bool kontrol = true;
            try
            {
                DoxaMethodsDAL.Facade.Connection.ConOpen(con);
                com.ExecuteNonQuery();
            }
            catch
            {
                kontrol = false;
            }
            finally
            {
                DoxaMethodsDAL.Facade.Connection.ConClose(con);
            }
            return kontrol;
        }
        public static bool YayinEviGuncelle(int pYayinEviId, string pYayinEviAd, string pAdres)
        {
            SqlCommand com = new SqlCommand("YayinEviGuncelle",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@YayinEviId",pYayinEviId);
            com.Parameters.AddWithValue("@YayinEviAd",pYayinEviAd);
            com.Parameters.AddWithValue("@Adres",pAdres);

            bool kontrol = true;
            try
            {
                DoxaMethodsDAL.Facade.Connection.ConOpen(con);
                com.ExecuteNonQuery();
            }
            catch 
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
