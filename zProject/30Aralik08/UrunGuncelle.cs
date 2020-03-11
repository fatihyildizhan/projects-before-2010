using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _30Aralik08
{
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        Product gelenUrun;

        public UrunGuncelle(Product prd )
        {
            gelenUrun = prd;
            InitializeComponent();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {

            cbCategoryName.DataSource = Category.GetAllCategories();
            cbCategoryName.ValueMember = "CategoryID";
            cbCategoryName.DisplayMember = "categoryAdi";
            DegerleriAyarla();

        }

        private void DegerleriAyarla()
        {
            txtID.Text = gelenUrun.ProductID.ToString();
            txtPrice.Text = gelenUrun.Price.ToString();
            txtProductDesc.Text = gelenUrun.ProductDesc;
            txtProductName.Text = gelenUrun.ProductName;
            cbCategoryName.SelectedValue = gelenUrun.CategID;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Server = .; Database = DoxaBilgisayar; trusted_Connection = Yes");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateProduct";
            cmd.Parameters.AddWithValue("@ProductID",txtID.Text);
            cmd.Parameters.AddWithValue("@ProductName",txtProductName.Text);
            cmd.Parameters.AddWithValue("@ProductDesc",txtProductDesc.Text);
            cmd.Parameters.AddWithValue("@Price",Convert.ToDecimal(txtPrice.Text));
            cmd.Parameters.AddWithValue("@CategoryID",cbCategoryName.SelectedValue);
            int Sonuc= cmd.ExecuteNonQuery();
            if (Sonuc > 0)
            {
                MessageBox.Show("işlem başarıyla tamamlandı.\n Teşekkürler","Sonuc",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("işlem başarısız. \n Tekrar Deneyin", "Sonuc", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
