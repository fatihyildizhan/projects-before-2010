using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FyDoxaFileToByteToSQL
{
    public partial class ConvertToByte : Form
    {
        public ConvertToByte()
        {
            InitializeComponent();
        }
        byte[] dizi;
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                txtFileName.Text = openFileDialog1.SafeFileName;
                txtSaveTo.Text = "FyDoxaByte >> Files";
                try
                {
                FileStream fs = new FileStream(openFileDialog1.SafeFileName, FileMode.Open);

                dizi = new byte[fs.Length];

                fs.Read(dizi, 0, dizi.Length);
                fs.Close();

                MessageBox.Show("File Opened Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An Error Occured: " + ex.Message);
                }
            }
        }

        private void btnSaveToSql_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("server=.;Database=FyDoxaByte;trusted_connection=true;");
                SqlCommand com = new SqlCommand("insert into MyFiles values(@FileName,@File)", con);
                com.Parameters.AddWithValue("@FileName", txtFileName.Text);
                com.Parameters.AddWithValue("@File", dizi);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("File Saved Successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Occured Error: " + ex.Message);
            }
        }
    }
}
