namespace GUI_tubes_KPL
{
    partial class kapasitas
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
            this.totalinput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kapasitas untuk hari ini adalah 10";
            // 
            // totalinput
            // 
            this.totalinput.AutoSize = true;
            this.totalinput.Location = new System.Drawing.Point(107, 202);
            this.totalinput.Name = "totalinput";
            this.totalinput.Size = new System.Drawing.Size(53, 13);
            this.totalinput.TabIndex = 1;
            this.totalinput.Text = "total input";
            this.totalinput.Click += new System.EventHandler(this.totalinput_Click);
            // 
            // kapasitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 380);
            this.Controls.Add(this.totalinput);
            this.Controls.Add(this.label1);
            this.Name = "kapasitas";
            this.Text = "kapasitas";
            this.Load += new System.EventHandler(this.kapasitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalinput;
    }
}