namespace DoxaKutuphane
{
    partial class frmYazarSil
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
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbYazarSecyzrSil = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYazarSil);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbYazarSecyzrSil);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yazar Sil";
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Location = new System.Drawing.Point(21, 74);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(192, 23);
            this.btnYazarSil.TabIndex = 2;
            this.btnYazarSil.Text = "Yazar Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yazar Seç";
            // 
            // cmbYazarSecyzrSil
            // 
            this.cmbYazarSecyzrSil.FormattingEnabled = true;
            this.cmbYazarSecyzrSil.Location = new System.Drawing.Point(92, 34);
            this.cmbYazarSecyzrSil.Name = "cmbYazarSecyzrSil";
            this.cmbYazarSecyzrSil.Size = new System.Drawing.Size(121, 21);
            this.cmbYazarSecyzrSil.TabIndex = 0;
            // 
            // frmYazarSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmYazarSil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYazarSil";
            this.Load += new System.EventHandler(this.frmYazarSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbYazarSecyzrSil;
    }
}