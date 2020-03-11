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
    public partial class NewContact : Form
    {
        public NewContact()
        {
            InitializeComponent();
        }
        // Yeni adress ekleme penceresini açar 
        // pencere kapandıktan sonra güncel halini ekranda listeler
        private void btnAddressesAdd_Click(object sender, EventArgs e)
        {
            NewAddress na = new NewAddress();
            na.ShowDialog();
            showAddedAddresses();
        }
        
        private void NewContact_Load(object sender, EventArgs e)
        {
        }
        // güncel adres listesini gösterir
        public void showAddedAddresses()
        {
            lstNewContact_Addresses.Items.Clear();
                
            Address[] addedAddresses = Addresses.savedAddresses.ToArray();
            if (addedAddresses.Length > 0)
            {
                for (int i = 0; i < addedAddresses.Length; i++)
                {
                    lstNewContact_Addresses.Items.Add(addedAddresses[i]);
                }
            }
        }
        //güncel telefon numaralarını gösterir
        public void showAddedPhones()
        {
            lstNewContact_Phones.Items.Clear();
            Phone[] addedPhones = Phones.savedPhones.ToArray();
            if (addedPhones.Length > 0)
            {
                for (int i = 0; i < addedPhones.Length; i++)
                {
                    lstNewContact_Phones.Items.Add(addedPhones[i]);
                }
            }
        }
        // Seçilen adresi addresses içindeki list den siler
        private void btnNewContact_AddressesDelete_Click(object sender, EventArgs e)
        {
            if (lstNewContact_Addresses.SelectedItem !=null) // seçili adresin olduğu kontrol edilir
            {
               DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this Address?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (dr == DialogResult.Yes)
               {
                   Addresses.savedAddresses.Remove((Address)lstNewContact_Addresses.SelectedItem);
                   showAddedAddresses(); // silme işleminden sonra güncel liste gösterilir
                   MessageBox.Show("Deleted");
               }                
            }
            else
            {
                MessageBox.Show("Please select an Address");
            }
        }
        // yeni telefon numarası ekleme penceresi açılır
        // işlem sonrası güncel liste gösterilir
        private void btnNewContact_PhonesAdd_Click(object sender, EventArgs e)
        {
            NewPhones np = new NewPhones();
            np.ShowDialog();
            showAddedPhones();
        }

        //formun kapanma eventi
        private void btnNewContact_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // yeni email adresi ekleme penceresi
        // sonrasında güncel email listesi gösterilir
        private void btnNewContact_EmailsAdd_Click(object sender, EventArgs e)
        {
            NewEmails ne = new NewEmails();
            ne.ShowDialog();
            showAddedEmails();
            
        }
        // güncel email listesini gösteren method
        public void showAddedEmails()
        {
            lstNewContact_Emails.Items.Clear();

            Email[] addedEmails = Emails.savedEmails.ToArray();
            if (addedEmails.Length > 0)
            {
                for (int i = 0; i < addedEmails.Length; i++)
                {
                    lstNewContact_Emails.Items.Add(addedEmails[i]);
                }
            }
        }
        // seçilen email adresini emails class ındaki list den siler
        // sonrasında güncel halini listeler
        private void btnNewContact_EmailsDelete_Click(object sender, EventArgs e)
        {
            if (lstNewContact_Emails.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this E-mail?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Emails.savedEmails.Remove((Email)lstNewContact_Emails.SelectedItem);
                    showAddedEmails();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select an E-mail");
            }
        }

        // oluşturulan New Contact ı contacts class ındaki liste kaydeder
        
        private void btnNewContact_SaveContact_Click(object sender, EventArgs e)
        {
            // gerekli görülürse bilgilerin boş geçilip geçilmeyeği kontrol edilir

            //if (txtNewContact_ContactName.Text != "" && Addresses.savedAddresses.Count > 0 && Emails.savedEmails.Count > 0 && Phones.savedPhones.Count > 0)
            //{
                try
                {
                    Contact c = new Contact();
                    c.Addresses = Addresses.savedAddresses;
                    c.Emails = Emails.savedEmails;
                    c.Phones = Phones.savedPhones;
                    c.ContactName = txtNewContact_ContactName.Text;
                    c.ContactId = Contacts.savedContacts.Count + 1;

                    Contacts.savedContacts.Add(c);
                    MessageBox.Show("Contact Created!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: "+ex.Message);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Please complete your information!");
            //}
        }

        // seçilen telefon numarasının phones class ındaki list den silinmesi
        // sonrasında güncel listenin gösterilmesi
        private void btnNewContact_PhonesDelete_Click(object sender, EventArgs e)
        {
            if (lstNewContact_Phones.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this Phone Number?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Phones.savedPhones.Remove((Phone)lstNewContact_Phones.SelectedItem);
                    showAddedPhones();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a Phone Number!");
            }
        }

    }
}
