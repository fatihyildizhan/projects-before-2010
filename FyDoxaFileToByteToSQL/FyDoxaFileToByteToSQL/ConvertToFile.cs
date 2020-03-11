using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FyDoxaFileToByteToSQL
{
    public partial class ConvertToFile : Form
    {
        public ConvertToFile()
        {
            InitializeComponent();
        }
        List<MyFile> myFiles = new List<MyFile>();

        private void button1_Click(object sender, EventArgs e)
        {

            TakeFiles();

            //FileStream fs = new FileStream("C:\\ajaxllooder.gif", FileMode.Create);
            //fs.Write(dizi, 0, dizi.Length);
            //fs.Close();
        }

        private void TakeFiles()
        {
            //uid=username;pwd=userpassword to trusted_connection=true
            SqlConnection con = new SqlConnection("server=.;database=FyDoxaByte;trusted_connection=true");
            try
            {
                SqlCommand com = new SqlCommand("select FileName from MyFiles", con);
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    MyFile mf = new MyFile();
                    //mf.MyFileId = Convert.ToInt32(dr["FileId"]);
                    mf.MyFileName = dr["FileName"].ToString();
                    myFiles.Add(mf);

                    cmbFilesName.Items.Add(mf);
                    cmbFilesName.DisplayMember = mf.MyFileName;
                    cmbFilesName.ValueMember = mf.MyFileId.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An Error Occured: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void ConvertToFile_Load(object sender, EventArgs e)
        {

        }
    }
}
