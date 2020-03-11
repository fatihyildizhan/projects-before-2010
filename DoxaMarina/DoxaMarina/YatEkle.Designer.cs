namespace DoxaMarina
{
    partial class YatEkle
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
            this.txtIskeleId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKabinSayisi = new System.Windows.Forms.TextBox();
            this.txtYatBoy = new System.Windows.Forms.TextBox();
            this.txtYatAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIskeleId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKabinSayisi);
            this.groupBox1.Controls.Add(this.txtYatBoy);
            this.groupBox1.Controls.Add(this.txtYatAd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doxa Marina";
            // 
            // txtIskeleId
            // 
            this.txtIskeleId.Location = new System.Drawing.Point(105, 106);
            this.txtIskeleId.Name = "txtIskeleId";
            this.txtIskeleId.Size = new System.Drawing.Size(100, 20);
            this.txtIskeleId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "İskele No";
            // 
            // txtKabinSayisi
            // 
            this.txtKabinSayisi.Location = new System.Drawing.Point(105, 80);
            this.txtKabinSayisi.Name = "txtKabinSayisi";
            this.txtKabinSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKabinSayisi.TabIndex = 8;
            // 
            // txtYatBoy
            // 
            this.txtYatBoy.Location = new System.Drawing.Point(105, 54);
            this.txtYatBoy.Name = "txtYatBoy";
            this.txtYatBoy.Size = new System.Drawing.Size(100, 20);
            this.txtYatBoy.TabIndex = 7;
            // 
            // txtYatAd
            // 
            this.txtYatAd.Location = new System.Drawing.Point(105, 28);
            this.txtYatAd.Name = "txtYatAd";
            this.txtYatAd.Size = new System.Drawing.Size(100, 20);
            this.txtYatAd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Boyu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "KabinSayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "YatAdı";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(17, 182);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 30);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Yat Ekle   >>";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // YatEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 297);
            this.Controls.Add(this.groupBox1);
            this.Name = "YatEkle";
            this.Text = "YatEkle";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtKabinSayisi;
        private System.Windows.Forms.TextBox txtYatBoy;
        private System.Windows.Forms.TextBox txtYatAd;
        private System.Windows.Forms.TextBox txtIskeleId;
        private System.Windows.Forms.Label label1;
    }
}