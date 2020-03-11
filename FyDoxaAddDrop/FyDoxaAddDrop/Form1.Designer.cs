namespace FyDoxaAddDrop
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
            this.pnlSinifBilgileri = new System.Windows.Forms.Panel();
            this.pnlSinifDuzeni = new System.Windows.Forms.Panel();
            this.pnlKontrolPaneli = new System.Windows.Forms.Panel();
            this.btnSinifKaydet = new System.Windows.Forms.Button();
            this.txtSinifIsmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSinifGoster = new System.Windows.Forms.Button();
            this.cmbSinifListesi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBilgilendirme = new System.Windows.Forms.Label();
            this.pnlKontrolPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSinifBilgileri
            // 
            this.pnlSinifBilgileri.BackColor = System.Drawing.SystemColors.Info;
            this.pnlSinifBilgileri.Location = new System.Drawing.Point(12, 12);
            this.pnlSinifBilgileri.Name = "pnlSinifBilgileri";
            this.pnlSinifBilgileri.Size = new System.Drawing.Size(153, 488);
            this.pnlSinifBilgileri.TabIndex = 0;
            // 
            // pnlSinifDuzeni
            // 
            this.pnlSinifDuzeni.AllowDrop = true;
            this.pnlSinifDuzeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSinifDuzeni.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSinifDuzeni.Location = new System.Drawing.Point(171, 110);
            this.pnlSinifDuzeni.Name = "pnlSinifDuzeni";
            this.pnlSinifDuzeni.Size = new System.Drawing.Size(450, 390);
            this.pnlSinifDuzeni.TabIndex = 1;
            this.pnlSinifDuzeni.DragOver += new System.Windows.Forms.DragEventHandler(this.pnlSinifDuzeni_DragOver);
            this.pnlSinifDuzeni.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlSinifDuzeni_DragDrop);
            // 
            // pnlKontrolPaneli
            // 
            this.pnlKontrolPaneli.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlKontrolPaneli.Controls.Add(this.lblBilgilendirme);
            this.pnlKontrolPaneli.Controls.Add(this.label2);
            this.pnlKontrolPaneli.Controls.Add(this.cmbSinifListesi);
            this.pnlKontrolPaneli.Controls.Add(this.btnSinifGoster);
            this.pnlKontrolPaneli.Controls.Add(this.label1);
            this.pnlKontrolPaneli.Controls.Add(this.txtSinifIsmi);
            this.pnlKontrolPaneli.Controls.Add(this.btnSinifKaydet);
            this.pnlKontrolPaneli.Location = new System.Drawing.Point(172, 13);
            this.pnlKontrolPaneli.Name = "pnlKontrolPaneli";
            this.pnlKontrolPaneli.Size = new System.Drawing.Size(449, 91);
            this.pnlKontrolPaneli.TabIndex = 2;
            // 
            // btnSinifKaydet
            // 
            this.btnSinifKaydet.Enabled = false;
            this.btnSinifKaydet.Location = new System.Drawing.Point(15, 36);
            this.btnSinifKaydet.Name = "btnSinifKaydet";
            this.btnSinifKaydet.Size = new System.Drawing.Size(149, 23);
            this.btnSinifKaydet.TabIndex = 0;
            this.btnSinifKaydet.Text = "Sınıfı Kaydet";
            this.btnSinifKaydet.UseVisualStyleBackColor = true;
            this.btnSinifKaydet.Click += new System.EventHandler(this.btnSinifKaydet_Click);
            // 
            // txtSinifIsmi
            // 
            this.txtSinifIsmi.BackColor = System.Drawing.SystemColors.Info;
            this.txtSinifIsmi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSinifIsmi.Location = new System.Drawing.Point(64, 10);
            this.txtSinifIsmi.Name = "txtSinifIsmi";
            this.txtSinifIsmi.ReadOnly = true;
            this.txtSinifIsmi.Size = new System.Drawing.Size(100, 20);
            this.txtSinifIsmi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sınıf İsmi:";
            // 
            // btnSinifGoster
            // 
            this.btnSinifGoster.Enabled = false;
            this.btnSinifGoster.Location = new System.Drawing.Point(202, 10);
            this.btnSinifGoster.Name = "btnSinifGoster";
            this.btnSinifGoster.Size = new System.Drawing.Size(75, 23);
            this.btnSinifGoster.TabIndex = 3;
            this.btnSinifGoster.Text = "Sınıf Göster";
            this.btnSinifGoster.UseVisualStyleBackColor = true;
            this.btnSinifGoster.Click += new System.EventHandler(this.btnSinifGoster_Click);
            // 
            // cmbSinifListesi
            // 
            this.cmbSinifListesi.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSinifListesi.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cmbSinifListesi.FormattingEnabled = true;
            this.cmbSinifListesi.Location = new System.Drawing.Point(283, 9);
            this.cmbSinifListesi.Name = "cmbSinifListesi";
            this.cmbSinifListesi.Size = new System.Drawing.Size(152, 21);
            this.cmbSinifListesi.TabIndex = 4;
            this.cmbSinifListesi.SelectedIndexChanged += new System.EventHandler(this.cmbSinifListesi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bilgilendirme :";
            // 
            // lblBilgilendirme
            // 
            this.lblBilgilendirme.AutoSize = true;
            this.lblBilgilendirme.ForeColor = System.Drawing.Color.Firebrick;
            this.lblBilgilendirme.Location = new System.Drawing.Point(97, 70);
            this.lblBilgilendirme.Name = "lblBilgilendirme";
            this.lblBilgilendirme.Size = new System.Drawing.Size(287, 13);
            this.lblBilgilendirme.TabIndex = 6;
            this.lblBilgilendirme.Text = "Bilgilendirmeyi Görüntülemek İçin Butonların Üzerine Geliniz!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 512);
            this.Controls.Add(this.pnlKontrolPaneli);
            this.Controls.Add(this.pnlSinifDuzeni);
            this.Controls.Add(this.pnlSinifBilgileri);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FyDoxa Add & Drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlKontrolPaneli.ResumeLayout(false);
            this.pnlKontrolPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSinifBilgileri;
        private System.Windows.Forms.Panel pnlSinifDuzeni;
        private System.Windows.Forms.Panel pnlKontrolPaneli;
        private System.Windows.Forms.ComboBox cmbSinifListesi;
        private System.Windows.Forms.Button btnSinifGoster;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSinifIsmi;
        private System.Windows.Forms.Button btnSinifKaydet;
        private System.Windows.Forms.Label lblBilgilendirme;
        private System.Windows.Forms.Label label2;
    }
}

