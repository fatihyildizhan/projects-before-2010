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
    public partial class frmKategoriEkle : Form
    {
        public frmKategoriEkle()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=sinema;trusted_connection=true");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("insert into Kategori values(@ad)",con);
            com.Parameters.AddWithValue("@ad", txtKategoriEkle.Text);
            
            
            con.Open();
                com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kategori Eklenmiştir");
           
        }

        private void frmKategoriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
