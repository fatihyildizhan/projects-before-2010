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
    public partial class frmYazarGuncelle : Form
    {
        public frmYazarGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");
        SqlDataAdapter da;
        DataTable dt;
        private void btnYazarListeleGunc_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from Yazar",con);
            da = new SqlDataAdapter(com);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
