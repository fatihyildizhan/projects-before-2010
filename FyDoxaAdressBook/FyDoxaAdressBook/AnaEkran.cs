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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            NewContact nc = new NewContact();
            nc.ShowDialog();            
            showAddedContacts();
        }
        // seçilen contact ı contacts class ındaki list den siler
        private void btnDeleteContact_Click(object sender, EventArgs e)
        {
            if (lstContactName.SelectedItem != null)
            {
                DialogResult dr = MessageBox.Show("Are you sure you want to DELETE this Contact?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Contacts.savedContacts.Remove((Contact)lstContactName.SelectedItem);
                    showAddedContacts();
                    MessageBox.Show("Deleted");
                }
            }
            else
            {
                MessageBox.Show("Please select a Contact!");
            }
        }
        // edit işlemi için oluşturulan contact
        public static Contact editUser;
        public static int index;

        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (lstContactName.SelectedItem != null)
            {
                //int index = Contacts.savedContacts.IndexOf((Contact)lstContactName.SelectedItem);
                //editUser = Contacts.savedContacts[index];

                Contact[] cler = Contacts.savedContacts.ToArray();
                for (int i = 0; i < cler.Length; i++)
                {
                    if (cler[i].ContactId == ((Contact)lstContactName.SelectedItem).ContactId)
                    {
                        editUser = cler[i];
                        index = i;
                    }
                }
                EditContact ec = new EditContact();
                ec.ShowDialog();
                showAddedContacts();
            }
            else
            {
                MessageBox.Show("Please select a Contact!");
            }
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {
            showAddedContacts();
        }
        // güncel contact listesini ana ekranda listeler
        public void showAddedContacts()
        {
            lstContactName.Items.Clear();
            Contact[] c = Contacts.savedContacts.ToArray();

            if (c.Length > 0)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    lstContactName.Items.Add(c[i]);
                }
            }
        }
    }
}
