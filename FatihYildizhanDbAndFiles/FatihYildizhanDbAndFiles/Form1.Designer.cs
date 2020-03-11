namespace FatihYildizhanDbAndFiles
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timerMFileToMRec = new System.Windows.Forms.Timer(this.components);
            this.lstMFile = new System.Windows.Forms.ListView();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTFile = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.btnMFileOku = new System.Windows.Forms.Button();
            this.btnTFileOku = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstTRec = new System.Windows.Forms.ListView();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstHataDosyasi = new System.Windows.Forms.ListView();
            this.columnHeader16 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader17 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader18 = new System.Windows.Forms.ColumnHeader();
            this.label6 = new System.Windows.Forms.Label();
            this.timerMRecToNewMFile = new System.Windows.Forms.Timer(this.components);
            this.timerTFileToTRec = new System.Windows.Forms.Timer(this.components);
            this.timerTRecToHataDosyasi = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.lstMRec = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lstNewMFile = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.timerTRecToNewMFile = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerSistemBeklet = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMFileToMRec
            // 
            this.timerMFileToMRec.Interval = 12;
            this.timerMFileToMRec.Tick += new System.EventHandler(this.timerMFileToMRec_Tick);
            // 
            // lstMFile
            // 
            this.lstMFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.lstMFile.FullRowSelect = true;
            this.lstMFile.GridLines = true;
            this.lstMFile.Location = new System.Drawing.Point(12, 36);
            this.lstMFile.Name = "lstMFile";
            this.lstMFile.Size = new System.Drawing.Size(216, 180);
            this.lstMFile.TabIndex = 8;
            this.lstMFile.UseCompatibleStateImageBehavior = false;
            this.lstMFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Key";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Data";
            this.columnHeader9.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "M-File";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(231, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "T-File";
            // 
            // lstTFile
            // 
            this.lstTFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstTFile.FullRowSelect = true;
            this.lstTFile.GridLines = true;
            this.lstTFile.Location = new System.Drawing.Point(234, 36);
            this.lstTFile.Name = "lstTFile";
            this.lstTFile.Size = new System.Drawing.Size(216, 180);
            this.lstTFile.TabIndex = 8;
            this.lstTFile.UseCompatibleStateImageBehavior = false;
            this.lstTFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kod";
            this.columnHeader4.Width = 37;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Key";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data";
            this.columnHeader6.Width = 92;
            // 
            // btnMFileOku
            // 
            this.btnMFileOku.Location = new System.Drawing.Point(153, 7);
            this.btnMFileOku.Name = "btnMFileOku";
            this.btnMFileOku.Size = new System.Drawing.Size(75, 23);
            this.btnMFileOku.TabIndex = 11;
            this.btnMFileOku.Text = "M-File Oku";
            this.btnMFileOku.UseVisualStyleBackColor = true;
            this.btnMFileOku.Click += new System.EventHandler(this.btnMFileOku_Click);
            // 
            // btnTFileOku
            // 
            this.btnTFileOku.Location = new System.Drawing.Point(375, 7);
            this.btnTFileOku.Name = "btnTFileOku";
            this.btnTFileOku.Size = new System.Drawing.Size(75, 23);
            this.btnTFileOku.TabIndex = 11;
            this.btnTFileOku.Text = "T-File Oku";
            this.btnTFileOku.UseVisualStyleBackColor = true;
            this.btnTFileOku.Click += new System.EventHandler(this.btnTFileOku_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(12, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "M-Rec";
            // 
            // lstTRec
            // 
            this.lstTRec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstTRec.FullRowSelect = true;
            this.lstTRec.GridLines = true;
            this.lstTRec.Location = new System.Drawing.Point(234, 265);
            this.lstTRec.Name = "lstTRec";
            this.lstTRec.Size = new System.Drawing.Size(216, 50);
            this.lstTRec.TabIndex = 8;
            this.lstTRec.UseCompatibleStateImageBehavior = false;
            this.lstTRec.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Kod";
            this.columnHeader10.Width = 37;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Key";
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Data";
            this.columnHeader12.Width = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(234, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "T-Rec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(12, 348);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "N. M-File";
            // 
            // lstHataDosyasi
            // 
            this.lstHataDosyasi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18});
            this.lstHataDosyasi.FullRowSelect = true;
            this.lstHataDosyasi.GridLines = true;
            this.lstHataDosyasi.Location = new System.Drawing.Point(234, 369);
            this.lstHataDosyasi.Name = "lstHataDosyasi";
            this.lstHataDosyasi.Size = new System.Drawing.Size(216, 180);
            this.lstHataDosyasi.TabIndex = 8;
            this.lstHataDosyasi.UseCompatibleStateImageBehavior = false;
            this.lstHataDosyasi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Kod";
            this.columnHeader16.Width = 37;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Key";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Data";
            this.columnHeader18.Width = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(234, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hata Dosyası";
            // 
            // timerMRecToNewMFile
            // 
            this.timerMRecToNewMFile.Interval = 12;
            this.timerMRecToNewMFile.Tick += new System.EventHandler(this.timerMRecToNewMFile_Tick);
            // 
            // timerTFileToTRec
            // 
            this.timerTFileToTRec.Interval = 12;
            this.timerTFileToTRec.Tick += new System.EventHandler(this.timerTFileToTRec_Tick);
            // 
            // timerTRecToHataDosyasi
            // 
            this.timerTRecToHataDosyasi.Interval = 12;
            this.timerTRecToHataDosyasi.Tick += new System.EventHandler(this.timerTRecToHataDosyasi_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(375, 555);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 13;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lstMRec
            // 
            this.lstMRec.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstMRec.FullRowSelect = true;
            this.lstMRec.GridLines = true;
            this.lstMRec.Location = new System.Drawing.Point(12, 265);
            this.lstMRec.Name = "lstMRec";
            this.lstMRec.Size = new System.Drawing.Size(216, 50);
            this.lstMRec.TabIndex = 8;
            this.lstMRec.UseCompatibleStateImageBehavior = false;
            this.lstMRec.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Key";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data";
            this.columnHeader2.Width = 142;
            // 
            // lstNewMFile
            // 
            this.lstNewMFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7});
            this.lstNewMFile.FullRowSelect = true;
            this.lstNewMFile.GridLines = true;
            this.lstNewMFile.Location = new System.Drawing.Point(12, 369);
            this.lstNewMFile.Name = "lstNewMFile";
            this.lstNewMFile.Size = new System.Drawing.Size(216, 180);
            this.lstNewMFile.TabIndex = 8;
            this.lstNewMFile.UseCompatibleStateImageBehavior = false;
            this.lstNewMFile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Key";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Data";
            this.columnHeader7.Width = 120;
            // 
            // timerTRecToNewMFile
            // 
            this.timerTRecToNewMFile.Interval = 12;
            this.timerTRecToNewMFile.Tick += new System.EventHandler(this.timerTRecToNewMFile_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Dosya Seçiniz";
            // 
            // timerSistemBeklet
            // 
            this.timerSistemBeklet.Interval = 1000;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 586);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(463, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 588);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Copyright © Fatih YILDIZHAN";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(234, 555);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 23);
            this.btnKaydet.TabIndex = 16;
            this.btnKaydet.Text = "New M-File Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 608);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnTFileOku);
            this.Controls.Add(this.btnMFileOku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTRec);
            this.Controls.Add(this.lstTFile);
            this.Controls.Add(this.lstHataDosyasi);
            this.Controls.Add(this.lstMRec);
            this.Controls.Add(this.lstNewMFile);
            this.Controls.Add(this.lstMFile);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M-File & T-File İşlemleri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerMFileToMRec;
        private System.Windows.Forms.ListView lstMFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstTFile;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnMFileOku;
        private System.Windows.Forms.Button btnTFileOku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lstTRec;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstHataDosyasi;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerMRecToNewMFile;
        private System.Windows.Forms.Timer timerTFileToTRec;
        private System.Windows.Forms.Timer timerTRecToHataDosyasi;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lstMRec;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lstNewMFile;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Timer timerTRecToNewMFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timerSistemBeklet;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnKaydet;
    }
}

