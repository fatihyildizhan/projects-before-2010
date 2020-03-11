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
    public partial class NewAddress : Form
    {
        public NewAddress()
        {
            InitializeComponent();
        }

        private void NewAddress_Load(object sender, EventArgs e)
        {
        }

        private void btnNewAddress_SaveContact_Click(object sender, EventArgs e)
        {
            if (txtNewAddress.Text != "")
            {
                try
                {
                    Address newAddress = new Address();
                    newAddress.AddressId = Addresses.savedAddresses.Count + 1;
                    if (rbNewAddress_Home.Checked)
                    {
                        newAddress.AddressType = EnumAddressTypes.Home;
                    }
                    else
                    {
                        newAddress.AddressType = EnumAddressTypes.Work;
                    }
                    newAddress.Adress = txtNewAddress.Text;
                    Addresses.savedAddresses.Add(newAddress);

                    MessageBox.Show("New Address succesfully created.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please write your address.");
            }
        }

        private void btnNewAddress_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
