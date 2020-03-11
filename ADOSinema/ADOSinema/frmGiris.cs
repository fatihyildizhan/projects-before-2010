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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("server=.;database=sinema;uid=sa;pwd=123");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("select count(*) from Kullanici where KullaniciAd=@ad and Sifre=@sifre",con);
            com.Parameters.AddWithValue("@ad", textBox1.Text);
            com.Parameters.AddWithValue("@sifre", textBox2.Text);

            con.Open();

            int sayi = Convert.ToInt32(com.ExecuteScalar());

            con.Close();

            if (sayi > 0)
            {
                Form1 f = new Form1();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı sifre hatalıdır");
            }
        }
    }
}
