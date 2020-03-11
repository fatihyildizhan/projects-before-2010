using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DoxaKutuphaneDAL.Facade
{
    public static class Kategori
    {
  
        public  static  SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
      

        public static bool KategoriEkle(string pKategoriAd)
        {
            SqlCommand com = new SqlCommand("KategoriEkle", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@KategoriAd",pKategoriAd);

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
        public static bool KategoriSil(int pKategoriId)
        {
            SqlCommand com = new SqlCommand("KategoriSil", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KategoriId",pKategoriId);

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
