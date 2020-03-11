using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DoxaKutuphane
{
    public partial class frmYayinEviAra : Form
    {
        public frmYayinEviAra()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        private void btnYayinEviListeleAra_Click(object sender, EventArgs e)
        {
 listView1.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);

            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = Convert.ToString(dr["YayinEviId"]);
                li.SubItems.Add(dr["YayinEviAd"].ToString());
                li.SubItems.Add(Convert.ToString(dr["Adres"]));
                li.Tag = dr["YayinEviId"].ToString();
                listView1.Items.Add(li);
            }
            
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }

        private void frmYayinEviAra_Load(object sender, EventArgs e)
        {

        }
    }
}
