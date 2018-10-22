namespace WindowsFormsApp1
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
            this.txt_matma = new System.Windows.Forms.TextBox();
            this.txt_ifnorrmatyka = new System.Windows.Forms.TextBox();
            this.txt_polski = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Oblicz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_matma
            // 
            this.txt_matma.Location = new System.Drawing.Point(301, 129);
            this.txt_matma.Name = "txt_matma";
            this.txt_matma.Size = new System.Drawing.Size(100, 20);
            this.txt_matma.TabIndex = 0;
            // 
            // txt_ifnorrmatyka
            // 
            this.txt_ifnorrmatyka.Location = new System.Drawing.Point(301, 182);
            this.txt_ifnorrmatyka.Name = "txt_ifnorrmatyka";
            this.txt_ifnorrmatyka.Size = new System.Drawing.Size(100, 20);
            this.txt_ifnorrmatyka.TabIndex = 1;
            // 
            // txt_polski
            // 
            this.txt_polski.Location = new System.Drawing.Point(301, 156);
            this.txt_polski.Name = "txt_polski";
            this.txt_polski.Size = new System.Drawing.Size(100, 20);
            this.txt_polski.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matematyka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "J. Polski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Inforamatyka";
            // 
            // btn_Oblicz
            // 
            this.btn_Oblicz.Location = new System.Drawing.Point(217, 229);
            this.btn_Oblicz.Name = "btn_Oblicz";
            this.btn_Oblicz.Size = new System.Drawing.Size(184, 23);
            this.btn_Oblicz.TabIndex = 6;
            this.btn_Oblicz.Text = "Oblicz";
            this.btn_Oblicz.UseVisualStyleBackColor = true;
            this.btn_Oblicz.Click += new System.EventHandler(this.btn_Oblicz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btn_Oblicz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_polski);
            this.Controls.Add(this.txt_ifnorrmatyka);
            this.Controls.Add(this.txt_matma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_matma;
        private System.Windows.Forms.TextBox txt_ifnorrmatyka;
        private System.Windows.Forms.TextBox txt_polski;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Oblicz;
    }
}

