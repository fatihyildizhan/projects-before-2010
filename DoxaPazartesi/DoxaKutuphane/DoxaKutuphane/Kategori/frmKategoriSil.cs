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
    public partial class frmKategoriSil : Form
    {
        public frmKategoriSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true");

        public void ComboDoldur()
        {
            cmbKtgrSil.Items.Clear();
            SqlCommand com = new SqlCommand("KategoriGetir", con);
            com.CommandType = CommandType.StoredProcedure;

            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Kategori k = new DoxaKutuphaneDAL.Entity.Kategori();
                k.KategoriId=Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd=dr["KategoriAd"].ToString();
                cmbKtgrSil.Items.Add(k);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        private void frmKategoriSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.Kategori k = (DoxaKutuphaneDAL.Entity.Kategori)cmbKtgrSil.SelectedItem;

            DoxaKutuphaneDAL.Facade.Kategori.KategoriSil(k.KategoriId);
            
            ComboDoldur();
            cmbKtgrSil.Text = "";
        }
        
    }
}
