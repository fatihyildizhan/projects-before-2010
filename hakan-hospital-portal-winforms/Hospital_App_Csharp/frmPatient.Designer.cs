namespace Hospital_App_Csharp
{
    partial class frmPatient
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMarriade = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSingle = new System.Windows.Forms.RadioButton();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbInfoFemale = new System.Windows.Forms.RadioButton();
            this.rbInfoMale = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPatientInfoDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rbInfoMarriade = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            this.rbInfoSingle = new System.Windows.Forms.RadioButton();
            this.txtPatientInfoCity = new System.Windows.Forms.TextBox();
            this.txtPatientInfoPhone = new System.Windows.Forms.TextBox();
            this.txtPatientInfoAddress = new System.Windows.Forms.TextBox();
            this.txtPatientInfoSurname = new System.Windows.Forms.TextBox();
            this.txtPatientInfoName = new System.Windows.Forms.TextBox();
            this.lstPatient = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 430);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dtpDate);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rdMarriade);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rbSingle);
            this.tabPage1.Controls.Add(this.txtCity);
            this.tabPage1.Controls.Add(this.txtPhone);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtSurname);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(893, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Patient";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbFemale);
            this.panel2.Controls.Add(this.rbMale);
            this.panel2.Location = new System.Drawing.Point(220, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 34);
            this.panel2.TabIndex = 41;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Location = new System.Drawing.Point(3, 3);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(75, 21);
            this.rbFemale.TabIndex = 32;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(104, 3);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(59, 21);
            this.rbMale.TabIndex = 33;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Patient City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Patient Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Patient BirthDate:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(223, 116);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(186, 22);
            this.dtpDate.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 17);
            this.label8.TabIndex = 36;
            this.label8.Text = "Patient Marial Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Patient Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Patient Phone:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Patient Surname:";
            // 
            // rdMarriade
            // 
            this.rdMarriade.AutoSize = true;
            this.rdMarriade.Location = new System.Drawing.Point(324, 252);
            this.rdMarriade.Name = "rdMarriade";
            this.rdMarriade.Size = new System.Drawing.Size(85, 21);
            this.rdMarriade.TabIndex = 30;
            this.rdMarriade.Text = "Marriade";
            this.rdMarriade.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Patient Name:";
            // 
            // rbSingle
            // 
            this.rbSingle.AutoSize = true;
            this.rbSingle.Checked = true;
            this.rbSingle.Location = new System.Drawing.Point(223, 250);
            this.rbSingle.Name = "rbSingle";
            this.rbSingle.Size = new System.Drawing.Size(68, 21);
            this.rbSingle.TabIndex = 29;
            this.rbSingle.TabStop = true;
            this.rbSingle.Text = "Single";
            this.rbSingle.UseVisualStyleBackColor = true;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(223, 196);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(186, 22);
            this.txtCity.TabIndex = 27;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(223, 224);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 22);
            this.txtPhone.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(223, 144);
            this.txtAddress.MaxLength = 250;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 46);
            this.txtAddress.TabIndex = 26;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(223, 88);
            this.txtSurname.MaxLength = 50;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(186, 22);
            this.txtSurname.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(223, 60);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 22);
            this.txtName.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(223, 317);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(186, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.lstPatient);
            this.tabPage4.Controls.Add(this.btnRefresh);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(893, 401);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Show Patient";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dtpPatientInfoDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.rbInfoMarriade);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.rbInfoSingle);
            this.groupBox1.Controls.Add(this.txtPatientInfoCity);
            this.groupBox1.Controls.Add(this.txtPatientInfoPhone);
            this.groupBox1.Controls.Add(this.txtPatientInfoAddress);
            this.groupBox1.Controls.Add(this.txtPatientInfoSurname);
            this.groupBox1.Controls.Add(this.txtPatientInfoName);
            this.groupBox1.Location = new System.Drawing.Point(500, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 344);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Info";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInfoFemale);
            this.panel1.Controls.Add(this.rbInfoMale);
            this.panel1.Location = new System.Drawing.Point(170, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 38);
            this.panel1.TabIndex = 59;
            // 
            // rbInfoFemale
            // 
            this.rbInfoFemale.AutoSize = true;
            this.rbInfoFemale.Enabled = false;
            this.rbInfoFemale.Location = new System.Drawing.Point(3, 3);
            this.rbInfoFemale.Name = "rbInfoFemale";
            this.rbInfoFemale.Size = new System.Drawing.Size(75, 21);
            this.rbInfoFemale.TabIndex = 50;
            this.rbInfoFemale.Text = "Female";
            this.rbInfoFemale.UseVisualStyleBackColor = true;
            // 
            // rbInfoMale
            // 
            this.rbInfoMale.AutoSize = true;
            this.rbInfoMale.Enabled = false;
            this.rbInfoMale.Location = new System.Drawing.Point(104, 3);
            this.rbInfoMale.Name = "rbInfoMale";
            this.rbInfoMale.Size = new System.Drawing.Size(59, 21);
            this.rbInfoMale.TabIndex = 51;
            this.rbInfoMale.Text = "Male";
            this.rbInfoMale.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 58;
            this.label9.Text = "Patient City:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 17);
            this.label10.TabIndex = 57;
            this.label10.Text = "Patient Address:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 56;
            this.label11.Text = "Patient BirthDate:";
            // 
            // dtpPatientInfoDate
            // 
            this.dtpPatientInfoDate.Enabled = false;
            this.dtpPatientInfoDate.Location = new System.Drawing.Point(173, 110);
            this.dtpPatientInfoDate.Name = "dtpPatientInfoDate";
            this.dtpPatientInfoDate.Size = new System.Drawing.Size(186, 22);
            this.dtpPatientInfoDate.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 17);
            this.label12.TabIndex = 54;
            this.label12.Text = "Patient Marial Status:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 272);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 55;
            this.label13.Text = "Patient Gender:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 17);
            this.label14.TabIndex = 53;
            this.label14.Text = "Patient Phone:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(117, 17);
            this.label15.TabIndex = 52;
            this.label15.Text = "Patient Surname:";
            // 
            // rbInfoMarriade
            // 
            this.rbInfoMarriade.AutoSize = true;
            this.rbInfoMarriade.Enabled = false;
            this.rbInfoMarriade.Location = new System.Drawing.Point(274, 246);
            this.rbInfoMarriade.Name = "rbInfoMarriade";
            this.rbInfoMarriade.Size = new System.Drawing.Size(85, 21);
            this.rbInfoMarriade.TabIndex = 48;
            this.rbInfoMarriade.Text = "Marriade";
            this.rbInfoMarriade.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 17);
            this.label16.TabIndex = 49;
            this.label16.Text = "Patient Name:";
            // 
            // rbInfoSingle
            // 
            this.rbInfoSingle.AutoSize = true;
            this.rbInfoSingle.Enabled = false;
            this.rbInfoSingle.Location = new System.Drawing.Point(173, 244);
            this.rbInfoSingle.Name = "rbInfoSingle";
            this.rbInfoSingle.Size = new System.Drawing.Size(68, 21);
            this.rbInfoSingle.TabIndex = 47;
            this.rbInfoSingle.Text = "Single";
            this.rbInfoSingle.UseVisualStyleBackColor = true;
            // 
            // txtPatientInfoCity
            // 
            this.txtPatientInfoCity.Enabled = false;
            this.txtPatientInfoCity.Location = new System.Drawing.Point(173, 190);
            this.txtPatientInfoCity.MaxLength = 50;
            this.txtPatientInfoCity.Name = "txtPatientInfoCity";
            this.txtPatientInfoCity.Size = new System.Drawing.Size(186, 22);
            this.txtPatientInfoCity.TabIndex = 45;
            // 
            // txtPatientInfoPhone
            // 
            this.txtPatientInfoPhone.Enabled = false;
            this.txtPatientInfoPhone.Location = new System.Drawing.Point(173, 218);
            this.txtPatientInfoPhone.MaxLength = 11;
            this.txtPatientInfoPhone.Name = "txtPatientInfoPhone";
            this.txtPatientInfoPhone.Size = new System.Drawing.Size(186, 22);
            this.txtPatientInfoPhone.TabIndex = 46;
            // 
            // txtPatientInfoAddress
            // 
            this.txtPatientInfoAddress.Enabled = false;
            this.txtPatientInfoAddress.Location = new System.Drawing.Point(173, 138);
            this.txtPatientInfoAddress.MaxLength = 250;
            this.txtPatientInfoAddress.Multiline = true;
            this.txtPatientInfoAddress.Name = "txtPatientInfoAddress";
            this.txtPatientInfoAddress.Size = new System.Drawing.Size(186, 46);
            this.txtPatientInfoAddress.TabIndex = 44;
            // 
            // txtPatientInfoSurname
            // 
            this.txtPatientInfoSurname.Enabled = false;
            this.txtPatientInfoSurname.Location = new System.Drawing.Point(173, 82);
            this.txtPatientInfoSurname.MaxLength = 50;
            this.txtPatientInfoSurname.Name = "txtPatientInfoSurname";
            this.txtPatientInfoSurname.Size = new System.Drawing.Size(186, 22);
            this.txtPatientInfoSurname.TabIndex = 42;
            // 
            // txtPatientInfoName
            // 
            this.txtPatientInfoName.Enabled = false;
            this.txtPatientInfoName.Location = new System.Drawing.Point(173, 54);
            this.txtPatientInfoName.MaxLength = 50;
            this.txtPatientInfoName.Name = "txtPatientInfoName";
            this.txtPatientInfoName.Size = new System.Drawing.Size(186, 22);
            this.txtPatientInfoName.TabIndex = 41;
            // 
            // lstPatient
            // 
            this.lstPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstPatient.FullRowSelect = true;
            this.lstPatient.GridLines = true;
            this.lstPatient.Location = new System.Drawing.Point(6, 6);
            this.lstPatient.Name = "lstPatient";
            this.lstPatient.Size = new System.Drawing.Size(488, 344);
            this.lstPatient.TabIndex = 14;
            this.lstPatient.UseCompatibleStateImageBehavior = false;
            this.lstPatient.View = System.Windows.Forms.View.Details;
            this.lstPatient.SelectedIndexChanged += new System.EventHandler(this.lstPatient_SelectedIndexChanged);
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
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(130, 356);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(232, 39);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Get Patients";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(146, 448);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(232, 39);
            this.btnQuit.TabIndex = 12;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_App_Csharp.Properties.Resources.patient;
            this.pictureBox1.Location = new System.Drawing.Point(415, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 389);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // frmPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 493);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patients Page";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lstPatient;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdMarriade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSingle;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPatientInfoDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbInfoMarriade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton rbInfoSingle;
        private System.Windows.Forms.RadioButton rbInfoMale;
        private System.Windows.Forms.RadioButton rbInfoFemale;
        private System.Windows.Forms.TextBox txtPatientInfoCity;
        private System.Windows.Forms.TextBox txtPatientInfoPhone;
        private System.Windows.Forms.TextBox txtPatientInfoAddress;
        private System.Windows.Forms.TextBox txtPatientInfoSurname;
        private System.Windows.Forms.TextBox txtPatientInfoName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}