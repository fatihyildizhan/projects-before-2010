namespace DoxaSMO
{
    partial class Form3
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
            this.btnProc = new System.Windows.Forms.Button();
            this.btnEntity = new System.Windows.Forms.Button();
            this.rTxtProc = new System.Windows.Forms.RichTextBox();
            this.rTxtEntity = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rTxtEntity);
            this.groupBox1.Controls.Add(this.rTxtProc);
            this.groupBox1.Controls.Add(this.btnEntity);
            this.groupBox1.Controls.Add(this.btnProc);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 607);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Proc || Create Entity";
            // 
            // btnProc
            // 
            this.btnProc.Location = new System.Drawing.Point(6, 564);
            this.btnProc.Name = "btnProc";
            this.btnProc.Size = new System.Drawing.Size(478, 37);
            this.btnProc.TabIndex = 0;
            this.btnProc.Text = "Create Proc";
            this.btnProc.UseVisualStyleBackColor = true;
            this.btnProc.Click += new System.EventHandler(this.btnProc_Click);
            // 
            // btnEntity
            // 
            this.btnEntity.Location = new System.Drawing.Point(490, 564);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(379, 37);
            this.btnEntity.TabIndex = 1;
            this.btnEntity.Text = "Create Entity";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // rTxtProc
            // 
            this.rTxtProc.BackColor = System.Drawing.Color.Gray;
            this.rTxtProc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtProc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rTxtProc.Location = new System.Drawing.Point(6, 19);
            this.rTxtProc.Name = "rTxtProc";
            this.rTxtProc.Size = new System.Drawing.Size(478, 539);
            this.rTxtProc.TabIndex = 2;
            this.rTxtProc.Text = "";
            // 
            // rTxtEntity
            // 
            this.rTxtEntity.BackColor = System.Drawing.Color.Gray;
            this.rTxtEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rTxtEntity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rTxtEntity.Location = new System.Drawing.Point(490, 19);
            this.rTxtEntity.Name = "rTxtEntity";
            this.rTxtEntity.Size = new System.Drawing.Size(379, 539);
            this.rTxtEntity.TabIndex = 3;
            this.rTxtEntity.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 632);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rTxtEntity;
        private System.Windows.Forms.RichTextBox rTxtProc;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.Button btnProc;
    }
}