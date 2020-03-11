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
    public partial class NewPhones : Form
    {
        public NewPhones()
        {
            InitializeComponent();
        }
       
        // Telefon numarası Ekleme 
        private void btnNewPhones_SaveContact_Click(object sender, EventArgs e)
        {
            if (txtNewPhones.Text != "") // textbox'ın boş olmadığı kontrol edilir
            {
                try
                {
                    Phone newPhone = new Phone();
                    newPhone.PhoneId = Phones.savedPhones.Count + 1;
                    if (rbNewPhones_Home.Checked)
                    {
                        newPhone.PhoneType = EnumPhoneTypes.Home;
                    }
                    else if(rbNewPhones_Work.Checked)
                    {
                        newPhone.PhoneType = EnumPhoneTypes.Work;
                    }
                    else if(rbNewPhones_Hand.Checked)
                    {
                        newPhone.PhoneType = EnumPhoneTypes.Hand;
                    }
                    else if(rbNewPhones_Fax.Checked)
                    {
                        newPhone.PhoneType = EnumPhoneTypes.Fax;
                    }
                    newPhone.PhoneNumber = txtNewPhones.Text;
                    Phones.savedPhones.Add(newPhone); //phones içindeki list e kaydedilir

                    MessageBox.Show("New Phone succesfully created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please write your Phone.");
            }

        }

        private void btnNewPhones_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewPhones_Load(object sender, EventArgs e)
        {

        }
    }
}
