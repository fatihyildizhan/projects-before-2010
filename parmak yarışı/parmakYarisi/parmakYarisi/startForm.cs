using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace parmakYarisi
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void startForm_Load(object sender, EventArgs e)
        {
            timerStart.Enabled = true;
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            updateTime();
        }

        private void updateTime()
        {
            if (lblTime.Text.Equals("2"))
            {
                imgTraffic.Image = parmakYarisi.Properties.Resources.yellow;
            }
            else if (lblTime.Text.Equals("0"))
            {
                imgTraffic.Image = parmakYarisi.Properties.Resources.green;
            }
            if (lblTime.Text.Equals("GO!"))
            {
                timerStart.Enabled = false;
                this.Dispose();
                return;
            }
            else if (!lblTime.Text.Equals("0"))
            {
                lblTime.Text = ((Convert.ToInt32(lblTime.Text)) - 1).ToString();
                return;
            }
            else
            {
                lblTime.Text = "GO!";
            }
            
        }
    }
}
