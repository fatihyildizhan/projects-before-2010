namespace DoxaKutuphane
{
    partial class frmYayinEviSil
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
            this.btnYayinEvSil = new System.Windows.Forms.Button();
            this.cmbYayinEvSil = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbYayinEvSil);
            this.groupBox1.Controls.Add(this.btnYayinEvSil);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yayin Evi Sil";
            // 
            // btnYayinEvSil
            // 
            this.btnYayinEvSil.Font = new System.Drawing.Font("MS Mincho", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYayinEvSil.Location = new System.Drawing.Point(6, 84);
            this.btnYayinEvSil.Name = "btnYayinEvSil";
            this.btnYayinEvSil.Size = new System.Drawing.Size(255, 57);
            this.btnYayinEvSil.TabIndex = 0;
            this.btnYayinEvSil.Text = "Yayın Evi Sil ";
            this.btnYayinEvSil.UseVisualStyleBackColor = true;
            this.btnYayinEvSil.Click += new System.EventHandler(this.btnYayinEvSil_Click);
            // 
            // cmbYayinEvSil
            // 
            this.cmbYayinEvSil.FormattingEnabled = true;
            this.cmbYayinEvSil.Location = new System.Drawing.Point(118, 25);
            this.cmbYayinEvSil.Name = "cmbYayinEvSil";
            this.cmbYayinEvSil.Size = new System.Drawing.Size(121, 21);
            this.cmbYayinEvSil.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yayın Evi Seçiniz";
            // 
            // frmYayinEviSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYayinEviSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYayinEviSil";
            this.Load += new System.EventHandler(this.frmYayinEviSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYayinEvSil;
        private System.Windows.Forms.Button btnYayinEvSil;
    }
}