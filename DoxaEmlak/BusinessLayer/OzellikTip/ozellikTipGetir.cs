using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class ozellikTipGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<ozellikTip> ozellikTipGetirTum()
        {
            List<ozellikTip> ozellikTipler = new List<ozellikTip>();
            try
            {
                SqlCommand com = new SqlCommand("select * from OzellikTip", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ozellikTip otp = new ozellikTip();
                    otp.OzellikTipAd = dr["OzellikTipAd"].ToString();
                    otp.OzellikTipId = Convert.ToInt32(dr["OzellikTipId"]);
                    ozellikTipler.Add(otp);
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
            return ozellikTipler;
        }

        public ozellikTip ozellikTipGetirId(int ozellikTipId)
        {
            ozellikTip otp = new ozellikTip();
            try
            {
                SqlCommand com = new SqlCommand("select * from OzellikTip where OzellikTipId = @ozlTipId", con);
                com.Parameters.AddWithValue("@ozlTipId", ozellikTipId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    otp.OzellikTipAd = dr["OzellikTipAd"].ToString();
                    otp.OzellikTipId = Convert.ToInt32(dr["OzellikTipId"]);
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
            return otp;
        }
        public int ozellikTipAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from Ozellik where OzellikTipId=@id", con);
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
