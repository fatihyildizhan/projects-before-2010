using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniOtobus
{
    public partial class frmSeferIslem : Form
    {
        public frmSeferIslem()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=HakikiHakki;uid=sa;pwd=123456fatih");

        private void frmSeferIslem_Load(object sender, EventArgs e)
        {
            SehirGetir();

            SqlCommand com = new SqlCommand("select * from otobus", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Otobus o = new Otobus();
                o.OtobusId = Convert.ToInt32(dr["OtobusId"]);
                o.Plaka = dr["Plaka"].ToString();
                o.Marka = dr["Marka"].ToString();
                o.Kapasite = Convert.ToInt32(dr["Kapasite"]);

                comboBox3.Items.Add(o);
              
            }

            dr.Close();
            con.Close();




        }

        private void SehirGetir()
        {
            SqlCommand com = new SqlCommand("select * from sehir", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                Sehir s = new Sehir();
                s.SehirId = Convert.ToInt32(dr["SehirId"]);
                s.SehirAd = dr["SehirAd"].ToString();

                comboBox1.Items.Add(s);
                comboBox2.Items.Add(s);
            }

            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SeferEkle", con);
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@Kalkis", ((Sehir)comboBox1.SelectedItem).SehirId);
            com.Parameters.AddWithValue("@Varis", ((Sehir)comboBox2.SelectedItem).SehirId);
            com.Parameters.AddWithValue("@Tarih", dateTimePicker1.Value);
            com.Parameters.AddWithValue("@Saat", textBox1.Text);
            com.Parameters.AddWithValue("@OtobusId", ((Otobus)comboBox3.SelectedItem).OtobusId);

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("SeferGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                MessageBox.Show(dr["plaka"].ToString());
            }
            con.Close();

        }
    }
}
