namespace FyDoxaAdressBook
{
    partial class NewAddress
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNewAddress_Work = new System.Windows.Forms.RadioButton();
            this.rbNewAddress_Home = new System.Windows.Forms.RadioButton();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewAddress_Exit = new System.Windows.Forms.Button();
            this.btnNewAddress_SaveContact = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNewAddress_Work);
            this.groupBox1.Controls.Add(this.rbNewAddress_Home);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(143, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address Type";
            // 
            // rbNewAddress_Work
            // 
            this.rbNewAddress_Work.AutoSize = true;
            this.rbNewAddress_Work.Location = new System.Drawing.Point(78, 19);
            this.rbNewAddress_Work.Name = "rbNewAddress_Work";
            this.rbNewAddress_Work.Size = new System.Drawing.Size(51, 17);
            this.rbNewAddress_Work.TabIndex = 1;
            this.rbNewAddress_Work.TabStop = true;
            this.rbNewAddress_Work.Text = "Work";
            this.rbNewAddress_Work.UseVisualStyleBackColor = true;
            // 
            // rbNewAddress_Home
            // 
            this.rbNewAddress_Home.AutoSize = true;
            this.rbNewAddress_Home.Checked = true;
            this.rbNewAddress_Home.Location = new System.Drawing.Point(19, 19);
            this.rbNewAddress_Home.Name = "rbNewAddress_Home";
            this.rbNewAddress_Home.Size = new System.Drawing.Size(53, 17);
            this.rbNewAddress_Home.TabIndex = 0;
            this.rbNewAddress_Home.TabStop = true;
            this.rbNewAddress_Home.Text = "Home";
            this.rbNewAddress_Home.UseVisualStyleBackColor = true;
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.Location = new System.Drawing.Point(13, 93);
            this.txtNewAddress.Multiline = true;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(487, 132);
            this.txtNewAddress.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address";
            // 
            // btnNewAddress_Exit
            // 
            this.btnNewAddress_Exit.Location = new System.Drawing.Point(425, 231);
            this.btnNewAddress_Exit.Name = "btnNewAddress_Exit";
            this.btnNewAddress_Exit.Size = new System.Drawing.Size(75, 23);
            this.btnNewAddress_Exit.TabIndex = 19;
            this.btnNewAddress_Exit.Text = "Exit";
            this.btnNewAddress_Exit.UseVisualStyleBackColor = true;
            this.btnNewAddress_Exit.Click += new System.EventHandler(this.btnNewAddress_Exit_Click);
            // 
            // btnNewAddress_SaveContact
            // 
            this.btnNewAddress_SaveContact.Location = new System.Drawing.Point(323, 231);
            this.btnNewAddress_SaveContact.Name = "btnNewAddress_SaveContact";
            this.btnNewAddress_SaveContact.Size = new System.Drawing.Size(96, 23);
            this.btnNewAddress_SaveContact.TabIndex = 18;
            this.btnNewAddress_SaveContact.Text = "Save Contact";
            this.btnNewAddress_SaveContact.UseVisualStyleBackColor = true;
            this.btnNewAddress_SaveContact.Click += new System.EventHandler(this.btnNewAddress_SaveContact_Click);
            // 
            // NewAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 269);
            this.Controls.Add(this.btnNewAddress_Exit);
            this.Controls.Add(this.btnNewAddress_SaveContact);
            this.Controls.Add(this.txtNewAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAddress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAddress";
            this.Load += new System.EventHandler(this.NewAddress_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNewAddress_Work;
        private System.Windows.Forms.RadioButton rbNewAddress_Home;
        private System.Windows.Forms.TextBox txtNewAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewAddress_Exit;
        private System.Windows.Forms.Button btnNewAddress_SaveContact;
    }
}