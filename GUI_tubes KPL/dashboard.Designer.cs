﻿namespace GUI_tubes_KPL
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnhitung = new System.Windows.Forms.Button();
            this.btnjenis = new System.Windows.Forms.Button();
            this.btnpoin = new System.Windows.Forms.Button();
            this.btnkapasitas = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnkapasitas);
            this.panel1.Controls.Add(this.btnpoin);
            this.panel1.Controls.Add(this.btnjenis);
            this.panel1.Controls.Add(this.btnhitung);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 587);
            this.panel1.TabIndex = 0;
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(16, 208);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(133, 30);
            this.btnhitung.TabIndex = 0;
            this.btnhitung.Text = "Hitung Sampah";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnjenis
            // 
            this.btnjenis.Location = new System.Drawing.Point(16, 244);
            this.btnjenis.Name = "btnjenis";
            this.btnjenis.Size = new System.Drawing.Size(133, 31);
            this.btnjenis.TabIndex = 1;
            this.btnjenis.Text = "Jenis Sampah";
            this.btnjenis.UseVisualStyleBackColor = true;
            this.btnjenis.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnpoin
            // 
            this.btnpoin.Location = new System.Drawing.Point(16, 281);
            this.btnpoin.Name = "btnpoin";
            this.btnpoin.Size = new System.Drawing.Size(133, 33);
            this.btnpoin.TabIndex = 1;
            this.btnpoin.Text = "Lihat Poin";
            this.btnpoin.UseVisualStyleBackColor = true;
            // 
            // btnkapasitas
            // 
            this.btnkapasitas.Location = new System.Drawing.Point(16, 320);
            this.btnkapasitas.Name = "btnkapasitas";
            this.btnkapasitas.Size = new System.Drawing.Size(133, 29);
            this.btnkapasitas.TabIndex = 1;
            this.btnkapasitas.Text = "Kapasitas";
            this.btnkapasitas.UseVisualStyleBackColor = true;
            this.btnkapasitas.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(16, 355);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(133, 29);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(33, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "EcoRecycle";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(181, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 587);
            this.panel2.TabIndex = 1;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnkapasitas;
        private System.Windows.Forms.Button btnpoin;
        private System.Windows.Forms.Button btnjenis;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}