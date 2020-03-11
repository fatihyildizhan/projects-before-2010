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
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.;database=DoxaKutuphane;trusted_connection=true;");
        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            KategoriDoldur();
            YayinEviDoldur();
            YazarDoldur();
        }
        public void KategoriDoldur()
        {
            cmbKtgrAdEkleKtp.Items.Clear();
            SqlCommand com = new SqlCommand("KategoriGetir", con);
            com.CommandType = CommandType.StoredProcedure;
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Kategori k = new DoxaKutuphaneDAL.Entity.Kategori();
                k.KategoriId=Convert.ToInt32(dr["KategoriId"]);
                k.KategoriAd=dr["KategoriAd"].ToString();
                cmbKtgrAdEkleKtp.Items.Add(k);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        public void YayinEviDoldur()
        {
            cmbYynEvAdEkleKtp.Items.Clear();
            SqlCommand com = new SqlCommand("select * from YayinEvi",con);
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.YayinEvi y = new DoxaKutuphaneDAL.Entity.YayinEvi();
                y.YayinEviId = Convert.ToInt32(dr["YayinEviId"]);
                y.YayinEviAd = dr["YayinEviAd"].ToString();
                y.YayinEviAdres=Convert.ToString(dr["Adres"]);
                cmbYynEvAdEkleKtp.Items.Add(y);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        public void YazarDoldur()
        {
            cmbYzrAdEkleKtp.Items.Clear();
            SqlCommand com = new SqlCommand("select * from Yazar", con); 
            DoxaMethodsDAL.Facade.Connection.ConOpen(con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DoxaKutuphaneDAL.Entity.Yazar y = new DoxaKutuphaneDAL.Entity.Yazar();
                y.YazarId = Convert.ToInt32(dr["YazarId"]);
                y.Ad = dr["Ad"].ToString();
                y.Soyad = dr["Soyad"].ToString();
                cmbYzrAdEkleKtp.Items.Add(y);
            }
            DoxaMethodsDAL.Facade.Connection.ConClose(con);
            dr.Close();
        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            DoxaKutuphaneDAL.Entity.Kategori k = (DoxaKutuphaneDAL.Entity.Kategori)cmbKtgrAdEkleKtp.SelectedItem;
            DoxaKutuphaneDAL.Entity.YayinEvi yyn = (DoxaKutuphaneDAL.Entity.YayinEvi)cmbYynEvAdEkleKtp.SelectedItem;
            DoxaKutuphaneDAL.Entity.Yazar yzr = (DoxaKutuphaneDAL.Entity.Yazar)cmbYzrAdEkleKtp.SelectedItem;
            bool kontrol = DoxaKutuphaneDAL.Facade.Kitap.KitapEkle(txtKitapAdEkle.Text, k.KategoriId, yzr.YazarId, yyn.YayinEviId);
            if (kontrol)
            {
                MessageBox.Show("Mission is successful!");
            }
            else
            {
                MessageBox.Show("There is a Problem!");
            }
        }
    }
}
