using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hospital_App_Csharp
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Hospital_DBDataContext db = new Hospital_DBDataContext())
                {
                    Patient newPat = new Patient();
                    newPat.PatientAddress = txtAddress.Text;
                    newPat.PatientBirthDate = dtpDate.Value;
                    newPat.PatientCity = txtCity.Text;
                    newPat.PatientGender = rbMale.Checked;
                    newPat.PatientMarialStatus = rdMarriade.Checked;
                    newPat.PatientName = txtName.Text;
                    newPat.PatientPhone = txtPhone.Text;
                    newPat.PatientSurname = txtSurname.Text;

                    db.Patients.InsertOnSubmit(newPat);
                    db.SubmitChanges();// değişiklikleri kaydeder.
                    MessageBox.Show("Patient Added Successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex.Message);
            }

        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lstPatient.Items.Clear();
            using (Hospital_DBDataContext db = new Hospital_DBDataContext())
            {
                foreach (Patient item in db.Patients.ToList())
                {
                    ListViewItem li = new ListViewItem();
                    li.Tag = item;
                    li.Text = item.PatientName;
                    li.SubItems.Add(item.PatientSurname);
                    li.SubItems.Add(item.PatientPhone);
                    lstPatient.Items.Add(li);
                }
            }
        }

        private void lstPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                Patient newPat = (Patient)((ListView)sender).SelectedItems[0].Tag;
                txtPatientInfoAddress.Text = newPat.PatientAddress;
                txtPatientInfoCity.Text = newPat.PatientCity;
                txtPatientInfoName.Text = newPat.PatientName;
                txtPatientInfoPhone.Text = newPat.PatientPhone;
                txtPatientInfoSurname.Text = newPat.PatientSurname;
                dtpPatientInfoDate.Value = newPat.PatientBirthDate;
                if (newPat.PatientMarialStatus)
                {
                    rbInfoMarriade.Checked = true;
                }
                else
                {
                    rbInfoSingle.Checked = true;
                }

                if (newPat.PatientGender)
                {
                    rbInfoMale.Checked = true;
                }
                else
                {
                    rbInfoFemale.Checked = true;
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
