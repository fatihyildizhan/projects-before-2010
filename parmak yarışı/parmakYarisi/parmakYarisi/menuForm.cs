using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ParmakYarisiApiDbLayer;
using ParmakYarisiApiExceptionLayer;

namespace parmakYarisi
{
    public partial class menuForm : Form
    {
        User currentUser;
        UserDetail currentUserDetail;
        UserInfo currentUserInfo;
        public menuForm(User _currentUser, UserDetail _currentUserDetail, UserInfo _currentUserInfo)
        {
            InitializeComponent();
            this.currentUser = _currentUser;
            this.currentUserDetail = _currentUserDetail;
            this.currentUserInfo = _currentUserInfo;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1(currentUser, currentUserDetail, currentUserInfo);
            form.Show();
            this.Dispose();
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            top10Form top10 = new top10Form();
            top10.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
