namespace DoxaKutuphane.Kitap
{
    partial class frmKitapAra
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkYayinEvi = new System.Windows.Forms.CheckBox();
            this.chkYazarAd = new System.Windows.Forms.CheckBox();
            this.chkKategori = new System.Windows.Forms.CheckBox();
            this.chkKitapAd = new System.Windows.Forms.CheckBox();
            this.cmbYayinEviAra = new System.Windows.Forms.ComboBox();
            this.cmbYazarAdAra = new System.Windows.Forms.ComboBox();
            this.cmbKategoriAra = new System.Windows.Forms.ComboBox();
            this.cmbKitapAdAra = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Arama Formu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 239);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkYayinEvi);
            this.groupBox2.Controls.Add(this.chkYazarAd);
            this.groupBox2.Controls.Add(this.chkKategori);
            this.groupBox2.Controls.Add(this.chkKitapAd);
            this.groupBox2.Controls.Add(this.cmbYayinEviAra);
            this.groupBox2.Controls.Add(this.cmbYazarAdAra);
            this.groupBox2.Controls.Add(this.cmbKategoriAra);
            this.groupBox2.Controls.Add(this.cmbKitapAdAra);
            this.groupBox2.Location = new System.Drawing.Point(514, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Kriterleri";
            // 
            // chkYayinEvi
            // 
            this.chkYayinEvi.AutoSize = true;
            this.chkYayinEvi.Location = new System.Drawing.Point(20, 111);
            this.chkYayinEvi.Name = "chkYayinEvi";
            this.chkYayinEvi.Size = new System.Drawing.Size(70, 17);
            this.chkYayinEvi.TabIndex = 21;
            this.chkYayinEvi.Text = "Yayın Evi";
            this.chkYayinEvi.UseVisualStyleBackColor = true;
            // 
            // chkYazarAd
            // 
            this.chkYazarAd.AutoSize = true;
            this.chkYazarAd.Location = new System.Drawing.Point(20, 84);
            this.chkYazarAd.Name = "chkYazarAd";
            this.chkYazarAd.Size = new System.Drawing.Size(71, 17);
            this.chkYazarAd.TabIndex = 20;
            this.chkYazarAd.Text = "Yazar Adı";
            this.chkYazarAd.UseVisualStyleBackColor = true;
            // 
            // chkKategori
            // 
            this.chkKategori.AutoSize = true;
            this.chkKategori.Location = new System.Drawing.Point(20, 57);
            this.chkKategori.Name = "chkKategori";
            this.chkKategori.Size = new System.Drawing.Size(65, 17);
            this.chkKategori.TabIndex = 19;
            this.chkKategori.Text = "Kategori";
            this.chkKategori.UseVisualStyleBackColor = true;
            // 
            // chkKitapAd
            // 
            this.chkKitapAd.AutoSize = true;
            this.chkKitapAd.Location = new System.Drawing.Point(20, 30);
            this.chkKitapAd.Name = "chkKitapAd";
            this.chkKitapAd.Size = new System.Drawing.Size(68, 17);
            this.chkKitapAd.TabIndex = 18;
            this.chkKitapAd.Text = "Kitap Adı";
            this.chkKitapAd.UseVisualStyleBackColor = true;
            // 
            // cmbYayinEviAra
            // 
            this.cmbYayinEviAra.FormattingEnabled = true;
            this.cmbYayinEviAra.Location = new System.Drawing.Point(116, 109);
            this.cmbYayinEviAra.Name = "cmbYayinEviAra";
            this.cmbYayinEviAra.Size = new System.Drawing.Size(121, 21);
            this.cmbYayinEviAra.TabIndex = 17;
            // 
            // cmbYazarAdAra
            // 
            this.cmbYazarAdAra.FormattingEnabled = true;
            this.cmbYazarAdAra.Location = new System.Drawing.Point(116, 82);
            this.cmbYazarAdAra.Name = "cmbYazarAdAra";
            this.cmbYazarAdAra.Size = new System.Drawing.Size(121, 21);
            this.cmbYazarAdAra.TabIndex = 16;
            // 
            // cmbKategoriAra
            // 
            this.cmbKategoriAra.FormattingEnabled = true;
            this.cmbKategoriAra.Location = new System.Drawing.Point(116, 55);
            this.cmbKategoriAra.Name = "cmbKategoriAra";
            this.cmbKategoriAra.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriAra.TabIndex = 15;
            // 
            // cmbKitapAdAra
            // 
            this.cmbKitapAdAra.FormattingEnabled = true;
            this.cmbKitapAdAra.Location = new System.Drawing.Point(116, 28);
            this.cmbKitapAdAra.Name = "cmbKitapAdAra";
            this.cmbKitapAdAra.Size = new System.Drawing.Size(121, 21);
            this.cmbKitapAdAra.TabIndex = 14;
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(514, 189);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(264, 69);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "ARA >>>";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // frmKitapAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 297);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKitapAra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKitapAra";
            this.Load += new System.EventHandler(this.frmKitapAra_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkYayinEvi;
        private System.Windows.Forms.CheckBox chkYazarAd;
        private System.Windows.Forms.CheckBox chkKategori;
        private System.Windows.Forms.CheckBox chkKitapAd;
        private System.Windows.Forms.ComboBox cmbYayinEviAra;
        private System.Windows.Forms.ComboBox cmbYazarAdAra;
        private System.Windows.Forms.ComboBox cmbKategoriAra;
        private System.Windows.Forms.ComboBox cmbKitapAdAra;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}