using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using ParmakYarisiApiDbLayer;
using ParmakYarisiApiExceptionLayer;

namespace parmakYarisi
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }
        pyApiCreateUser ApiCreateUser = new pyApiCreateUser();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (isAnyEmptyField() && isPasswordConfirmed()) createAcc();
        }

        private Boolean isAnyEmptyField()
        {
            return (rbMale.Checked || rbFemale.Checked) && !txtName.Text.Equals(String.Empty) && !txtSurname.Text.Equals(String.Empty) && !txtNickname.Text.Equals(string.Empty) && !txtEmail.Text.Equals(String.Empty) && !txtPassword.Text.Equals(String.Empty) && !txtConfirmPassword.Text.Equals(String.Empty);
        }

        private Boolean isPasswordConfirmed()
        {
            return txtPassword.Text.Equals(txtConfirmPassword.Text);
        }

        private void createAcc()
        {
            try
            {
                Boolean _gender;
                if (rbMale.Checked) _gender = true;
                else _gender = false;

                User newUser = new User();
                newUser.UserID = Guid.NewGuid();
                newUser.UserName = txtName.Text;
                newUser.UserSurname = txtSurname.Text;
                newUser.UserGender = _gender;
                newUser.UserBirthDate = dateBirthdate.Value;
                newUser.UserNickname = txtNickname.Text;
                newUser.UserEmail = txtEmail.Text;
                newUser.UserPassword = txtPassword.Text;
                newUser.UserCreationDate = DateTime.Now;

                int result = ApiCreateUser.pyCreateUser(newUser);
                if (result == 1)
                {
                    MessageBox.Show("Account created. You can Login now.");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Please try again!");
                }

            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "createAcc");
            }
        }
    }
}
