using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaRelationShip
{
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Student sAddStudent;

        internal Student SAddStudent
        {
            get { return sAddStudent; }
            set { sAddStudent = value; }
        }


        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtLastname.Text != "")
            {
                try
                {
                    sAddStudent = new Student();
                    sAddStudent.name = txtName.Text;
                    sAddStudent.lastname = txtLastname.Text;
                    sAddStudent.gender = enumGenderTypes.Female;
                    if (rdMale.Checked)
                    { sAddStudent.gender = enumGenderTypes.Male; }

                    MessageBox.Show("Student Added!");

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Complete Information!");
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
