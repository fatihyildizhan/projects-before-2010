namespace FyDoxaAskerOtomasyonu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstAskerEklenen = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.lblTcNo = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnAskerEkle = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstBolgeEklenen = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBolgeKod = new System.Windows.Forms.TextBox();
            this.txtBolgeAd = new System.Windows.Forms.TextBox();
            this.lblBolgeKod = new System.Windows.Forms.Label();
            this.lblBolgeAd = new System.Windows.Forms.Label();
            this.btnBolgeEkle = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lstSonDurum = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGorevBelirle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(623, 583);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asker Dağıtım Otomasyonu";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(8, 23);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage1.Controls.Add(this.lstAskerEklenen);
            this.tabPage1.Controls.Add(this.txtTcNo);
            this.tabPage1.Controls.Add(this.lblTcNo);
            this.tabPage1.Controls.Add(this.txtSoyad);
            this.tabPage1.Controls.Add(this.txtAd);
            this.tabPage1.Controls.Add(this.lblSoyad);
            this.tabPage1.Controls.Add(this.lblAd);
            this.tabPage1.Controls.Add(this.btnAskerEkle);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(599, 518);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asker Ekle";
            // 
            // lstAskerEklenen
            // 
            this.lstAskerEklenen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstAskerEklenen.GridLines = true;
            this.lstAskerEklenen.HideSelection = false;
            this.lstAskerEklenen.Location = new System.Drawing.Point(8, 127);
            this.lstAskerEklenen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstAskerEklenen.Name = "lstAskerEklenen";
            this.lstAskerEklenen.Size = new System.Drawing.Size(579, 379);
            this.lstAskerEklenen.TabIndex = 19;
            this.lstAskerEklenen.UseCompatibleStateImageBehavior = false;
            this.lstAskerEklenen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Asker Adı";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Asker Soyadı";
            this.columnHeader11.Width = 117;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "T.C. No";
            this.columnHeader12.Width = 105;
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(107, 79);
            this.txtTcNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(192, 26);
            this.txtTcNo.TabIndex = 16;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            // 
            // lblTcNo
            // 
            this.lblTcNo.AutoSize = true;
            this.lblTcNo.Location = new System.Drawing.Point(13, 82);
            this.lblTcNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcNo.Name = "lblTcNo";
            this.lblTcNo.Size = new System.Drawing.Size(58, 23);
            this.lblTcNo.TabIndex = 15;
            this.lblTcNo.Text = "T.C No";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(107, 43);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(192, 26);
            this.txtSoyad.TabIndex = 13;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(107, 7);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(192, 26);
            this.txtAd.TabIndex = 12;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(13, 47);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 23);
            this.lblSoyad.TabIndex = 11;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(13, 11);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(30, 23);
            this.lblAd.TabIndex = 10;
            this.lblAd.Text = "Ad";
            // 
            // btnAskerEkle
            // 
            this.btnAskerEkle.Enabled = false;
            this.btnAskerEkle.Location = new System.Drawing.Point(339, 17);
            this.btnAskerEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAskerEkle.Name = "btnAskerEkle";
            this.btnAskerEkle.Size = new System.Drawing.Size(195, 37);
            this.btnAskerEkle.TabIndex = 9;
            this.btnAskerEkle.Text = "Asker Ekle >>";
            this.btnAskerEkle.UseVisualStyleBackColor = true;
            this.btnAskerEkle.Click += new System.EventHandler(this.btnAskerEkle_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage2.Controls.Add(this.lstBolgeEklenen);
            this.tabPage2.Controls.Add(this.txtBolgeKod);
            this.tabPage2.Controls.Add(this.txtBolgeAd);
            this.tabPage2.Controls.Add(this.lblBolgeKod);
            this.tabPage2.Controls.Add(this.lblBolgeAd);
            this.tabPage2.Controls.Add(this.btnBolgeEkle);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(599, 518);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bölge Ekle";
            // 
            // lstBolgeEklenen
            // 
            this.lstBolgeEklenen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.lstBolgeEklenen.GridLines = true;
            this.lstBolgeEklenen.HideSelection = false;
            this.lstBolgeEklenen.Location = new System.Drawing.Point(4, 114);
            this.lstBolgeEklenen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBolgeEklenen.Name = "lstBolgeEklenen";
            this.lstBolgeEklenen.Size = new System.Drawing.Size(583, 392);
            this.lstBolgeEklenen.TabIndex = 30;
            this.lstBolgeEklenen.UseCompatibleStateImageBehavior = false;
            this.lstBolgeEklenen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Bölge Adı";
            this.columnHeader7.Width = 184;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Bölge Kodu";
            this.columnHeader8.Width = 241;
            // 
            // txtBolgeKod
            // 
            this.txtBolgeKod.Location = new System.Drawing.Point(132, 54);
            this.txtBolgeKod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBolgeKod.Name = "txtBolgeKod";
            this.txtBolgeKod.Size = new System.Drawing.Size(192, 26);
            this.txtBolgeKod.TabIndex = 28;
            this.txtBolgeKod.TextChanged += new System.EventHandler(this.txtBolgeKod_TextChanged);
            // 
            // txtBolgeAd
            // 
            this.txtBolgeAd.Location = new System.Drawing.Point(132, 16);
            this.txtBolgeAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBolgeAd.Name = "txtBolgeAd";
            this.txtBolgeAd.Size = new System.Drawing.Size(192, 26);
            this.txtBolgeAd.TabIndex = 27;
            // 
            // lblBolgeKod
            // 
            this.lblBolgeKod.AutoSize = true;
            this.lblBolgeKod.Location = new System.Drawing.Point(20, 59);
            this.lblBolgeKod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBolgeKod.Name = "lblBolgeKod";
            this.lblBolgeKod.Size = new System.Drawing.Size(93, 23);
            this.lblBolgeKod.TabIndex = 26;
            this.lblBolgeKod.Text = "Bölge Kodu";
            // 
            // lblBolgeAd
            // 
            this.lblBolgeAd.AutoSize = true;
            this.lblBolgeAd.Location = new System.Drawing.Point(20, 20);
            this.lblBolgeAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBolgeAd.Name = "lblBolgeAd";
            this.lblBolgeAd.Size = new System.Drawing.Size(81, 23);
            this.lblBolgeAd.TabIndex = 25;
            this.lblBolgeAd.Text = "Bölge Adı";
            // 
            // btnBolgeEkle
            // 
            this.btnBolgeEkle.Enabled = false;
            this.btnBolgeEkle.Location = new System.Drawing.Point(363, 10);
            this.btnBolgeEkle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBolgeEkle.Name = "btnBolgeEkle";
            this.btnBolgeEkle.Size = new System.Drawing.Size(195, 37);
            this.btnBolgeEkle.TabIndex = 24;
            this.btnBolgeEkle.Text = "Bolge Ekle >>";
            this.btnBolgeEkle.UseVisualStyleBackColor = true;
            this.btnBolgeEkle.Click += new System.EventHandler(this.btnBolgeEkle_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Chocolate;
            this.tabPage3.Controls.Add(this.lstSonDurum);
            this.tabPage3.Controls.Add(this.btnGorevBelirle);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(599, 518);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asker&Bölge";
            // 
            // lstSonDurum
            // 
            this.lstSonDurum.BackColor = System.Drawing.SystemColors.Window;
            this.lstSonDurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader9,
            this.columnHeader15});
            this.lstSonDurum.GridLines = true;
            this.lstSonDurum.HideSelection = false;
            this.lstSonDurum.Location = new System.Drawing.Point(8, 7);
            this.lstSonDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstSonDurum.Name = "lstSonDurum";
            this.lstSonDurum.Size = new System.Drawing.Size(579, 390);
            this.lstSonDurum.TabIndex = 1;
            this.lstSonDurum.UseCompatibleStateImageBehavior = false;
            this.lstSonDurum.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Asker Adı";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asker Soyadı";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "T.C. NO";
            this.columnHeader4.Width = 88;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Bölge Adı";
            this.columnHeader9.Width = 84;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Bölge Kodu";
            this.columnHeader15.Width = 87;
            // 
            // btnGorevBelirle
            // 
            this.btnGorevBelirle.Enabled = false;
            this.btnGorevBelirle.Location = new System.Drawing.Point(39, 431);
            this.btnGorevBelirle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGorevBelirle.Name = "btnGorevBelirle";
            this.btnGorevBelirle.Size = new System.Drawing.Size(515, 55);
            this.btnGorevBelirle.TabIndex = 0;
            this.btnGorevBelirle.Text = "Gorev Yeri Belirle >>";
            this.btnGorevBelirle.UseVisualStyleBackColor = true;
            this.btnGorevBelirle.Click += new System.EventHandler(this.btnGorevBelirle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 613);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dağıtım Bölgesi";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstAskerEklenen;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label lblTcNo;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnAskerEkle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView lstBolgeEklenen;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtBolgeKod;
        private System.Windows.Forms.TextBox txtBolgeAd;
        private System.Windows.Forms.Label lblBolgeKod;
        private System.Windows.Forms.Label lblBolgeAd;
        private System.Windows.Forms.Button btnBolgeEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView lstSonDurum;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.Button btnGorevBelirle;
    }
}

