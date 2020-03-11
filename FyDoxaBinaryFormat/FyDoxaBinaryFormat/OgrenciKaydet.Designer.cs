namespace FyDoxaBinaryFormat
{
    partial class OgrenciKaydet
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
            this.btnOgrenciOlustur = new System.Windows.Forms.Button();
            this.txtOgrBolum = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciOlustur
            // 
            this.btnOgrenciOlustur.Location = new System.Drawing.Point(13, 13);
            this.btnOgrenciOlustur.Name = "btnOgrenciOlustur";
            this.btnOgrenciOlustur.Size = new System.Drawing.Size(259, 37);
            this.btnOgrenciOlustur.TabIndex = 0;
            this.btnOgrenciOlustur.Text = "Öğrenci Oluştur";
            this.btnOgrenciOlustur.UseVisualStyleBackColor = true;
            this.btnOgrenciOlustur.Click += new System.EventHandler(this.btnOgrenciOlustur_Click);
            // 
            // txtOgrBolum
            // 
            this.txtOgrBolum.Location = new System.Drawing.Point(145, 159);
            this.txtOgrBolum.Name = "txtOgrBolum";
            this.txtOgrBolum.Size = new System.Drawing.Size(100, 20);
            this.txtOgrBolum.TabIndex = 16;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(145, 133);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgrNo.TabIndex = 15;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(145, 107);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtOgrSoyad.TabIndex = 14;
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(145, 81);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(100, 20);
            this.txtOgrAd.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Öğrenci Bölümü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Öğrenci Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Öğrenci Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // btnOgrKaydet
            // 
            this.btnOgrKaydet.Location = new System.Drawing.Point(12, 215);
            this.btnOgrKaydet.Name = "btnOgrKaydet";
            this.btnOgrKaydet.Size = new System.Drawing.Size(259, 37);
            this.btnOgrKaydet.TabIndex = 17;
            this.btnOgrKaydet.Text = "Öğrencileri Kaydet";
            this.btnOgrKaydet.UseVisualStyleBackColor = true;
            this.btnOgrKaydet.Click += new System.EventHandler(this.btnOgrKaydet_Click);
            // 
            // OgrenciKaydet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnOgrKaydet);
            this.Controls.Add(this.txtOgrBolum);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOgrenciOlustur);
            this.Name = "OgrenciKaydet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciKaydet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciOlustur;
        private System.Windows.Forms.TextBox txtOgrBolum;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrKaydet;
    }
}