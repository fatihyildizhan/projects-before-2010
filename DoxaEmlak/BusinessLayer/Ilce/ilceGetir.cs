using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class ilceGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<ilce> ilceGetirTum()
        {
            List<ilce> ilceler = new List<ilce>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Ilce  order by IlceAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ilce i = new ilce();
                    i.IlceId = Convert.ToInt32(dr["IlceId"]);
                    i.IlceAd = dr["IlceAd"].ToString();
                    i.SehirId = Convert.ToInt32(dr["SehirId"]);
                    ilceler.Add(i);
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
            return ilceler;
        }
        public List<ilce> ilceGetirSehirId(int sehirId)
        {
            List<ilce> ilceler = new List<ilce>();
            try
            {
                SqlCommand com = new SqlCommand("select * from Ilce where SehirId=@shrId  order by IlceAd", con);
                com.Parameters.AddWithValue("@shrId",sehirId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ilce i = new ilce();
                    i.IlceId = Convert.ToInt32(dr["IlceId"]);
                    i.IlceAd = dr["IlceAd"].ToString();
                    i.SehirId = Convert.ToInt32(dr["SehirId"]);
                    ilceler.Add(i);
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
            return ilceler;
        }
        public ilce ilceGetirId(int ilceId)
        {
            ilce i = new ilce();
            try
            {
                SqlCommand com = new SqlCommand("select * from Ilce where IlceId = @ilceId", con);
                com.Parameters.AddWithValue("@ilceId", ilceId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    i.IlceId = Convert.ToInt32(dr["IlceId"]);
                    i.IlceAd = dr["IlceAd"].ToString();
                    i.SehirId = Convert.ToInt32(dr["SehirId"]);
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
            return i;
        }
        public int ilceAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Adres where IlceId=@id", con);
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
