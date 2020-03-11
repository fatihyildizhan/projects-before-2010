using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class isitmaTipGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<isitmaTip> isitmaTipGetirTum()
        {
            List<isitmaTip> isTipler = new List<isitmaTip>();
            try
            {
                SqlCommand com = new SqlCommand("select * from IsitmaTip  order by IsitmaTipAd", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    isitmaTip itp = new isitmaTip();
                    itp.IsitmaTipAd = dr["IsitmaTipAd"].ToString();
                    itp.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
                    isTipler.Add(itp);
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
            return isTipler;
        }

        public isitmaTip isitmaTipGetirId(int isTipId)
        {
            isitmaTip itp = new isitmaTip();
            try
            {
                SqlCommand com = new SqlCommand("select * from IsitmaTip where IsitmaTipId = @isitmaTipId", con);
                com.Parameters.AddWithValue("@isitmaTipId", isTipId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    itp.IsitmaTipAd = dr["IsitmaTipAd"].ToString();
                    itp.IsitmaTipId = Convert.ToInt32(dr["IsitmaTipId"]);
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
            return itp;
        }
        public int isitmaTipAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Emlak where IsitmaTipId=@id", con);
                com.CommandType = CommandType.Text;
                com.Parameters.AddWithValue("@id",id);

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
