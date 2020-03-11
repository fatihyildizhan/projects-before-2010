using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FyDoxaAdressBook
{
    public partial class NewEmails : Form
    {
        public NewEmails()
        {
            InitializeComponent();
        }
        //Yeni email adresi kaydedilir
        private void btnNewEmails_SaveContact_Click(object sender, EventArgs e)
        {
            if (txtNewEmails.Text != "")
            {
                try
                {
                    Email newEmails = new Email();
                    newEmails.EmailId = Emails.savedEmails.Count + 1;
                    if (rbNewEmails_Work.Checked)
                    {
                        newEmails.EmailType = EnumEmailTypes.Work;
                    }
                    else
                    {
                        newEmails.EmailType = EnumEmailTypes.Special;
                    }
                    
                    newEmails.EmailAddress = txtNewEmails.Text;
                    Emails.savedEmails.Add(newEmails); //emails içindeki list e kaydedilir

                    MessageBox.Show("New Email succesfully created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please write your Email.");
            }

        
        }

        private void btnNewEmails_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewEmails_Load(object sender, EventArgs e)
        {

        }
    }
}
