using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParmakYarisiApiDbLayer;

namespace parmakYarisi
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                pyApiLogin ApiLogin = new pyApiLogin();
                User existUser = ApiLogin.pyLogin(txtEmail.Text, txtPassword.Text);

                if (existUser != null)
                {
                    menuForm menu = new menuForm(existUser, findUserDetails(existUser), findUserInfo(existUser));
                    menu.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect. Please check and try again.");
                }
            }
            catch (Exception ex)
            {
                CatchExLinqToApi.myCatchException(ex, "btnLogin_Click");
            }
        }

        private UserDetail findUserDetails(User myUser)
        {
            pyApiFindUserDetail pafi = new pyApiFindUserDetail();
            return pafi.ApiFindUserDetail(myUser);
        }

        private UserInfo findUserInfo(User myUser)
        {
            pyApiGenerateUserInfo pa = new pyApiGenerateUserInfo();
            return pa.ApiGenerateUserInfo(myUser);
        }

        private void btnCreate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            createAccount createAccForm = new createAccount();
            createAccForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}