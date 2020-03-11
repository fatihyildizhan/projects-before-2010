using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace ADOSinema
{
    public partial class frmFilmSil : Form
    {
        public frmFilmSil()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=Sinema;trusted_connection=true");
        private void frmFilmSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();   
        }
        public void ComboDoldur()
        {

            cmbFilmSil.Items.Clear();

            SqlCommand com = new SqlCommand("select * from Film ",con);
            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
               SinemaDAL.Entity.Film f = new SinemaDAL.Entity.Film();
                f.FilmId = Convert.ToInt32(dr["FilmId"]);
                f.FilmAd = dr["FilmAd"].ToString();

                cmbFilmSil.Items.Add(f);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("prc_FilmSil",con);
            com.CommandType = CommandType.StoredProcedure;

            SinemaDAL.Entity.Film f = (SinemaDAL.Entity.Film)cmbFilmSil.SelectedItem;

            com.Parameters.AddWithValue("@FilmId", f.FilmId);

            con.Open();

            com.ExecuteNonQuery();

            con.Close();


            MessageBox.Show("Film Silindi");

            ComboDoldur();
        }
    }
}
