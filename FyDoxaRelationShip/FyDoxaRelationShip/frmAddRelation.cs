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
    public partial class frmAddRelation : Form
    {
        public frmAddRelation()
        {
            InitializeComponent();
        }

        private void frmAddRelation_Load(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Text = relationAdded.ToString();
                foreach (Student std in SList)
                {
                    lstStudents.Items.Add(std);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Student
        private Student relationAdded = new Student();

        internal Student RelationAdded
        {
            get { return relationAdded; }
            set { relationAdded = value; }
        }

        // Students
        private Students sList = new Students();

        internal Students SList
        {
            get { return sList; }
            set { sList = value; }
        }

        // Relations
        private Relations rList = new Relations();

        internal Relations RList
        {
            get { return rList; }
            set { rList = value; }
        }

        private Relation rAddRelation;

        internal Relation RAddRelation
        {
            get { return rAddRelation; }
            set { rAddRelation = value; }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                try
                {
                    rAddRelation = new Relation();

                    RAddRelation.studentInfo = (lstStudents.SelectedItems[0] as Student).ToString();

                    rList.Add(rAddRelation);

                    Relation r = new Relation();
                    r.studentInfo = relationAdded.ToString();

                    sList[sList.IndexOf(lstStudents.SelectedItem as Student)].AllRelations.Add(r);
                  
                    removeStudentFromScreen();

                    MessageBox.Show("Relation Added!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select a Student!");
            }
        }

        public void removeStudentFromScreen()
        {
            lstStudents.Items.Remove(lstStudents.SelectedItem);
        }
    }
}
