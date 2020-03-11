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
    public partial class frmYazarSil : Form
    {
        public frmYazarSil()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        private void frmYazarSil_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        public void ComboDoldur()
        {
            cmbYazarSecyzrSil.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Yazar", con);
            
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Yazar y = new DoxaKutuphaneDAL.Entity.Yazar();
                y.YazarId = Convert.ToInt32(dr["YazarId"]);
                y.Ad = dr["Ad"].ToString();
                y.Soyad = dr["Soyad"].ToString();
                cmbYazarSecyzrSil.Items.Add(y);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.Yazar y = (DoxaKutuphaneDAL.Entity.Yazar)cmbYazarSecyzrSil.SelectedItem;
            bool kontrol = DoxaKutuphaneDAL.Facade.Yazar.YazarSil(y.YazarId);
            if (kontrol)
            {
                MessageBox.Show("Yazar Başarıyla Silinmiştir");
            }
            else
            {
                MessageBox.Show("Yazar Silinemedi!");
            }
            ComboDoldur();
            cmbYazarSecyzrSil.Text = "";
        }
    }
}
