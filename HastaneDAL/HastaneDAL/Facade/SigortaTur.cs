using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HastaneDAL.Facade
{
    public static class SigortaTur
    {
        static SqlConnection con = new SqlConnection(TOOL.Baglanti);

        public static bool SigotaTurEkle(string SigortaAd)
        {
            SqlCommand com = new SqlCommand("Prc_SigortaTurEkle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SigortaAd", SigortaAd);

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

        public static bool SigortaTurGuncelle(Entity.SigortaTur st)
        {
            SqlCommand com = new SqlCommand("Prc_SigortaTurGuncelle", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SigortaId", st.SigortaId);
            com.Parameters.AddWithValue("@SigortaAd", st.SigortaAd);

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

        public static DataTable SigortaTurGetir()
        {
            SqlCommand com = new SqlCommand("Prc_SigortTurGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public static bool SigortaTurSil(string SigortaId)
        {
            SqlCommand com = new SqlCommand("Prc_SigortaTurSil", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SigortaId", SigortaId);

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
