using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class sehirGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<sehir> sehirGetirTum()
        {
            List<sehir> sehirler = new List<sehir>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Sehir  order by SehirAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    sehir s = new sehir();
                    s.SehirId = Convert.ToInt32(dr["SehirId"]);
                    s.SehirAd = dr["SehirAd"].ToString();
                    s.PostaKodu = Convert.ToInt32(dr["PostaKodu"]);
                    sehirler.Add(s);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return sehirler;
        }

        public sehir sehirGetirId(int sehirId)
        {
            sehir s = new sehir();
            try
            {
                SqlCommand com = new SqlCommand("select * from Sehir where SehirId = @shrId  order by SehirAd", con);
                com.Parameters.AddWithValue("@shrId", sehirId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    s.SehirId = Convert.ToInt32(dr["SehirId"]);
                    s.SehirAd = dr["SehirAd"].ToString();
                    s.PostaKodu = Convert.ToInt32(dr["PostaKodu"]);
                }
                dr.Close();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return s;
        }
        public int sehirAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Adres where SehirId=@id", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@id", id);

                con.Open();
                adet = Convert.ToInt32(com.ExecuteScalar());
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return adet;
        }
    }
}
