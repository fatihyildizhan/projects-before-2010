namespace parmakYarisi
{
    partial class Login
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Black;
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.txtEmail.Location = new System.Drawing.Point(110, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 24);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "asd";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(25, 138);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 17);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.txtPassword.Location = new System.Drawing.Point(109, 135);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(131, 24);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "asd";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(47, 108);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 17);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "E-mail:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.btnCreate.Location = new System.Drawing.Point(12, 250);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(251, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.TabStop = true;
            this.btnCreate.Text = "Create New Account";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.btnCreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCreate_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Image = global::parmakYarisi.Properties.Resources.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(165, 165);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 39);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.TabStop = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(81)))), ((int)(((byte)(93)))));
            this.btnClose.Image = global::parmakYarisi.Properties.Resources.btnClose1;
            this.btnClose.Location = new System.Drawing.Point(12, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "x";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::parmakYarisi.Properties.Resources.loginBack2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(275, 300);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parmak Yarışı - Login";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel btnCreate;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox btnLogin;
        private System.Windows.Forms.Label btnClose;
    }
}