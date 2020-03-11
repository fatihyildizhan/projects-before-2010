namespace parmakYarisi
{
    partial class lastGameForm
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
            this.lblWPM = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.LinkLabel();
            this.lblAccuracy = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWPM
            // 
            this.lblWPM.AutoSize = true;
            this.lblWPM.BackColor = System.Drawing.Color.White;
            this.lblWPM.Location = new System.Drawing.Point(213, 116);
            this.lblWPM.Name = "lblWPM";
            this.lblWPM.Size = new System.Drawing.Size(10, 13);
            this.lblWPM.TabIndex = 1;
            this.lblWPM.Text = ".";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.LinkColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(12, 198);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(276, 22);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = true;
            this.btnClose.Text = "Kapat";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.VisitedLinkColor = System.Drawing.Color.Black;
            this.btnClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnClose_LinkClicked);
            // 
            // lblAccuracy
            // 
            this.lblAccuracy.AutoSize = true;
            this.lblAccuracy.BackColor = System.Drawing.Color.White;
            this.lblAccuracy.Location = new System.Drawing.Point(213, 136);
            this.lblAccuracy.Name = "lblAccuracy";
            this.lblAccuracy.Size = new System.Drawing.Size(10, 13);
            this.lblAccuracy.TabIndex = 3;
            this.lblAccuracy.Text = ".";
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.BackColor = System.Drawing.Color.White;
            this.lblXP.Location = new System.Drawing.Point(213, 156);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(10, 13);
            this.lblXP.TabIndex = 4;
            this.lblXP.Text = ".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::parmakYarisi.Properties.Resources.lastRace1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 230);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(12, 84);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(276, 23);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = ".";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lastGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 230);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.lblAccuracy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWPM);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lastGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lastGameForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWPM;
        private System.Windows.Forms.LinkLabel btnClose;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label lblInfo;
    }
}