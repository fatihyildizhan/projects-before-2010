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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Students studentsMain = new Students();

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            frmAddStudent fas = new frmAddStudent();
            try
            {
                fas.ShowDialog();
                if (fas.SAddStudent != null)
                { studentsMain.Add(fas.SAddStudent); }
                showStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fas.Dispose();
            }
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                frmAddRelation fad = new frmAddRelation();
                try
                {
                    fad.RelationAdded = lstStudents.SelectedItem as Student;

                    string gndr = (lstStudents.SelectedItem as Student).gender.ToString();
                    foreach (Student std in studentsMain)
                    {
                        if (std.gender.ToString() != gndr)
                        {
                            fad.SList.Add(std);
                        }
                    }
                    
                    fad.ShowDialog();
                    if (fad.RList.Count > 0)
                    { 
                        studentsMain[studentsMain.IndexOf(lstStudents.SelectedItem as Student)].AllRelations = fad.RList;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    fad.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Student to Add Relation!");
            }
        }

        public void showStudents()
        {
            lstStudents.Items.Clear();

            try
            {
                foreach (Student std in studentsMain)
                {
                    lstStudents.Items.Add(std);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lstRelations.Items.Clear();
                foreach (Relation std in ((Student)lstStudents.SelectedItem).AllRelations)
                {
                    lstRelations.Items.Add(std);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
