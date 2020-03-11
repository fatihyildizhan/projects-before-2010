namespace FyDoxaAddDrop
{
    partial class frmOgrenciAdi
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
            this.btnOgrAdBelirle = new System.Windows.Forms.Button();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOgrAdBelirle
            // 
            this.btnOgrAdBelirle.Location = new System.Drawing.Point(15, 32);
            this.btnOgrAdBelirle.Name = "btnOgrAdBelirle";
            this.btnOgrAdBelirle.Size = new System.Drawing.Size(216, 23);
            this.btnOgrAdBelirle.TabIndex = 0;
            this.btnOgrAdBelirle.Text = "Kaydet";
            this.btnOgrAdBelirle.UseVisualStyleBackColor = true;
            this.btnOgrAdBelirle.Click += new System.EventHandler(this.btnOgrAdBelirle_Click);
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(83, 6);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(148, 20);
            this.txtOgrenciAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı:";
            // 
            // frmOgrenciAdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 60);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOgrenciAd);
            this.Controls.Add(this.btnOgrAdBelirle);
            this.Name = "frmOgrenciAdi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOgrenciAdi";
            this.Load += new System.EventHandler(this.frmOgrenciAdi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrAdBelirle;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.Label label1;
    }
}