namespace FyDoxaAdressBook
{
    partial class NewContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewContact_ContactName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewContact_AddressesAdd = new System.Windows.Forms.Button();
            this.btnNewContact_AddressesDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewContact_PhonesDelete = new System.Windows.Forms.Button();
            this.btnNewContact_PhonesAdd = new System.Windows.Forms.Button();
            this.btnNewContact_EmailsDelete = new System.Windows.Forms.Button();
            this.btnNewContact_EmailsAdd = new System.Windows.Forms.Button();
            this.btnNewContact_Exit = new System.Windows.Forms.Button();
            this.btnNewContact_SaveContact = new System.Windows.Forms.Button();
            this.lstNewContact_Addresses = new System.Windows.Forms.ListBox();
            this.lstNewContact_Phones = new System.Windows.Forms.ListBox();
            this.lstNewContact_Emails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNewContact_ContactName
            // 
            this.txtNewContact_ContactName.Location = new System.Drawing.Point(108, 17);
            this.txtNewContact_ContactName.Name = "txtNewContact_ContactName";
            this.txtNewContact_ContactName.Size = new System.Drawing.Size(363, 20);
            this.txtNewContact_ContactName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contact Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Addresses";
            // 
            // btnNewContact_AddressesAdd
            // 
            this.btnNewContact_AddressesAdd.Location = new System.Drawing.Point(358, 201);
            this.btnNewContact_AddressesAdd.Name = "btnNewContact_AddressesAdd";
            this.btnNewContact_AddressesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_AddressesAdd.TabIndex = 6;
            this.btnNewContact_AddressesAdd.Text = "Add";
            this.btnNewContact_AddressesAdd.UseVisualStyleBackColor = true;
            this.btnNewContact_AddressesAdd.Click += new System.EventHandler(this.btnAddressesAdd_Click);
            // 
            // btnNewContact_AddressesDelete
            // 
            this.btnNewContact_AddressesDelete.Location = new System.Drawing.Point(439, 201);
            this.btnNewContact_AddressesDelete.Name = "btnNewContact_AddressesDelete";
            this.btnNewContact_AddressesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_AddressesDelete.TabIndex = 7;
            this.btnNewContact_AddressesDelete.Text = "Delete";
            this.btnNewContact_AddressesDelete.UseVisualStyleBackColor = true;
            this.btnNewContact_AddressesDelete.Click += new System.EventHandler(this.btnNewContact_AddressesDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Emails";
            // 
            // btnNewContact_PhonesDelete
            // 
            this.btnNewContact_PhonesDelete.Location = new System.Drawing.Point(96, 395);
            this.btnNewContact_PhonesDelete.Name = "btnNewContact_PhonesDelete";
            this.btnNewContact_PhonesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_PhonesDelete.TabIndex = 13;
            this.btnNewContact_PhonesDelete.Text = "Delete";
            this.btnNewContact_PhonesDelete.UseVisualStyleBackColor = true;
            this.btnNewContact_PhonesDelete.Click += new System.EventHandler(this.btnNewContact_PhonesDelete_Click);
            // 
            // btnNewContact_PhonesAdd
            // 
            this.btnNewContact_PhonesAdd.Location = new System.Drawing.Point(15, 395);
            this.btnNewContact_PhonesAdd.Name = "btnNewContact_PhonesAdd";
            this.btnNewContact_PhonesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_PhonesAdd.TabIndex = 12;
            this.btnNewContact_PhonesAdd.Text = "Add";
            this.btnNewContact_PhonesAdd.UseVisualStyleBackColor = true;
            this.btnNewContact_PhonesAdd.Click += new System.EventHandler(this.btnNewContact_PhonesAdd_Click);
            // 
            // btnNewContact_EmailsDelete
            // 
            this.btnNewContact_EmailsDelete.Location = new System.Drawing.Point(358, 395);
            this.btnNewContact_EmailsDelete.Name = "btnNewContact_EmailsDelete";
            this.btnNewContact_EmailsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_EmailsDelete.TabIndex = 15;
            this.btnNewContact_EmailsDelete.Text = "Delete";
            this.btnNewContact_EmailsDelete.UseVisualStyleBackColor = true;
            this.btnNewContact_EmailsDelete.Click += new System.EventHandler(this.btnNewContact_EmailsDelete_Click);
            // 
            // btnNewContact_EmailsAdd
            // 
            this.btnNewContact_EmailsAdd.Location = new System.Drawing.Point(277, 395);
            this.btnNewContact_EmailsAdd.Name = "btnNewContact_EmailsAdd";
            this.btnNewContact_EmailsAdd.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_EmailsAdd.TabIndex = 14;
            this.btnNewContact_EmailsAdd.Text = "Add";
            this.btnNewContact_EmailsAdd.UseVisualStyleBackColor = true;
            this.btnNewContact_EmailsAdd.Click += new System.EventHandler(this.btnNewContact_EmailsAdd_Click);
            // 
            // btnNewContact_Exit
            // 
            this.btnNewContact_Exit.Location = new System.Drawing.Point(439, 443);
            this.btnNewContact_Exit.Name = "btnNewContact_Exit";
            this.btnNewContact_Exit.Size = new System.Drawing.Size(75, 23);
            this.btnNewContact_Exit.TabIndex = 17;
            this.btnNewContact_Exit.Text = "Exit";
            this.btnNewContact_Exit.UseVisualStyleBackColor = true;
            this.btnNewContact_Exit.Click += new System.EventHandler(this.btnNewContact_Exit_Click);
            // 
            // btnNewContact_SaveContact
            // 
            this.btnNewContact_SaveContact.Location = new System.Drawing.Point(337, 443);
            this.btnNewContact_SaveContact.Name = "btnNewContact_SaveContact";
            this.btnNewContact_SaveContact.Size = new System.Drawing.Size(96, 23);
            this.btnNewContact_SaveContact.TabIndex = 16;
            this.btnNewContact_SaveContact.Text = "Save Contact";
            this.btnNewContact_SaveContact.UseVisualStyleBackColor = true;
            this.btnNewContact_SaveContact.Click += new System.EventHandler(this.btnNewContact_SaveContact_Click);
            // 
            // lstNewContact_Addresses
            // 
            this.lstNewContact_Addresses.FormattingEnabled = true;
            this.lstNewContact_Addresses.Location = new System.Drawing.Point(15, 87);
            this.lstNewContact_Addresses.Name = "lstNewContact_Addresses";
            this.lstNewContact_Addresses.Size = new System.Drawing.Size(499, 108);
            this.lstNewContact_Addresses.TabIndex = 18;
            // 
            // lstNewContact_Phones
            // 
            this.lstNewContact_Phones.FormattingEnabled = true;
            this.lstNewContact_Phones.Location = new System.Drawing.Point(15, 253);
            this.lstNewContact_Phones.Name = "lstNewContact_Phones";
            this.lstNewContact_Phones.Size = new System.Drawing.Size(237, 134);
            this.lstNewContact_Phones.TabIndex = 19;
            // 
            // lstNewContact_Emails
            // 
            this.lstNewContact_Emails.FormattingEnabled = true;
            this.lstNewContact_Emails.Location = new System.Drawing.Point(277, 253);
            this.lstNewContact_Emails.Name = "lstNewContact_Emails";
            this.lstNewContact_Emails.Size = new System.Drawing.Size(237, 134);
            this.lstNewContact_Emails.TabIndex = 20;
            // 
            // NewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 478);
            this.Controls.Add(this.lstNewContact_Emails);
            this.Controls.Add(this.lstNewContact_Phones);
            this.Controls.Add(this.lstNewContact_Addresses);
            this.Controls.Add(this.btnNewContact_Exit);
            this.Controls.Add(this.btnNewContact_SaveContact);
            this.Controls.Add(this.btnNewContact_EmailsDelete);
            this.Controls.Add(this.btnNewContact_EmailsAdd);
            this.Controls.Add(this.btnNewContact_PhonesDelete);
            this.Controls.Add(this.btnNewContact_PhonesAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNewContact_AddressesDelete);
            this.Controls.Add(this.btnNewContact_AddressesAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewContact_ContactName);
            this.Name = "NewContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewContact";
            this.Load += new System.EventHandler(this.NewContact_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewContact_ContactName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewContact_AddressesAdd;
        private System.Windows.Forms.Button btnNewContact_AddressesDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewContact_PhonesDelete;
        private System.Windows.Forms.Button btnNewContact_PhonesAdd;
        private System.Windows.Forms.Button btnNewContact_EmailsDelete;
        private System.Windows.Forms.Button btnNewContact_EmailsAdd;
        private System.Windows.Forms.Button btnNewContact_Exit;
        private System.Windows.Forms.Button btnNewContact_SaveContact;
        private System.Windows.Forms.ListBox lstNewContact_Addresses;
        private System.Windows.Forms.ListBox lstNewContact_Phones;
        private System.Windows.Forms.ListBox lstNewContact_Emails;
    }
}