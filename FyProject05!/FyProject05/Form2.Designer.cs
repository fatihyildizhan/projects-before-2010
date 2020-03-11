namespace FyProject05
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsturun = new System.Windows.Forms.ListBox();
            this.lstfiyat = new System.Windows.Forms.ListBox();
            this.labe3 = new System.Windows.Forms.Label();
            this.nd_adet = new System.Windows.Forms.NumericUpDown();
            this.lstsepet = new System.Windows.Forms.ListBox();
            this.btnsepet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.btnsatis = new System.Windows.Forms.Button();
            this.txtindirim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.satis_detayi = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nd_adet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürünler";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fiyatlar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lsturun
            // 
            this.lsturun.BackColor = System.Drawing.Color.SlateGray;
            this.lsturun.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsturun.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lsturun.FormattingEnabled = true;
            this.lsturun.ItemHeight = 17;
            this.lsturun.Location = new System.Drawing.Point(15, 57);
            this.lsturun.Name = "lsturun";
            this.lsturun.Size = new System.Drawing.Size(136, 123);
            this.lsturun.TabIndex = 2;
            // 
            // lstfiyat
            // 
            this.lstfiyat.BackColor = System.Drawing.Color.SlateGray;
            this.lstfiyat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstfiyat.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstfiyat.FormattingEnabled = true;
            this.lstfiyat.ItemHeight = 17;
            this.lstfiyat.Location = new System.Drawing.Point(175, 57);
            this.lstfiyat.Name = "lstfiyat";
            this.lstfiyat.Size = new System.Drawing.Size(135, 123);
            this.lstfiyat.TabIndex = 3;
            // 
            // labe3
            // 
            this.labe3.AutoSize = true;
            this.labe3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labe3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labe3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labe3.Location = new System.Drawing.Point(100, 208);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(51, 23);
            this.labe3.TabIndex = 4;
            this.labe3.Text = "Adet";
            this.labe3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nd_adet
            // 
            this.nd_adet.BackColor = System.Drawing.Color.Black;
            this.nd_adet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nd_adet.Location = new System.Drawing.Point(175, 210);
            this.nd_adet.Name = "nd_adet";
            this.nd_adet.Size = new System.Drawing.Size(61, 20);
            this.nd_adet.TabIndex = 5;
            // 
            // lstsepet
            // 
            this.lstsepet.BackColor = System.Drawing.Color.SlateGray;
            this.lstsepet.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstsepet.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstsepet.FormattingEnabled = true;
            this.lstsepet.ItemHeight = 17;
            this.lstsepet.Location = new System.Drawing.Point(488, 57);
            this.lstsepet.Name = "lstsepet";
            this.lstsepet.Size = new System.Drawing.Size(227, 89);
            this.lstsepet.TabIndex = 6;
            // 
            // btnsepet
            // 
            this.btnsepet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsepet.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsepet.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnsepet.Location = new System.Drawing.Point(330, 92);
            this.btnsepet.Name = "btnsepet";
            this.btnsepet.Size = new System.Drawing.Size(138, 33);
            this.btnsepet.TabIndex = 7;
            this.btnsepet.Text = ">>>>>";
            this.btnsepet.UseVisualStyleBackColor = false;
            this.btnsepet.Click += new System.EventHandler(this.btnsepet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(378, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Toplam";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtToplam
            // 
            this.txtToplam.BackColor = System.Drawing.Color.Black;
            this.txtToplam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToplam.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtToplam.Location = new System.Drawing.Point(488, 170);
            this.txtToplam.Multiline = true;
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(120, 39);
            this.txtToplam.TabIndex = 9;
            this.txtToplam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsatis
            // 
            this.btnsatis.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsatis.Font = new System.Drawing.Font("Arial Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsatis.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnsatis.Location = new System.Drawing.Point(382, 290);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(231, 44);
            this.btnsatis.TabIndex = 10;
            this.btnsatis.Text = "Satis";
            this.btnsatis.UseVisualStyleBackColor = false;
            this.btnsatis.Click += new System.EventHandler(this.btnsatis_Click);
            // 
            // txtindirim
            // 
            this.txtindirim.BackColor = System.Drawing.Color.Black;
            this.txtindirim.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtindirim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtindirim.Location = new System.Drawing.Point(488, 228);
            this.txtindirim.Multiline = true;
            this.txtindirim.Name = "txtindirim";
            this.txtindirim.Size = new System.Drawing.Size(58, 28);
            this.txtindirim.TabIndex = 11;
            this.txtindirim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(378, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "İndirim";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(378, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ekle";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(488, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sepet";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // satis_detayi
            // 
            this.satis_detayi.BackColor = System.Drawing.Color.Black;
            this.satis_detayi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satis_detayi.ForeColor = System.Drawing.Color.White;
            this.satis_detayi.FormattingEnabled = true;
            this.satis_detayi.ItemHeight = 22;
            this.satis_detayi.Location = new System.Drawing.Point(721, 57);
            this.satis_detayi.Name = "satis_detayi";
            this.satis_detayi.Size = new System.Drawing.Size(112, 70);
            this.satis_detayi.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(721, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tutar";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(969, 365);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.satis_detayi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtindirim);
            this.Controls.Add(this.btnsatis);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsepet);
            this.Controls.Add(this.lstsepet);
            this.Controls.Add(this.nd_adet);
            this.Controls.Add(this.labe3);
            this.Controls.Add(this.lstfiyat);
            this.Controls.Add(this.lsturun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nd_adet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsturun;
        private System.Windows.Forms.ListBox lstfiyat;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.NumericUpDown nd_adet;
        private System.Windows.Forms.ListBox lstsepet;
        private System.Windows.Forms.Button btnsepet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.TextBox txtindirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox satis_detayi;
        private System.Windows.Forms.Label label7;
    }
}