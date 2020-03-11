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
    public partial class frmKategoriAra : Form
    {
        public frmKategoriAra()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        private void btnKtgrAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("KategoriGetir",con);
            com.CommandType = CommandType.StoredProcedure;

            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = Convert.ToString(dr["KategoriId"]);
                li.SubItems.Add(dr["KategoriAd"].ToString());
                listView1.Items.Add(li);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
        }

    }
}
