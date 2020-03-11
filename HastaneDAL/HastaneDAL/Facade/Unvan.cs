using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HastaneDAL.Facade
{
    public static class Unvan
    {
        static SqlConnection con = new SqlConnection(TOOL.Baglanti);
        
        public static bool UnvanEkle(string UnvanAd)
        {
            SqlCommand com = new SqlCommand("Prc_UnvanEkle",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@unvanAd", UnvanAd);
            
            bool kontrol = true;
            
            try
            {
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

        public static bool UnvanGuncelle(Entity.Unvan u)
        {
            SqlCommand com = new SqlCommand("Prc_UnvanGuncelle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@UnvanId", u.UnvanId);
            com.Parameters.AddWithValue("@UnvanAd", u.UnvanAd);
            bool kontrol = true;

            try
            {
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

        public static DataTable UnvanGetir()
        {
            SqlCommand com = new SqlCommand("Prc_UnvanGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);
           
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }


        public static bool UnvanSil(string UnvanId)
        {
            SqlCommand com = new SqlCommand("Prc_UnvanSil", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@unvanId", UnvanId);

            bool kontrol = true;

            try
            {
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



    }
}
