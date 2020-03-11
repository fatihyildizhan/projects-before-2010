namespace FyDoxaAdressBook
{
    partial class NewPhones
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
            this.btnNewPhones_Exit = new System.Windows.Forms.Button();
            this.btnNewPhones_SaveContact = new System.Windows.Forms.Button();
            this.txtNewPhones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNewPhones_Hand = new System.Windows.Forms.RadioButton();
            this.rbNewPhones_Fax = new System.Windows.Forms.RadioButton();
            this.rbNewPhones_Work = new System.Windows.Forms.RadioButton();
            this.rbNewPhones_Home = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewPhones_Exit
            // 
            this.btnNewPhones_Exit.Location = new System.Drawing.Point(195, 126);
            this.btnNewPhones_Exit.Name = "btnNewPhones_Exit";
            this.btnNewPhones_Exit.Size = new System.Drawing.Size(75, 23);
            this.btnNewPhones_Exit.TabIndex = 24;
            this.btnNewPhones_Exit.Text = "Exit";
            this.btnNewPhones_Exit.UseVisualStyleBackColor = true;
            this.btnNewPhones_Exit.Click += new System.EventHandler(this.btnNewPhones_Exit_Click);
            // 
            // btnNewPhones_SaveContact
            // 
            this.btnNewPhones_SaveContact.Location = new System.Drawing.Point(93, 126);
            this.btnNewPhones_SaveContact.Name = "btnNewPhones_SaveContact";
            this.btnNewPhones_SaveContact.Size = new System.Drawing.Size(96, 23);
            this.btnNewPhones_SaveContact.TabIndex = 23;
            this.btnNewPhones_SaveContact.Text = "Save Contact";
            this.btnNewPhones_SaveContact.UseVisualStyleBackColor = true;
            this.btnNewPhones_SaveContact.Click += new System.EventHandler(this.btnNewPhones_SaveContact_Click);
            // 
            // txtNewPhones
            // 
            this.txtNewPhones.Location = new System.Drawing.Point(12, 94);
            this.txtNewPhones.Multiline = true;
            this.txtNewPhones.Name = "txtNewPhones";
            this.txtNewPhones.Size = new System.Drawing.Size(259, 26);
            this.txtNewPhones.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Phone Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbNewPhones_Hand);
            this.groupBox1.Controls.Add(this.rbNewPhones_Fax);
            this.groupBox1.Controls.Add(this.rbNewPhones_Work);
            this.groupBox1.Controls.Add(this.rbNewPhones_Home);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 48);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phones Type";
            // 
            // rbNewPhones_Hand
            // 
            this.rbNewPhones_Hand.AutoSize = true;
            this.rbNewPhones_Hand.Location = new System.Drawing.Point(194, 20);
            this.rbNewPhones_Hand.Name = "rbNewPhones_Hand";
            this.rbNewPhones_Hand.Size = new System.Drawing.Size(51, 17);
            this.rbNewPhones_Hand.TabIndex = 3;
            this.rbNewPhones_Hand.Text = "Hand";
            this.rbNewPhones_Hand.UseVisualStyleBackColor = true;
            // 
            // rbNewPhones_Fax
            // 
            this.rbNewPhones_Fax.AutoSize = true;
            this.rbNewPhones_Fax.Location = new System.Drawing.Point(135, 20);
            this.rbNewPhones_Fax.Name = "rbNewPhones_Fax";
            this.rbNewPhones_Fax.Size = new System.Drawing.Size(42, 17);
            this.rbNewPhones_Fax.TabIndex = 2;
            this.rbNewPhones_Fax.Text = "Fax";
            this.rbNewPhones_Fax.UseVisualStyleBackColor = true;
            // 
            // rbNewPhones_Work
            // 
            this.rbNewPhones_Work.AutoSize = true;
            this.rbNewPhones_Work.Location = new System.Drawing.Point(78, 19);
            this.rbNewPhones_Work.Name = "rbNewPhones_Work";
            this.rbNewPhones_Work.Size = new System.Drawing.Size(51, 17);
            this.rbNewPhones_Work.TabIndex = 1;
            this.rbNewPhones_Work.Text = "Work";
            this.rbNewPhones_Work.UseVisualStyleBackColor = true;
            // 
            // rbNewPhones_Home
            // 
            this.rbNewPhones_Home.AutoSize = true;
            this.rbNewPhones_Home.Checked = true;
            this.rbNewPhones_Home.Location = new System.Drawing.Point(19, 19);
            this.rbNewPhones_Home.Name = "rbNewPhones_Home";
            this.rbNewPhones_Home.Size = new System.Drawing.Size(53, 17);
            this.rbNewPhones_Home.TabIndex = 0;
            this.rbNewPhones_Home.TabStop = true;
            this.rbNewPhones_Home.Text = "Home";
            this.rbNewPhones_Home.UseVisualStyleBackColor = true;
            // 
            // NewPhones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 159);
            this.Controls.Add(this.btnNewPhones_Exit);
            this.Controls.Add(this.btnNewPhones_SaveContact);
            this.Controls.Add(this.txtNewPhones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewPhones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPhones";
            this.Load += new System.EventHandler(this.NewPhones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewPhones_Exit;
        private System.Windows.Forms.Button btnNewPhones_SaveContact;
        private System.Windows.Forms.TextBox txtNewPhones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNewPhones_Work;
        private System.Windows.Forms.RadioButton rbNewPhones_Home;
        private System.Windows.Forms.RadioButton rbNewPhones_Hand;
        private System.Windows.Forms.RadioButton rbNewPhones_Fax;
    }
}