using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOSinema
{
    public partial class frmKategoriSil : Form
    {
        public frmKategoriSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=sinema;trusted_connection=true");

        private void frmKategoriSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        public void ComboDoldur()
        {

            comboBox1.Items.Clear();

            SqlCommand com = new SqlCommand("select * from kategori ",con);
            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
               SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();

                comboBox1.Items.Add(k);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("KategoriSil",con);
            com.CommandType = CommandType.StoredProcedure;

            SinemaDAL.Entity.Kategori k = (SinemaDAL.Entity.Kategori)comboBox1.SelectedItem;

            com.Parameters.AddWithValue("@id", k.KategoriId);

            con.Open();

            com.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("Kategori Silindi");

            ComboDoldur();
        }
    }
}
