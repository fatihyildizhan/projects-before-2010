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
    public partial class frmOtobusIslem : Form
    {
        public frmOtobusIslem()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("server=.;database=HakikiHakki;uid=sa;pwd=123456fatih");

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand com = new SqlCommand("insert into Otobus values(@kapasite,@plaka,@marka)", con);
                com.Parameters.AddWithValue("@kapasite", Convert.ToInt32(txtKapasite.Text));
                com.Parameters.AddWithValue("@plaka", txtPlaka.Text);
                com.Parameters.AddWithValue("@marka", txtMarka.Text);

                con.Open();

                com.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Otobus Eklendi");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            OtobusGetir();
        }

        private void OtobusGetir()
        {
            listView1.Items.Clear();
            SqlCommand com = new SqlCommand("select * from otobus", con);

            con.Open();

            SqlDataReader dr = com.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem li = new ListViewItem();
                li.Text = dr["Plaka"].ToString();
                li.SubItems.Add(dr["Marka"].ToString());
                li.SubItems.Add(dr["Kapasite"].ToString());

                li.Tag = dr["OtobusId"].ToString();

                listView1.Items.Add(li);
            }

            dr.Close();
            con.Close();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            ListViewItem li = listView1.SelectedItems[0];
            textBox1.Text = li.Tag.ToString();
            txtPlakaGuncelle.Text = li.Text;
            txtMarkaGuncelle.Text = li.SubItems[1].Text;
            txtKapasiteGuncelle.Text = li.SubItems[2].Text;

        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("Delete from otobus where otobusId=@id", con);

            com.Parameters.AddWithValue("@id", Convert.ToInt32(listView1.SelectedItems[0].Tag));

            con.Open();
            com.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Otobus Silindi");

            OtobusGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand("update otobus set kapasite=@kapasite,plaka=@plaka,marka=@marka where otobusId=@id", con);
            com.Parameters.AddWithValue("@kapasite", Convert.ToInt32(txtKapasiteGuncelle.Text));
            com.Parameters.AddWithValue("@plaka", txtPlakaGuncelle.Text);
            com.Parameters.AddWithValue("@marka", txtMarkaGuncelle.Text);
            com.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));

            con.Open();

            com.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Guncellendi");

            OtobusGetir();
        }
    }
}
