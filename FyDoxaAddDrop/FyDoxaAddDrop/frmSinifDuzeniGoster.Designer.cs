namespace FyDoxaAddDrop
{
    partial class frmSinifDuzeniGoster
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
            this.pnlSinifDuzeni = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlSinifDuzeni
            // 
            this.pnlSinifDuzeni.AllowDrop = true;
            this.pnlSinifDuzeni.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSinifDuzeni.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSinifDuzeni.Location = new System.Drawing.Point(12, 12);
            this.pnlSinifDuzeni.Name = "pnlSinifDuzeni";
            this.pnlSinifDuzeni.Size = new System.Drawing.Size(450, 390);
            this.pnlSinifDuzeni.TabIndex = 2;
            // 
            // frmSinifDuzeniGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 408);
            this.Controls.Add(this.pnlSinifDuzeni);
            this.Name = "frmSinifDuzeniGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSinifDuzeniGoster";
            this.Load += new System.EventHandler(this.frmSinifDuzeniGoster_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSinifDuzeni;
    }
}