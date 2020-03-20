namespace Hospital_App_Csharp
{
    partial class frmDoctor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbInfoMale = new System.Windows.Forms.RadioButton();
            this.rbInfoFemale = new System.Windows.Forms.RadioButton();
            this.txtDoctorInfoPhone = new System.Windows.Forms.TextBox();
            this.txtDoctorInfoProf = new System.Windows.Forms.TextBox();
            this.txtDoctorInfoSurname = new System.Windows.Forms.TextBox();
            this.txtDoctorInfoName = new System.Windows.Forms.TextBox();
            this.btnGetDoctors = new System.Windows.Forms.Button();
            this.lstDoctor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbMale);
            this.tabPage1.Controls.Add(this.rbFemale);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtProfession);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(885, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Doctor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(206, 269);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add Doctor";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Doctor Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doctor Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doctor Profession:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doctor Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor Name:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(333, 230);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 5;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(206, 230);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(206, 202);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 22);
            this.txtPhone.TabIndex = 3;
            // 
            // txtProfession
            // 
            this.txtProfession.Location = new System.Drawing.Point(206, 143);
            this.txtProfession.MaxLength = 100;
            this.txtProfession.Multiline = true;
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(186, 53);
            this.txtProfession.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(206, 115);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(186, 22);
            this.txtSurname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(206, 87);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 22);
            this.txtName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnGetDoctors);
            this.tabPage2.Controls.Add(this.lstDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(885, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Doctor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbInfoMale);
            this.groupBox1.Controls.Add(this.rbInfoFemale);
            this.groupBox1.Controls.Add(this.txtDoctorInfoPhone);
            this.groupBox1.Controls.Add(this.txtDoctorInfoProf);
            this.groupBox1.Controls.Add(this.txtDoctorInfoSurname);
            this.groupBox1.Controls.Add(this.txtDoctorInfoName);
            this.groupBox1.Location = new System.Drawing.Point(500, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 353);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Doctor Gender:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Doctor Phone:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Doctor Profession:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Doctor Surname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Doctor Name:";
            // 
            // rbInfoMale
            // 
            this.rbInfoMale.AutoSize = true;
            this.rbInfoMale.Enabled = false;
            this.rbInfoMale.Location = new System.Drawing.Point(290, 219);
            this.rbInfoMale.Name = "rbInfoMale";
            this.rbInfoMale.Size = new System.Drawing.Size(59, 21);
            this.rbInfoMale.TabIndex = 37;
            this.rbInfoMale.Text = "Male";
            this.rbInfoMale.UseVisualStyleBackColor = true;
            // 
            // rbInfoFemale
            // 
            this.rbInfoFemale.AutoSize = true;
            this.rbInfoFemale.Checked = true;
            this.rbInfoFemale.Enabled = false;
            this.rbInfoFemale.Location = new System.Drawing.Point(163, 219);
            this.rbInfoFemale.Name = "rbInfoFemale";
            this.rbInfoFemale.Size = new System.Drawing.Size(75, 21);
            this.rbInfoFemale.TabIndex = 36;
            this.rbInfoFemale.TabStop = true;
            this.rbInfoFemale.Text = "Female";
            this.rbInfoFemale.UseVisualStyleBackColor = true;
            // 
            // txtDoctorInfoPhone
            // 
            this.txtDoctorInfoPhone.Enabled = false;
            this.txtDoctorInfoPhone.Location = new System.Drawing.Point(163, 191);
            this.txtDoctorInfoPhone.MaxLength = 11;
            this.txtDoctorInfoPhone.Name = "txtDoctorInfoPhone";
            this.txtDoctorInfoPhone.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorInfoPhone.TabIndex = 35;
            // 
            // txtDoctorInfoProf
            // 
            this.txtDoctorInfoProf.Enabled = false;
            this.txtDoctorInfoProf.Location = new System.Drawing.Point(163, 132);
            this.txtDoctorInfoProf.MaxLength = 100;
            this.txtDoctorInfoProf.Multiline = true;
            this.txtDoctorInfoProf.Name = "txtDoctorInfoProf";
            this.txtDoctorInfoProf.Size = new System.Drawing.Size(186, 53);
            this.txtDoctorInfoProf.TabIndex = 30;
            // 
            // txtDoctorInfoSurname
            // 
            this.txtDoctorInfoSurname.Enabled = false;
            this.txtDoctorInfoSurname.Location = new System.Drawing.Point(163, 104);
            this.txtDoctorInfoSurname.MaxLength = 50;
            this.txtDoctorInfoSurname.Name = "txtDoctorInfoSurname";
            this.txtDoctorInfoSurname.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorInfoSurname.TabIndex = 28;
            // 
            // txtDoctorInfoName
            // 
            this.txtDoctorInfoName.Enabled = false;
            this.txtDoctorInfoName.Location = new System.Drawing.Point(163, 76);
            this.txtDoctorInfoName.MaxLength = 50;
            this.txtDoctorInfoName.Name = "txtDoctorInfoName";
            this.txtDoctorInfoName.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorInfoName.TabIndex = 27;
            // 
            // btnGetDoctors
            // 
            this.btnGetDoctors.Location = new System.Drawing.Point(138, 365);
            this.btnGetDoctors.Name = "btnGetDoctors";
            this.btnGetDoctors.Size = new System.Drawing.Size(232, 39);
            this.btnGetDoctors.TabIndex = 7;
            this.btnGetDoctors.Text = "Get Doctors";
            this.btnGetDoctors.UseVisualStyleBackColor = true;
            this.btnGetDoctors.Click += new System.EventHandler(this.btnGetDoctors_Click);
            // 
            // lstDoctor
            // 
            this.lstDoctor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstDoctor.FullRowSelect = true;
            this.lstDoctor.GridLines = true;
            this.lstDoctor.Location = new System.Drawing.Point(6, 6);
            this.lstDoctor.Name = "lstDoctor";
            this.lstDoctor.Size = new System.Drawing.Size(488, 353);
            this.lstDoctor.TabIndex = 15;
            this.lstDoctor.UseCompatibleStateImageBehavior = false;
            this.lstDoctor.View = System.Windows.Forms.View.Details;
            this.lstDoctor.SelectedIndexChanged += new System.EventHandler(this.lstDoctor_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phone";
            this.columnHeader3.Width = 132;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 457);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(232, 39);
            this.btnQuit.TabIndex = 7;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_App_Csharp.Properties.Resources.doctor;
            this.pictureBox1.Location = new System.Drawing.Point(437, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 505);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctors Page";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstDoctor;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnGetDoctors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbInfoMale;
        private System.Windows.Forms.RadioButton rbInfoFemale;
        private System.Windows.Forms.TextBox txtDoctorInfoPhone;
        private System.Windows.Forms.TextBox txtDoctorInfoProf;
        private System.Windows.Forms.TextBox txtDoctorInfoSurname;
        private System.Windows.Forms.TextBox txtDoctorInfoName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}