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
    public partial class frmFilmAra : Form
    {
        public frmFilmAra()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123456fatih");
        private void btnFilmAra_Click(object sender, EventArgs e)
        {
            if (chkKategoriAd.Checked)
            {     
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("FilmAraKategori", con);            
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@KategoriId", ((SinemaDAL.Entity.Kategori)cmbKategoriAra.SelectedItem).KategoriId);

           con.Open();

            SqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();
                li.SubItems.Add(k.KategoriAd);

                SinemaDAL.Entity.Film f = new SinemaDAL.Entity.Film();
                f.FilmAd = dr["FilmAd"].ToString();
                f.FilmAciklama = dr["Aciklama"].ToString();
                f.Sure=Convert.ToInt32(dr["Sure"]);
                li.SubItems.Add(f.FilmAciklama);
                li.SubItems.Add(f.Sure.ToString());
                li.Tag = dr["FilmId"].ToString();
                li.Text = f.FilmAd;
                listView1.Items.Add(li);
            }
            con.Close();
            }
            else if (chkFilmAd.Checked)
            {
                
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("FilmAraAd", con);            
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@FilmAd", txtFilmAdiAra.Text);

           con.Open();

            SqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();
                li.SubItems.Add(k.KategoriAd);

                SinemaDAL.Entity.Film f = new SinemaDAL.Entity.Film();
                f.FilmAd = dr["FilmAd"].ToString();
                f.FilmAciklama = dr["Aciklama"].ToString();
                f.Sure=Convert.ToInt32(dr["Sure"]);
                li.SubItems.Add(f.FilmAciklama);
                li.SubItems.Add(f.Sure.ToString());
                li.Tag = dr["FilmId"].ToString();
                li.Text = f.FilmAd;
                listView1.Items.Add(li);
            }
            con.Close();
            }
            else if (chkFilmSure.Checked)
            {
                
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("FilmAraSure", con);            
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Sure", txtFilmSuresiAra.Text);

           con.Open();

            SqlDataReader dr = com.ExecuteReader();
            
            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();
                li.SubItems.Add(k.KategoriAd);
                

                SinemaDAL.Entity.Film f = new SinemaDAL.Entity.Film();
                f.FilmAd = dr["FilmAd"].ToString();
                f.FilmAciklama = dr["Aciklama"].ToString();
                f.Sure=Convert.ToInt32(dr["Sure"]);
                li.SubItems.Add(f.FilmAciklama);
                li.SubItems.Add(f.Sure.ToString());
                li.Tag = dr["FilmId"].ToString();
                li.Text = f.FilmAd;
                listView1.Items.Add(li);
            }
            con.Close();
            }
        }
         public void ComboDoldur()
        {
            cmbKategoriAra.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Kategori", con);
            con.Open();

            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                SinemaDAL.Entity.Kategori k = new SinemaDAL.Entity.Kategori();
                k.KategoriId = Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd = dr["KategoriAd"].ToString();
                cmbKategoriAra.Items.Add(k);
                cmbKategoriGunc.Items.Add(k);
            }

            con.Close();
        }

         private void frmFilmAra_Load(object sender, EventArgs e)
         {
              ComboDoldur();
         }

         private void listView1_Click(object sender, EventArgs e)
         {
            ListViewItem li = listView1.SelectedItems[0];
           
            txtFilmAdGunc.Text = li.Text;
            cmbKategoriGunc.Text = li.SubItems[1].Text;
            txtFilmSureGunc.Text = li.SubItems[3].Text;
            txtAciklamaGunc.Text=li.SubItems[2].Text;
            txtFilmIdGunc.Text = li.Tag.ToString();
         }

         private void btnFilmGuncelle_Click(object sender, EventArgs e)
         {
             SinemaDAL.Facade.Film.FilmGuncelle(Convert.ToInt32(txtFilmIdGunc.Text), txtFilmAdGunc.Text,((SinemaDAL.Entity.Kategori)cmbKategoriGunc.SelectedItem).KategoriId, txtAciklamaGunc.Text, Convert.ToInt32(txtFilmSureGunc.Text));
         }

         
    }
}
