namespace Hospital_App_Csharp
{
    partial class frmRecord
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
            this.btnAddRecord = new System.Windows.Forms.Button();
            this.nupVisitor = new System.Windows.Forms.NumericUpDown();
            this.nupAttendent = new System.Windows.Forms.NumericUpDown();
            this.cmbDoctorSelect = new System.Windows.Forms.ComboBox();
            this.cmbPatientSelect = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtDisease = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGetRecords = new System.Windows.Forms.Button();
            this.lstRecords = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPatient = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.dtpPatientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.gbRecord = new System.Windows.Forms.GroupBox();
            this.nupRecordInfoVisitor = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRecordInfoDisease = new System.Windows.Forms.TextBox();
            this.txtRecordInfoCost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.nupRecordInfoAttendent = new System.Windows.Forms.NumericUpDown();
            this.dtpRecordInfoCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.dtpRecordInfoCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.gbDoctor = new System.Windows.Forms.GroupBox();
            this.rbDoctorMale = new System.Windows.Forms.RadioButton();
            this.rbDoctorFemale = new System.Windows.Forms.RadioButton();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDoctorSurname = new System.Windows.Forms.TextBox();
            this.txtDoctorProfession = new System.Windows.Forms.TextBox();
            this.txtDoctorPhone = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAttendent)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbPatient.SuspendLayout();
            this.gbRecord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecordInfoVisitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecordInfoAttendent)).BeginInit();
            this.gbDoctor.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1254, 422);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAddRecord);
            this.tabPage1.Controls.Add(this.nupVisitor);
            this.tabPage1.Controls.Add(this.nupAttendent);
            this.tabPage1.Controls.Add(this.cmbDoctorSelect);
            this.tabPage1.Controls.Add(this.cmbPatientSelect);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dtpCheckOut);
            this.tabPage1.Controls.Add(this.dtpCheckIn);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtCost);
            this.tabPage1.Controls.Add(this.txtDisease);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1246, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Record";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddRecord
            // 
            this.btnAddRecord.Location = new System.Drawing.Point(254, 326);
            this.btnAddRecord.Name = "btnAddRecord";
            this.btnAddRecord.Size = new System.Drawing.Size(186, 26);
            this.btnAddRecord.TabIndex = 13;
            this.btnAddRecord.Text = "Add Record";
            this.btnAddRecord.UseVisualStyleBackColor = true;
            this.btnAddRecord.Click += new System.EventHandler(this.btnAddRecord_Click);
            // 
            // nupVisitor
            // 
            this.nupVisitor.Location = new System.Drawing.Point(254, 214);
            this.nupVisitor.Name = "nupVisitor";
            this.nupVisitor.Size = new System.Drawing.Size(72, 22);
            this.nupVisitor.TabIndex = 72;
            // 
            // nupAttendent
            // 
            this.nupAttendent.Location = new System.Drawing.Point(254, 186);
            this.nupAttendent.Name = "nupAttendent";
            this.nupAttendent.Size = new System.Drawing.Size(72, 22);
            this.nupAttendent.TabIndex = 72;
            // 
            // cmbDoctorSelect
            // 
            this.cmbDoctorSelect.FormattingEnabled = true;
            this.cmbDoctorSelect.Location = new System.Drawing.Point(254, 70);
            this.cmbDoctorSelect.Name = "cmbDoctorSelect";
            this.cmbDoctorSelect.Size = new System.Drawing.Size(186, 24);
            this.cmbDoctorSelect.TabIndex = 71;
            // 
            // cmbPatientSelect
            // 
            this.cmbPatientSelect.FormattingEnabled = true;
            this.cmbPatientSelect.Location = new System.Drawing.Point(254, 100);
            this.cmbPatientSelect.Name = "cmbPatientSelect";
            this.cmbPatientSelect.Size = new System.Drawing.Size(186, 24);
            this.cmbPatientSelect.TabIndex = 71;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(446, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 70;
            this.label12.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(332, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Day(s)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Attendent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Check Out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 69;
            this.label2.Text = "Check In:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Check In:";
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(254, 158);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(186, 22);
            this.dtpCheckOut.TabIndex = 61;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(254, 130);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(186, 22);
            this.dtpCheckIn.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 67;
            this.label9.Text = "Disease:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Cost:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 67;
            this.label4.Text = "Visitor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Select Doctor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "Select Patient:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(254, 242);
            this.txtCost.MaxLength = 50;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(186, 22);
            this.txtCost.TabIndex = 63;
            // 
            // txtDisease
            // 
            this.txtDisease.Location = new System.Drawing.Point(254, 270);
            this.txtDisease.MaxLength = 100;
            this.txtDisease.Multiline = true;
            this.txtDisease.Name = "txtDisease";
            this.txtDisease.Size = new System.Drawing.Size(186, 50);
            this.txtDisease.TabIndex = 64;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGetRecords);
            this.tabPage2.Controls.Add(this.lstRecords);
            this.tabPage2.Controls.Add(this.gbPatient);
            this.tabPage2.Controls.Add(this.gbRecord);
            this.tabPage2.Controls.Add(this.gbDoctor);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1246, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Show Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGetRecords
            // 
            this.btnGetRecords.Location = new System.Drawing.Point(6, 360);
            this.btnGetRecords.Name = "btnGetRecords";
            this.btnGetRecords.Size = new System.Drawing.Size(222, 27);
            this.btnGetRecords.TabIndex = 13;
            this.btnGetRecords.Text = "Get Records";
            this.btnGetRecords.UseVisualStyleBackColor = true;
            this.btnGetRecords.Click += new System.EventHandler(this.btnGetRecords_Click);
            // 
            // lstRecords
            // 
            this.lstRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.lstRecords.FullRowSelect = true;
            this.lstRecords.GridLines = true;
            this.lstRecords.Location = new System.Drawing.Point(6, 6);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(470, 348);
            this.lstRecords.TabIndex = 111;
            this.lstRecords.UseCompatibleStateImageBehavior = false;
            this.lstRecords.View = System.Windows.Forms.View.Details;
            this.lstRecords.SelectedIndexChanged += new System.EventHandler(this.lstRecords_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Check-In Info";
            this.columnHeader3.Width = 143;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Doctor Info";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patient Info";
            this.columnHeader2.Width = 161;
            // 
            // gbPatient
            // 
            this.gbPatient.Controls.Add(this.label25);
            this.gbPatient.Controls.Add(this.label26);
            this.gbPatient.Controls.Add(this.label14);
            this.gbPatient.Controls.Add(this.label15);
            this.gbPatient.Controls.Add(this.txtPatientSurname);
            this.gbPatient.Controls.Add(this.txtPatientName);
            this.gbPatient.Controls.Add(this.dtpPatientBirthDate);
            this.gbPatient.Controls.Add(this.txtPatientAddress);
            this.gbPatient.Location = new System.Drawing.Point(482, 133);
            this.gbPatient.Name = "gbPatient";
            this.gbPatient.Size = new System.Drawing.Size(744, 121);
            this.gbPatient.TabIndex = 0;
            this.gbPatient.TabStop = false;
            this.gbPatient.Text = "Patient ID:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(319, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 17);
            this.label25.TabIndex = 97;
            this.label25.Text = "Address:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(319, 34);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 17);
            this.label26.TabIndex = 97;
            this.label26.Text = "Birth Date:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 17);
            this.label14.TabIndex = 97;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 17);
            this.label15.TabIndex = 96;
            this.label15.Text = "Surname:";
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Enabled = false;
            this.txtPatientSurname.Location = new System.Drawing.Point(98, 62);
            this.txtPatientSurname.MaxLength = 50;
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(186, 22);
            this.txtPatientSurname.TabIndex = 94;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Location = new System.Drawing.Point(98, 34);
            this.txtPatientName.MaxLength = 50;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(186, 22);
            this.txtPatientName.TabIndex = 94;
            // 
            // dtpPatientBirthDate
            // 
            this.dtpPatientBirthDate.Enabled = false;
            this.dtpPatientBirthDate.Location = new System.Drawing.Point(400, 32);
            this.dtpPatientBirthDate.Name = "dtpPatientBirthDate";
            this.dtpPatientBirthDate.Size = new System.Drawing.Size(338, 22);
            this.dtpPatientBirthDate.TabIndex = 111;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Enabled = false;
            this.txtPatientAddress.Location = new System.Drawing.Point(400, 62);
            this.txtPatientAddress.MaxLength = 100;
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(338, 50);
            this.txtPatientAddress.TabIndex = 114;
            // 
            // gbRecord
            // 
            this.gbRecord.Controls.Add(this.nupRecordInfoVisitor);
            this.gbRecord.Controls.Add(this.label20);
            this.gbRecord.Controls.Add(this.label11);
            this.gbRecord.Controls.Add(this.label17);
            this.gbRecord.Controls.Add(this.label24);
            this.gbRecord.Controls.Add(this.txtRecordInfoDisease);
            this.gbRecord.Controls.Add(this.txtRecordInfoCost);
            this.gbRecord.Controls.Add(this.label23);
            this.gbRecord.Controls.Add(this.nupRecordInfoAttendent);
            this.gbRecord.Controls.Add(this.dtpRecordInfoCheckIn);
            this.gbRecord.Controls.Add(this.label16);
            this.gbRecord.Controls.Add(this.dtpRecordInfoCheckOut);
            this.gbRecord.Controls.Add(this.label13);
            this.gbRecord.Controls.Add(this.label19);
            this.gbRecord.Controls.Add(this.label18);
            this.gbRecord.Location = new System.Drawing.Point(482, 260);
            this.gbRecord.Name = "gbRecord";
            this.gbRecord.Size = new System.Drawing.Size(744, 121);
            this.gbRecord.TabIndex = 0;
            this.gbRecord.TabStop = false;
            this.gbRecord.Text = "Record ID:";
            // 
            // nupRecordInfoVisitor
            // 
            this.nupRecordInfoVisitor.Enabled = false;
            this.nupRecordInfoVisitor.Location = new System.Drawing.Point(666, 84);
            this.nupRecordInfoVisitor.Name = "nupRecordInfoVisitor";
            this.nupRecordInfoVisitor.Size = new System.Drawing.Size(72, 22);
            this.nupRecordInfoVisitor.TabIndex = 124;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(319, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 17);
            this.label20.TabIndex = 117;
            this.label20.Text = "Disease:";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(76, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 17);
            this.label11.TabIndex = 121;
            this.label11.Text = "$";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 17);
            this.label17.TabIndex = 119;
            this.label17.Text = "Check Out:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(609, 89);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 17);
            this.label24.TabIndex = 115;
            this.label24.Text = "Visitor:";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRecordInfoDisease
            // 
            this.txtRecordInfoDisease.Enabled = false;
            this.txtRecordInfoDisease.Location = new System.Drawing.Point(398, 21);
            this.txtRecordInfoDisease.MaxLength = 100;
            this.txtRecordInfoDisease.Multiline = true;
            this.txtRecordInfoDisease.Name = "txtRecordInfoDisease";
            this.txtRecordInfoDisease.Size = new System.Drawing.Size(340, 50);
            this.txtRecordInfoDisease.TabIndex = 114;
            // 
            // txtRecordInfoCost
            // 
            this.txtRecordInfoCost.Enabled = false;
            this.txtRecordInfoCost.Location = new System.Drawing.Point(98, 86);
            this.txtRecordInfoCost.MaxLength = 50;
            this.txtRecordInfoCost.Name = "txtRecordInfoCost";
            this.txtRecordInfoCost.Size = new System.Drawing.Size(186, 22);
            this.txtRecordInfoCost.TabIndex = 113;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(15, 89);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(40, 17);
            this.label23.TabIndex = 116;
            this.label23.Text = "Cost:";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nupRecordInfoAttendent
            // 
            this.nupRecordInfoAttendent.Enabled = false;
            this.nupRecordInfoAttendent.Location = new System.Drawing.Point(398, 84);
            this.nupRecordInfoAttendent.Name = "nupRecordInfoAttendent";
            this.nupRecordInfoAttendent.Size = new System.Drawing.Size(72, 22);
            this.nupRecordInfoAttendent.TabIndex = 125;
            // 
            // dtpRecordInfoCheckIn
            // 
            this.dtpRecordInfoCheckIn.Enabled = false;
            this.dtpRecordInfoCheckIn.Location = new System.Drawing.Point(98, 26);
            this.dtpRecordInfoCheckIn.Name = "dtpRecordInfoCheckIn";
            this.dtpRecordInfoCheckIn.Size = new System.Drawing.Size(186, 22);
            this.dtpRecordInfoCheckIn.TabIndex = 111;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(319, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 17);
            this.label16.TabIndex = 123;
            this.label16.Text = "Attendent:";
            // 
            // dtpRecordInfoCheckOut
            // 
            this.dtpRecordInfoCheckOut.Enabled = false;
            this.dtpRecordInfoCheckOut.Location = new System.Drawing.Point(98, 54);
            this.dtpRecordInfoCheckOut.Name = "dtpRecordInfoCheckOut";
            this.dtpRecordInfoCheckOut.Size = new System.Drawing.Size(186, 22);
            this.dtpRecordInfoCheckOut.TabIndex = 112;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(476, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 17);
            this.label13.TabIndex = 122;
            this.label13.Text = "Day(s)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 29);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(66, 17);
            this.label19.TabIndex = 118;
            this.label19.Text = "Check In:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 17);
            this.label18.TabIndex = 120;
            this.label18.Text = "Check In:";
            // 
            // gbDoctor
            // 
            this.gbDoctor.Controls.Add(this.rbDoctorMale);
            this.gbDoctor.Controls.Add(this.rbDoctorFemale);
            this.gbDoctor.Controls.Add(this.txtDoctorName);
            this.gbDoctor.Controls.Add(this.txtDoctorSurname);
            this.gbDoctor.Controls.Add(this.txtDoctorProfession);
            this.gbDoctor.Controls.Add(this.txtDoctorPhone);
            this.gbDoctor.Controls.Add(this.label22);
            this.gbDoctor.Controls.Add(this.label27);
            this.gbDoctor.Controls.Add(this.label28);
            this.gbDoctor.Controls.Add(this.label29);
            this.gbDoctor.Controls.Add(this.label21);
            this.gbDoctor.Location = new System.Drawing.Point(482, 6);
            this.gbDoctor.Name = "gbDoctor";
            this.gbDoctor.Size = new System.Drawing.Size(744, 121);
            this.gbDoctor.TabIndex = 0;
            this.gbDoctor.TabStop = false;
            this.gbDoctor.Text = "Doctor ID:";
            // 
            // rbDoctorMale
            // 
            this.rbDoctorMale.AutoSize = true;
            this.rbDoctorMale.Enabled = false;
            this.rbDoctorMale.Location = new System.Drawing.Point(666, 66);
            this.rbDoctorMale.Name = "rbDoctorMale";
            this.rbDoctorMale.Size = new System.Drawing.Size(59, 21);
            this.rbDoctorMale.TabIndex = 98;
            this.rbDoctorMale.TabStop = true;
            this.rbDoctorMale.Text = "Male";
            this.rbDoctorMale.UseVisualStyleBackColor = true;
            // 
            // rbDoctorFemale
            // 
            this.rbDoctorFemale.AutoSize = true;
            this.rbDoctorFemale.Enabled = false;
            this.rbDoctorFemale.Location = new System.Drawing.Point(666, 33);
            this.rbDoctorFemale.Name = "rbDoctorFemale";
            this.rbDoctorFemale.Size = new System.Drawing.Size(75, 21);
            this.rbDoctorFemale.TabIndex = 98;
            this.rbDoctorFemale.TabStop = true;
            this.rbDoctorFemale.Text = "Female";
            this.rbDoctorFemale.UseVisualStyleBackColor = true;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Enabled = false;
            this.txtDoctorName.Location = new System.Drawing.Point(98, 35);
            this.txtDoctorName.MaxLength = 50;
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorName.TabIndex = 94;
            // 
            // txtDoctorSurname
            // 
            this.txtDoctorSurname.Enabled = false;
            this.txtDoctorSurname.Location = new System.Drawing.Point(98, 65);
            this.txtDoctorSurname.MaxLength = 50;
            this.txtDoctorSurname.Name = "txtDoctorSurname";
            this.txtDoctorSurname.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorSurname.TabIndex = 94;
            // 
            // txtDoctorProfession
            // 
            this.txtDoctorProfession.Enabled = false;
            this.txtDoctorProfession.Location = new System.Drawing.Point(400, 37);
            this.txtDoctorProfession.MaxLength = 50;
            this.txtDoctorProfession.Name = "txtDoctorProfession";
            this.txtDoctorProfession.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorProfession.TabIndex = 94;
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.Enabled = false;
            this.txtDoctorPhone.Location = new System.Drawing.Point(400, 65);
            this.txtDoctorPhone.MaxLength = 50;
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.Size = new System.Drawing.Size(186, 22);
            this.txtDoctorPhone.TabIndex = 94;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 40);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 17);
            this.label22.TabIndex = 97;
            this.label22.Text = "Name:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(15, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(69, 17);
            this.label27.TabIndex = 96;
            this.label27.Text = "Surname:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(319, 35);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 17);
            this.label28.TabIndex = 96;
            this.label28.Text = "Profession:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(600, 35);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 17);
            this.label29.TabIndex = 96;
            this.label29.Text = "Gender:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(319, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 17);
            this.label21.TabIndex = 96;
            this.label21.Text = "Phone:";
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(12, 440);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(232, 39);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(499, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 346);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_App_Csharp.Properties.Resources.records;
            this.pictureBox1.Location = new System.Drawing.Point(90, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // frmRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 491);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records Page";
            this.Load += new System.EventHandler(this.frmRecord_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupAttendent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbPatient.ResumeLayout(false);
            this.gbPatient.PerformLayout();
            this.gbRecord.ResumeLayout(false);
            this.gbRecord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecordInfoVisitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupRecordInfoAttendent)).EndInit();
            this.gbDoctor.ResumeLayout(false);
            this.gbDoctor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cmbDoctorSelect;
        private System.Windows.Forms.ComboBox cmbPatientSelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtDisease;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nupVisitor;
        private System.Windows.Forms.NumericUpDown nupAttendent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnAddRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetRecords;
        private System.Windows.Forms.ListView lstRecords;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox gbPatient;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.DateTimePicker dtpPatientBirthDate;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.GroupBox gbRecord;
        private System.Windows.Forms.NumericUpDown nupRecordInfoVisitor;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtRecordInfoDisease;
        private System.Windows.Forms.TextBox txtRecordInfoCost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown nupRecordInfoAttendent;
        private System.Windows.Forms.DateTimePicker dtpRecordInfoCheckIn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtpRecordInfoCheckOut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox gbDoctor;
        private System.Windows.Forms.RadioButton rbDoctorMale;
        private System.Windows.Forms.RadioButton rbDoctorFemale;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtDoctorSurname;
        private System.Windows.Forms.TextBox txtDoctorProfession;
        private System.Windows.Forms.TextBox txtDoctorPhone;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}