namespace GUI_tubes_KPL
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
            this.editprofilebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnkapasitas = new System.Windows.Forms.Button();
            this.btnpoin = new System.Windows.Forms.Button();
            this.btnhitung = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.welcome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.editprofilebtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnkapasitas);
            this.panel1.Controls.Add(this.btnpoin);
            this.panel1.Controls.Add(this.btnhitung);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 382);
            this.panel1.TabIndex = 0;
            // 
            // editprofilebtn
            // 
            this.editprofilebtn.Location = new System.Drawing.Point(11, 263);
            this.editprofilebtn.Name = "editprofilebtn";
            this.editprofilebtn.Size = new System.Drawing.Size(89, 33);
            this.editprofilebtn.TabIndex = 3;
            this.editprofilebtn.Text = "Edit Profile";
            this.editprofilebtn.UseVisualStyleBackColor = true;
            this.editprofilebtn.Click += new System.EventHandler(this.editprofilebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "EcoRecycle";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(11, 225);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(89, 33);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnkapasitas
            // 
            this.btnkapasitas.Location = new System.Drawing.Point(11, 184);
            this.btnkapasitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnkapasitas.Name = "btnkapasitas";
            this.btnkapasitas.Size = new System.Drawing.Size(89, 37);
            this.btnkapasitas.TabIndex = 1;
            this.btnkapasitas.Text = "Kapasitas";
            this.btnkapasitas.UseVisualStyleBackColor = true;
            this.btnkapasitas.Click += new System.EventHandler(this.btnkapasitas_Click);
            // 
            // btnpoin
            // 
            this.btnpoin.Location = new System.Drawing.Point(11, 146);
            this.btnpoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnpoin.Name = "btnpoin";
            this.btnpoin.Size = new System.Drawing.Size(89, 34);
            this.btnpoin.TabIndex = 1;
            this.btnpoin.Text = "Lihat Poin";
            this.btnpoin.UseVisualStyleBackColor = true;
            this.btnpoin.Click += new System.EventHandler(this.btnpoin_Click);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(11, 103);
            this.btnhitung.Margin = new System.Windows.Forms.Padding(2);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(89, 39);
            this.btnhitung.TabIndex = 0;
            this.btnhitung.Text = "Hitung Sampah";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.welcome);
            this.panel2.Location = new System.Drawing.Point(121, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 382);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(70, 126);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(286, 16);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome user, get started by clicking the menu";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 397);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnkapasitas;
        private System.Windows.Forms.Button btnpoin;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button editprofilebtn;
    }
}