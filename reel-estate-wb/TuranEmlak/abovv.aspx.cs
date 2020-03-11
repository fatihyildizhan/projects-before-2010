using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace BussinessLayer
{
    public partial class abovv : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString.ToString());

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                OzellikGetir();
            }
        }

        private void OzellikGetir()
        {
            try
            {
                SqlCommand com = new SqlCommand("select OzellikId, Ozellik from Ozellik", con);
                com.CommandType = CommandType.Text;

                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                List<Ozellik> ozellikler = new List<Ozellik>();
                while (dr.Read())
                {
                    ListItem li = new ListItem(dr["Ozellik"].ToString(), dr["OzellikId"].ToString());
                    CheckBoxList1.Items.Add(li);
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
        }

       

        public string evAraDinamikSorguOlustur(ArrayList gelenOzellikler)
        {
            StringBuilder sorgu = new StringBuilder("select EmlakId, EmlakTuru,EmlakTip , EmlakBoyut from Emlak e, EmlakTip et where e.EmlakTipId = et.EmlakTipId ");

            string kriter = "and EmlakId in (select EmlakId from EmlakOzellik where OzellikId = ";
            foreach (var oz in gelenOzellikler)
            {
                sorgu.AppendLine(kriter + oz + ")");
            }

            return sorgu.ToString();
        }

        protected void btnEvAra_Click(object sender, EventArgs e)
        {
            DbManager dm = new DbManager(false);
            try
            {
                ArrayList ozllklr = new ArrayList();
                foreach (ListItem ozellik in CheckBoxList1.Items)
                {
                    if (ozellik.Selected)
                    {
                        ozllklr.Add(ozellik.Value);
                    }
                }
                DataTable dt = dm.ExecuteDataTable(evAraDinamikSorguOlustur(ozllklr), CommandType.Text);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
    }
}
