using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class caddeGetir
    {

        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<cadde> caddeGetirTum()
        {
            List<cadde> caddeler = new List<cadde>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Cadde order by CaddeAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cadde c = new cadde();
                    c.CaddeAd = dr["CaddeAd"].ToString();
                    c.CaddeId = Convert.ToInt32(dr["CaddeId"]);
                    c.SemtId = Convert.ToInt32(dr["SemtId"]);
                    caddeler.Add(c);
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
            return caddeler;
        }
        public List<cadde> caddeGetirSemtId(int SemtId)
        {
            List<cadde> caddeler = new List<cadde>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Cadde where SemtId=@smtId  order by CaddeAd", con);
                com.Parameters.AddWithValue("@smtId", SemtId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cadde c = new cadde();
                    c.CaddeAd = dr["CaddeAd"].ToString();
                    c.CaddeId = Convert.ToInt32(dr["CaddeId"]);
                    c.SemtId = Convert.ToInt32(dr["SemtId"]);
                    caddeler.Add(c);
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
            return caddeler;
        }
        public cadde caddeGetirId(int caddeId)
        {
            cadde c = new cadde();
            try
            {
                SqlCommand com = new SqlCommand("select * from Cadde where CaddeId = @cdId", con);
                com.Parameters.AddWithValue("@cdId", caddeId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    c.CaddeAd = dr["CaddeAd"].ToString();
                    c.CaddeId = Convert.ToInt32(dr["CaddeId"]);
                    c.SemtId = Convert.ToInt32(dr["SemtId"]);
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
            return c;
        }
        public int caddeAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Adres where CaddeId=@id", con);
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
