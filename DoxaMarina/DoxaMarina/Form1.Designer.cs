namespace DoxaMarina
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
            this.yatİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yatAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(370, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yatİşlemleriToolStripMenuItem
            // 
            this.yatİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yatEkleToolStripMenuItem,
            this.yatAraToolStripMenuItem});
            this.yatİşlemleriToolStripMenuItem.Name = "yatİşlemleriToolStripMenuItem";
            this.yatİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.yatİşlemleriToolStripMenuItem.Text = "Yat İşlemleri";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriAraToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // yatEkleToolStripMenuItem
            // 
            this.yatEkleToolStripMenuItem.Name = "yatEkleToolStripMenuItem";
            this.yatEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yatEkleToolStripMenuItem.Text = "Yat Ekle";
            this.yatEkleToolStripMenuItem.Click += new System.EventHandler(this.yatEkleToolStripMenuItem_Click);
            // 
            // yatAraToolStripMenuItem
            // 
            this.yatAraToolStripMenuItem.Name = "yatAraToolStripMenuItem";
            this.yatAraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.yatAraToolStripMenuItem.Text = "Yat Ara";
            this.yatAraToolStripMenuItem.Click += new System.EventHandler(this.yatAraToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriAraToolStripMenuItem
            // 
            this.müşteriAraToolStripMenuItem.Name = "müşteriAraToolStripMenuItem";
            this.müşteriAraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.müşteriAraToolStripMenuItem.Text = "Müşteri Ara";
            this.müşteriAraToolStripMenuItem.Click += new System.EventHandler(this.müşteriAraToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 405);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yatİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yatAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriAraToolStripMenuItem;
    }
}

