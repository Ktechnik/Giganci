namespace WindowsFormsApp2
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
            this.txt_imie = new System.Windows.Forms.TextBox();
            this.txt_nazwisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sprawdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_imie
            // 
            this.txt_imie.Location = new System.Drawing.Point(146, 48);
            this.txt_imie.Name = "txt_imie";
            this.txt_imie.Size = new System.Drawing.Size(100, 20);
            this.txt_imie.TabIndex = 0;
            // 
            // txt_nazwisko
            // 
            this.txt_nazwisko.Location = new System.Drawing.Point(146, 121);
            this.txt_nazwisko.Name = "txt_nazwisko";
            this.txt_nazwisko.Size = new System.Drawing.Size(100, 20);
            this.txt_nazwisko.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nazwikso";
            // 
            // btn_sprawdz
            // 
            this.btn_sprawdz.Location = new System.Drawing.Point(61, 209);
            this.btn_sprawdz.Name = "btn_sprawdz";
            this.btn_sprawdz.Size = new System.Drawing.Size(185, 23);
            this.btn_sprawdz.TabIndex = 4;
            this.btn_sprawdz.Text = "Sprawdź";
            this.btn_sprawdz.UseVisualStyleBackColor = true;
            this.btn_sprawdz.Click += new System.EventHandler(this.btn_sprawdz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 272);
            this.Controls.Add(this.btn_sprawdz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nazwisko);
            this.Controls.Add(this.txt_imie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_imie;
        private System.Windows.Forms.TextBox txt_nazwisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sprawdz;
    }
}

