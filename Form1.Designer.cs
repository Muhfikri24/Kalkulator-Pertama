namespace LAT_1_KALKULATOR_WindowsFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.operasimtk = new System.Windows.Forms.ComboBox();
            this.nilaiA = new System.Windows.Forms.TextBox();
            this.nilaiB = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OPERASI MATEMATIKA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NILAI A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "NILAI B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "HASIL";
            // 
            // operasimtk
            // 
            this.operasimtk.FormattingEnabled = true;
            this.operasimtk.Items.AddRange(new object[] {
            "PENJUMLAHAN",
            "PENGURANGAN",
            "PERKALIAN",
            "PEMBAGIAN"});
            this.operasimtk.Location = new System.Drawing.Point(227, 72);
            this.operasimtk.Name = "operasimtk";
            this.operasimtk.Size = new System.Drawing.Size(263, 24);
            this.operasimtk.TabIndex = 4;
            this.operasimtk.SelectedIndexChanged += new System.EventHandler(this.kotak1_SelectedIndexChanged);
            // 
            // nilaiA
            // 
            this.nilaiA.Location = new System.Drawing.Point(227, 117);
            this.nilaiA.Name = "nilaiA";
            this.nilaiA.Size = new System.Drawing.Size(263, 22);
            this.nilaiA.TabIndex = 5;
            this.nilaiA.TextChanged += new System.EventHandler(this.c_TextChanged);
            // 
            // nilaiB
            // 
            this.nilaiB.Location = new System.Drawing.Point(227, 162);
            this.nilaiB.Name = "nilaiB";
            this.nilaiB.Size = new System.Drawing.Size(263, 22);
            this.nilaiB.TabIndex = 6;
            // 
            // hasil
            // 
            this.hasil.Location = new System.Drawing.Point(227, 217);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(263, 22);
            this.hasil.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 114);
            this.button1.TabIndex = 8;
            this.button1.Text = "PRESS HERE !!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.nilaiB);
            this.Controls.Add(this.nilaiA);
            this.Controls.Add(this.operasimtk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox operasimtk;
        private System.Windows.Forms.TextBox nilaiA;
        private System.Windows.Forms.TextBox nilaiB;
        private System.Windows.Forms.TextBox hasil;
        private System.Windows.Forms.Button button1;
    }
}

