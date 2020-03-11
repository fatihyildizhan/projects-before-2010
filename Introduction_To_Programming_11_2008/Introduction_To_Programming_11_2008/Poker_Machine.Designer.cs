namespace Introduction_To_Programming_11_2008
{
    partial class Poker_Machine
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBoxOync3 = new System.Windows.Forms.ListBox();
            this.lstBoxOync4 = new System.Windows.Forms.ListBox();
            this.lstBoxOync2 = new System.Windows.Forms.ListBox();
            this.lstBoxOync1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(276, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 109);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dağıt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnDagit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lstBoxOync3);
            this.groupBox1.Controls.Add(this.lstBoxOync4);
            this.groupBox1.Controls.Add(this.lstBoxOync2);
            this.groupBox1.Controls.Add(this.lstBoxOync1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 417);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poker";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(421, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 9;
            // 
            // lstBoxOync3
            // 
            this.lstBoxOync3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxOync3.ColumnWidth = 2;
            this.lstBoxOync3.FormattingEnabled = true;
            this.lstBoxOync3.ItemHeight = 17;
            this.lstBoxOync3.Location = new System.Drawing.Point(521, 159);
            this.lstBoxOync3.Name = "lstBoxOync3";
            this.lstBoxOync3.Size = new System.Drawing.Size(139, 106);
            this.lstBoxOync3.TabIndex = 8;
            this.lstBoxOync3.MouseHover += new System.EventHandler(this.lstBoxOync4_MouseHover);
            this.lstBoxOync3.MouseLeave += new System.EventHandler(this.lstBoxOync4_MouseLeave);
            // 
            // lstBoxOync4
            // 
            this.lstBoxOync4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxOync4.ColumnWidth = 2;
            this.lstBoxOync4.FormattingEnabled = true;
            this.lstBoxOync4.ItemHeight = 17;
            this.lstBoxOync4.Location = new System.Drawing.Point(276, 32);
            this.lstBoxOync4.Name = "lstBoxOync4";
            this.lstBoxOync4.Size = new System.Drawing.Size(139, 106);
            this.lstBoxOync4.TabIndex = 7;
            this.lstBoxOync4.MouseHover += new System.EventHandler(this.lstBoxOync3_MouseHover);
            this.lstBoxOync4.MouseLeave += new System.EventHandler(this.lstBoxOync3_MouseLeave);
            // 
            // lstBoxOync2
            // 
            this.lstBoxOync2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxOync2.ColumnWidth = 2;
            this.lstBoxOync2.FormattingEnabled = true;
            this.lstBoxOync2.ItemHeight = 17;
            this.lstBoxOync2.Location = new System.Drawing.Point(276, 289);
            this.lstBoxOync2.Name = "lstBoxOync2";
            this.lstBoxOync2.Size = new System.Drawing.Size(139, 106);
            this.lstBoxOync2.TabIndex = 6;
            this.lstBoxOync2.MouseHover += new System.EventHandler(this.lstBoxOync2_MouseHover);
            this.lstBoxOync2.MouseLeave += new System.EventHandler(this.lstBoxOync2_MouseLeave);
            // 
            // lstBoxOync1
            // 
            this.lstBoxOync1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstBoxOync1.ColumnWidth = 2;
            this.lstBoxOync1.FormattingEnabled = true;
            this.lstBoxOync1.ItemHeight = 17;
            this.lstBoxOync1.Location = new System.Drawing.Point(26, 162);
            this.lstBoxOync1.Name = "lstBoxOync1";
            this.lstBoxOync1.Size = new System.Drawing.Size(139, 106);
            this.lstBoxOync1.TabIndex = 5;
            this.lstBoxOync1.MouseHover += new System.EventHandler(this.lstBoxOync1_MouseHover);
            this.lstBoxOync1.MouseLeave += new System.EventHandler(this.lstBoxOync1_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Oyuncu 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Oyuncu 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oyuncu 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyuncu 1";
            // 
            // Poker_Machine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(710, 441);
            this.Controls.Add(this.groupBox1);
            this.Name = "Poker_Machine";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstBoxOync3;
        private System.Windows.Forms.ListBox lstBoxOync4;
        private System.Windows.Forms.ListBox lstBoxOync2;
        private System.Windows.Forms.ListBox lstBoxOync1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;

    }
}

