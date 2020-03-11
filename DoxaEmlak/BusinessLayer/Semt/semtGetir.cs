using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class semtGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<semt> semtGetirTum()
        {
            List<semt> semtler = new List<semt>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Semt  order by SemtAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    semt s = new semt();
                    s.SemtAd = dr["SemtAd"].ToString();
                    s.SemtId = Convert.ToInt32(dr["SemtId"]);
                    s.IlceId = Convert.ToInt32(dr["IlceId"]);
                    semtler.Add(s);
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
            return semtler;
        }
        public List<semt> semtGetirIlceId(int IlceId)
        {
            List<semt> semtler = new List<semt>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Semt where IlceId=@ilceId  order by SemtAd", con);
                com.Parameters.AddWithValue("@ilceId",IlceId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    semt s = new semt();
                    s.SemtAd = dr["SemtAd"].ToString();
                    s.SemtId = Convert.ToInt32(dr["SemtId"]);
                    s.IlceId = Convert.ToInt32(dr["IlceId"]);
                    semtler.Add(s);
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
            return semtler;
        }
        public semt semtGetirId(int semtId)
        {
            semt s = new semt();
            try
            {
                SqlCommand com = new SqlCommand("select * from Semt where SemtId = @smtId", con);
                com.Parameters.AddWithValue("@smtId", semtId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    s.SemtAd = dr["SemtAd"].ToString();
                    s.SemtId = Convert.ToInt32(dr["SemtId"]);
                    s.IlceId = Convert.ToInt32(dr["IlceId"]); 
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
        public int semtAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Adres where SemtId=@id", con);
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
