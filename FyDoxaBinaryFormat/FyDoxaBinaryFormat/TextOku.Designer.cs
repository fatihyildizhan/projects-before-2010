namespace FyDoxaBinaryFormat
{
    partial class TextOku
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
            this.btnOku = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOku.Location = new System.Drawing.Point(12, 12);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(260, 58);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "OKU";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 76);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ReadOnly = true;
            this.txtText.Size = new System.Drawing.Size(260, 176);
            this.txtText.TabIndex = 1;
            // 
            // TextOku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnOku);
            this.Name = "TextOku";
            this.Text = "TextOku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.TextBox txtText;
    }
}