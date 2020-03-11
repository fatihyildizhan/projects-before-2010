namespace FyDoxaAdressBook
{
    partial class NewEmails
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
            this.btnNewEmails_Exit = new System.Windows.Forms.Button();
            this.btnNewEmails_SaveContact = new System.Windows.Forms.Button();
            this.txtNewEmails = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNewEmails_Special = new System.Windows.Forms.RadioButton();
            this.rbNewEmails_Work = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewEmails_Exit
            // 
            this.btnNewEmails_Exit.Location = new System.Drawing.Point(195, 124);
            this.btnNewEmails_Exit.Name = "btnNewEmails_Exit";
            this.btnNewEmails_Exit.Size = new System.Drawing.Size(75, 23);
            this.btnNewEmails_Exit.TabIndex = 29;
            this.btnNewEmails_Exit.Text = "Exit";
            this.btnNewEmails_Exit.UseVisualStyleBackColor = true;
            this.btnNewEmails_Exit.Click += new System.EventHandler(this.btnNewEmails_Exit_Click);
            // 
            // btnNewEmails_SaveContact
            // 
            this.btnNewEmails_SaveContact.Location = new System.Drawing.Point(93, 124);
            this.btnNewEmails_SaveContact.Name = "btnNewEmails_SaveContact";
            this.btnNewEmails_SaveContact.Size = new System.Drawing.Size(96, 23);
            this.btnNewEmails_SaveContact.TabIndex = 28;
            this.btnNewEmails_SaveContact.Text = "Save Contact";
            this.btnNewEmails_SaveContact.UseVisualStyleBackColor = true;
            this.btnNewEmails_SaveContact.Click += new System.EventHandler(this.btnNewEmails_SaveContact_Click);
            // 
            // txtNewEmails
            // 
            this.txtNewEmails.Location = new System.Drawing.Point(12, 92);
            this.txtNewEmails.Multiline = true;
            this.txtNewEmails.Name = "txtNewEmails";
            this.txtNewEmails.Size = new System.Drawing.Size(259, 26);
            this.txtNewEmails.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Email";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNewEmails_Special);
            this.groupBox1.Controls.Add(this.rbNewEmails_Work);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 48);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Types";
            // 
            // rbNewEmails_Special
            // 
            this.rbNewEmails_Special.AutoSize = true;
            this.rbNewEmails_Special.Location = new System.Drawing.Point(78, 19);
            this.rbNewEmails_Special.Name = "rbNewEmails_Special";
            this.rbNewEmails_Special.Size = new System.Drawing.Size(60, 17);
            this.rbNewEmails_Special.TabIndex = 1;
            this.rbNewEmails_Special.Text = "Special";
            this.rbNewEmails_Special.UseVisualStyleBackColor = true;
            // 
            // rbNewEmails_Work
            // 
            this.rbNewEmails_Work.AutoSize = true;
            this.rbNewEmails_Work.Checked = true;
            this.rbNewEmails_Work.Location = new System.Drawing.Point(19, 19);
            this.rbNewEmails_Work.Name = "rbNewEmails_Work";
            this.rbNewEmails_Work.Size = new System.Drawing.Size(51, 17);
            this.rbNewEmails_Work.TabIndex = 0;
            this.rbNewEmails_Work.TabStop = true;
            this.rbNewEmails_Work.Text = "Work";
            this.rbNewEmails_Work.UseVisualStyleBackColor = true;
            // 
            // NewEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 162);
            this.Controls.Add(this.btnNewEmails_Exit);
            this.Controls.Add(this.btnNewEmails_SaveContact);
            this.Controls.Add(this.txtNewEmails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewEmails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewEmails";
            this.Load += new System.EventHandler(this.NewEmails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmails_Exit;
        private System.Windows.Forms.Button btnNewEmails_SaveContact;
        private System.Windows.Forms.TextBox txtNewEmails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNewEmails_Special;
        private System.Windows.Forms.RadioButton rbNewEmails_Work;
    }
}