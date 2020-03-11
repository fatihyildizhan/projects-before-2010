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
    public partial class frmFilmEkle : Form
    {
        public frmFilmEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123456fatih");
        private void button1_Click(object sender, EventArgs e)
        {
            SinemaDAL.Facade.Film.FilmEkle(txtAd.Text,((SinemaDAL.Entity.Kategori)(cmbKategori.SelectedItem)).KategoriId,txtAciklama.Text,Convert.ToInt32(txtSure.Text));   
        }

        private void frmFilmEkle_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select * from kategori", con);
            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();

                cmbKategori.Items.Add(k);
            }
            con.Close();
        }
    }
}
