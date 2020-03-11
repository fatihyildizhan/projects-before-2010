namespace parmakYarisi
{
    partial class startForm
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
            this.components = new System.ComponentModel.Container();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.imgTraffic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTraffic)).BeginInit();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.Interval = 1000;
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(228, 109);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(118, 46);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "3";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgTraffic
            // 
            this.imgTraffic.BackColor = System.Drawing.Color.Transparent;
            this.imgTraffic.Image = global::parmakYarisi.Properties.Resources.red;
            this.imgTraffic.Location = new System.Drawing.Point(10, 9);
            this.imgTraffic.Name = "imgTraffic";
            this.imgTraffic.Size = new System.Drawing.Size(208, 248);
            this.imgTraffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTraffic.TabIndex = 1;
            this.imgTraffic.TabStop = false;
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::parmakYarisi.Properties.Resources.startForm;
            this.ClientSize = new System.Drawing.Size(360, 270);
            this.Controls.Add(this.imgTraffic);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "startForm";
            this.Load += new System.EventHandler(this.startForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgTraffic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox imgTraffic;
    }
}