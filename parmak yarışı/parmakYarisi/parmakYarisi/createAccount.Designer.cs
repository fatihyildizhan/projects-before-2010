namespace parmakYarisi
{
    partial class createAccount
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.dateBirthdate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lblNickname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Controls.Add(this.dateBirthdate);
            this.groupBox1.Controls.Add(this.lblBirthdate);
            this.groupBox1.Controls.Add(this.lblGender);
            this.groupBox1.Controls.Add(this.txtConfirmPassword);
            this.groupBox1.Controls.Add(this.lblConfirmPassword);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtNickname);
            this.groupBox1.Controls.Add(this.lblNickname);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create an Account";
            // 
            // btnCreate
            // 
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.Location = new System.Drawing.Point(116, 231);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(199, 23);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "Create an Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(231, 75);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(140, 75);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // dateBirthdate
            // 
            this.dateBirthdate.Location = new System.Drawing.Point(116, 100);
            this.dateBirthdate.Name = "dateBirthdate";
            this.dateBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dateBirthdate.TabIndex = 5;
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(55, 103);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(52, 13);
            this.lblBirthdate.TabIndex = 14;
            this.lblBirthdate.Text = "Birthdate:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(62, 77);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "Gender:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(116, 204);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(200, 20);
            this.txtConfirmPassword.TabIndex = 9;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(13, 207);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 10;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(116, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(51, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(72, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(116, 126);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(200, 20);
            this.txtNickname.TabIndex = 6;
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Location = new System.Drawing.Point(6, 129);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(101, 13);
            this.lblNickname.TabIndex = 4;
            this.lblNickname.Text = "Prefered Nickname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(116, 48);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(55, 51);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(116, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(69, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // createAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(346, 280);
            this.Controls.Add(this.groupBox1);
            this.Name = "createAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parmak Yarışı - Create Account";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateBirthdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button btnCreate;
    }
}