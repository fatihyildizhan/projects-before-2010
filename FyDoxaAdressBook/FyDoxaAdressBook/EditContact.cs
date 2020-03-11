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
    public partial class EditContact : Form
    {
        public EditContact()
        {
            InitializeComponent();
        }
        // Adres düzenle
        private void btnEditContact_AddressesAdd_Click(object sender, EventArgs e)
        {
            NewAddress na = new NewAddress();
            na.ShowDialog();
            showEditedAddresses();
        }

        // Email düzenle
        private void btnEditContact_EmailsAdd_Click(object sender, EventArgs e)
        {
            NewEmails ne = new NewEmails();
            ne.ShowDialog();
            showEditedEmails();
        }

        // Telefon numarası düzenle
        private void btnEditContact_PhonesAdd_Click(object sender, EventArgs e)
        {
            NewPhones np = new NewPhones();
            np.ShowDialog();
            showEditedPhones();
        }

        // edit penceresinde kullanılmak üzere oluşturulan contact
        //public Contact editedUser = AnaEkran.editUser;

        private void EditContact_Load(object sender, EventArgs e)
        {
            txtEditContact_ContactName.Text = AnaEkran.editUser.ContactName;
            showEditedAddresses();
            showEditedPhones();
            showEditedEmails();
        }
        // adreslesi listele
        public void showEditedAddresses()
        {
            lstEditContact_Addresses.Items.Clear();
            Address[] editedAddresses = AnaEkran.editUser.Addresses.ToArray();
            if (editedAddresses.Length > 0)
            {
                for (int i = 0; i < editedAddresses.Length; i++)
                {
                    lstEditContact_Addresses.Items.Add(editedAddresses[i]);
                }
            }  
        }
        // telefon numaralarını listele
        public void showEditedPhones()
        {
            lstEditContact_Phones.Items.Clear();
            Phone[] editedPhones = AnaEkran.editUser.Phones.ToArray();
            if (editedPhones.Length > 0)
            {
                for (int i = 0; i < editedPhones.Length; i++)
                {
                    lstEditContact_Phones.Items.Add(editedPhones[i]);
                }
            }
        }
        // email adreslerini listele
        public void showEditedEmails()
        {
            lstEditContact_Emails.Items.Clear();
            Email[] editedEmails = AnaEkran.editUser.Emails.ToArray();
            if (editedEmails.Length > 0)
            {
                for (int i = 0; i < editedEmails.Length; i++)
                {
                    lstEditContact_Emails.Items.Add(editedEmails[i]);
                }
            }
        }

        private void btnEditContact_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Güncel halini kaydet
        
        private void btnEditContact_SaveContact_Click(object sender, EventArgs e)
        {
                try
                {
                    Contact c = new Contact();
                    c.Addresses = Addresses.savedAddresses;
                    c.Emails = Emails.savedEmails;
                    c.Phones = Phones.savedPhones;
                    c.ContactName = txtEditContact_ContactName.Text;
                    c.ContactId = Contacts.savedContacts.Count + 1;
                    Contacts.savedContacts[AnaEkran.index] = c; // yeni kayıt eklenir
                    MessageBox.Show("Contact Updated!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            
        }
        // seçilen adress silinir
        private void btnEditContact_AddressesDelete_Click(object sender, EventArgs e)
        {
            if (lstEditContact_Addresses.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this Address?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Addresses.savedAddresses.Remove((Address)lstEditContact_Addresses.SelectedItem);
                    showEditedAddresses();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select an Address");
            }
        }

        // seçilen telefon numarası silinir
        private void btnEditContact_PhonesDelete_Click(object sender, EventArgs e)
        {
            if (lstEditContact_Phones.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this Phone Number?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Phones.savedPhones.Remove((Phone)lstEditContact_Phones.SelectedItem);
                    showEditedPhones();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a Phone Number!");
            }
        }

        // seçilen email adresi silinir
        private void btnEditContact_EmailsDelete_Click(object sender, EventArgs e)
        {
            if (lstEditContact_Emails.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this E-mail?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Emails.savedEmails.Remove((Email)lstEditContact_Emails.SelectedItem);
                    showEditedEmails();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select an E-mail");
            }
        }
    }
}
