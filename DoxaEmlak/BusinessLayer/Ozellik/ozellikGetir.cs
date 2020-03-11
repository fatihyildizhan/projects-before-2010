using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

namespace BusinessLayer
{
    public class ozellikGetir
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());
        public List<ozellik> ozellikGetirTum()
        {
            List<ozellik> ozellikler = new List<ozellik>();
            try
            {
                SqlCommand com = new SqlCommand("select o.OzellikId, o.OzellikTipId,OzellikAd,OzellikTipAd from Ozellik o , OzellikTip ozt where o.OzellikTipId = ozt.OzellikTipId order by OzellikTipId", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ozellik o = new ozellik();
                    o.OzellikAd = dr["OzellikAd"].ToString();
                    o.OzellikId = Convert.ToInt32(dr["OzellikId"]);
                    o.OzellikTipId = Convert.ToInt32(dr["OzellikTipId"]);
                    o.OzellikTipAd = dr["OzellikTipAd"].ToString();
                    ozellikler.Add(o);
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
            return ozellikler;
        }

        public ozellik ozellikGetirId(int ozellikId)
        {
            ozellik o = new ozellik();
            try
            {
                SqlCommand com = new SqlCommand("select o.OzellikId, o.OzellikTipId,OzellikAd,OzellikTipAd from Ozellik o , OzellikTip ozt where o.OzellikTipId = ozt.OzellikTipId and OzellikId = @ozlId", con);
                com.Parameters.AddWithValue("@ozlId", ozellikId);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    o.OzellikAd = dr["OzellikAd"].ToString();
                    o.OzellikId = Convert.ToInt32(dr["OzellikId"]);
                    o.OzellikTipId = Convert.ToInt32(dr["OzellikTipId"]);
                    o.OzellikTipAd = dr["OzellikTipAd"].ToString();
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
            return o;
        }
        public int ozellikAdet(int id)
        {
            int adet = 0;
            try
            {
                SqlCommand com = new SqlCommand("select count(*) from EmlakOzellik where OzellikId=@id", con);
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
