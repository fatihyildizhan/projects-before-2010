namespace DoxaKutuphane
{
    partial class frmYayinEviGuncelle
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYynEvIdGnc = new System.Windows.Forms.TextBox();
            this.txtYynEvAdGnc = new System.Windows.Forms.TextBox();
            this.txtYynEvAdrsGnc = new System.Windows.Forms.TextBox();
            this.btnYayinEviGnc = new System.Windows.Forms.Button();
            this.btnYynEviListele = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYynEviListele);
            this.groupBox1.Controls.Add(this.btnYayinEviGnc);
            this.groupBox1.Controls.Add(this.txtYynEvAdrsGnc);
            this.groupBox1.Controls.Add(this.txtYynEvAdGnc);
            this.groupBox1.Controls.Add(this.txtYynEvIdGnc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yayın Evi Güncelle";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(267, 255);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Yayın Evi Id";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Yayın Evi Adı";
            this.columnHeader2.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adres";
            this.columnHeader3.Width = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yayın Evi Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yayın Evi Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yayın Evi Adresi";
            // 
            // txtYynEvIdGnc
            // 
            this.txtYynEvIdGnc.Location = new System.Drawing.Point(382, 51);
            this.txtYynEvIdGnc.Name = "txtYynEvIdGnc";
            this.txtYynEvIdGnc.ReadOnly = true;
            this.txtYynEvIdGnc.Size = new System.Drawing.Size(152, 20);
            this.txtYynEvIdGnc.TabIndex = 5;
            // 
            // txtYynEvAdGnc
            // 
            this.txtYynEvAdGnc.Location = new System.Drawing.Point(382, 92);
            this.txtYynEvAdGnc.Name = "txtYynEvAdGnc";
            this.txtYynEvAdGnc.Size = new System.Drawing.Size(152, 20);
            this.txtYynEvAdGnc.TabIndex = 6;
            // 
            // txtYynEvAdrsGnc
            // 
            this.txtYynEvAdrsGnc.Location = new System.Drawing.Point(384, 138);
            this.txtYynEvAdrsGnc.Multiline = true;
            this.txtYynEvAdrsGnc.Name = "txtYynEvAdrsGnc";
            this.txtYynEvAdrsGnc.Size = new System.Drawing.Size(150, 90);
            this.txtYynEvAdrsGnc.TabIndex = 7;
            // 
            // btnYayinEviGnc
            // 
            this.btnYayinEviGnc.Font = new System.Drawing.Font("Last Ninja", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYayinEviGnc.Location = new System.Drawing.Point(280, 236);
            this.btnYayinEviGnc.Name = "btnYayinEviGnc";
            this.btnYayinEviGnc.Size = new System.Drawing.Size(254, 38);
            this.btnYayinEviGnc.TabIndex = 8;
            this.btnYayinEviGnc.Text = "Güncelle ***";
            this.btnYayinEviGnc.UseVisualStyleBackColor = true;
            this.btnYayinEviGnc.Click += new System.EventHandler(this.btnYayinEviGnc_Click);
            // 
            // btnYynEviListele
            // 
            this.btnYynEviListele.Location = new System.Drawing.Point(278, 19);
            this.btnYynEviListele.Name = "btnYynEviListele";
            this.btnYynEviListele.Size = new System.Drawing.Size(256, 23);
            this.btnYynEviListele.TabIndex = 9;
            this.btnYynEviListele.Text = "Yayın Evlerini Listele";
            this.btnYynEviListele.UseVisualStyleBackColor = true;
            this.btnYynEviListele.Click += new System.EventHandler(this.btnYynEviListele_Click);
            // 
            // frmYayinEviGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 308);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYayinEviGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYayinEviGuncelle";
            this.Load += new System.EventHandler(this.frmYayinEviGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYayinEviGnc;
        private System.Windows.Forms.TextBox txtYynEvAdrsGnc;
        private System.Windows.Forms.TextBox txtYynEvAdGnc;
        private System.Windows.Forms.TextBox txtYynEvIdGnc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnYynEviListele;


    }
}