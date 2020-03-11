namespace FyDoxaFileToByteToSQL
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaKaydetmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToByteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaListelemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaKaydetmeToolStripMenuItem,
            this.dosyaListelemeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaKaydetmeToolStripMenuItem
            // 
            this.dosyaKaydetmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToByteToolStripMenuItem});
            this.dosyaKaydetmeToolStripMenuItem.Name = "dosyaKaydetmeToolStripMenuItem";
            this.dosyaKaydetmeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dosyaKaydetmeToolStripMenuItem.Text = "File To Byte";
            // 
            // convertToByteToolStripMenuItem
            // 
            this.convertToByteToolStripMenuItem.Name = "convertToByteToolStripMenuItem";
            this.convertToByteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.convertToByteToolStripMenuItem.Text = "Convert To Byte";
            this.convertToByteToolStripMenuItem.Click += new System.EventHandler(this.convertToByteToolStripMenuItem_Click);
            // 
            // dosyaListelemeToolStripMenuItem
            // 
            this.dosyaListelemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convertToFileToolStripMenuItem});
            this.dosyaListelemeToolStripMenuItem.Name = "dosyaListelemeToolStripMenuItem";
            this.dosyaListelemeToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dosyaListelemeToolStripMenuItem.Text = "Byte To File";
            // 
            // convertToFileToolStripMenuItem
            // 
            this.convertToFileToolStripMenuItem.Name = "convertToFileToolStripMenuItem";
            this.convertToFileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.convertToFileToolStripMenuItem.Text = "Convert To File";
            this.convertToFileToolStripMenuItem.Click += new System.EventHandler(this.convertToFileToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 181);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form FyDoxa Convert To Byte or File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaKaydetmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToByteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaListelemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToFileToolStripMenuItem;
    }
}

