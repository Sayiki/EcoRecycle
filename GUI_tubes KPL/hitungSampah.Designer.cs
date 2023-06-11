namespace GUI_tubes_KPL
{
    partial class hitungSampah
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
            this.textinput = new System.Windows.Forms.TextBox();
            this.textnominal = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listoutput = new System.Windows.Forms.ListView();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Sampah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal Sampah";
            // 
            // textinput
            // 
            this.textinput.Location = new System.Drawing.Point(191, 111);
            this.textinput.Name = "textinput";
            this.textinput.Size = new System.Drawing.Size(309, 26);
            this.textinput.TabIndex = 2;
            // 
            // textnominal
            // 
            this.textnominal.Location = new System.Drawing.Point(191, 147);
            this.textnominal.Name = "textnominal";
            this.textnominal.Size = new System.Drawing.Size(309, 26);
            this.textnominal.TabIndex = 3;
            this.textnominal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnenter
            // 
            this.btnenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnenter.Location = new System.Drawing.Point(425, 196);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(75, 29);
            this.btnenter.TabIndex = 4;
            this.btnenter.Text = "add";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(220, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "HITUNG SAMPAH";
            // 
            // listoutput
            // 
            this.listoutput.GridLines = true;
            this.listoutput.HideSelection = false;
            this.listoutput.Location = new System.Drawing.Point(30, 267);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(461, 279);
            this.listoutput.TabIndex = 7;
            this.listoutput.UseCompatibleStateImageBehavior = false;
            this.listoutput.View = System.Windows.Forms.View.Details;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(30, 241);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(40, 20);
            this.Total.TabIndex = 8;
            this.Total.Text = "total";
            this.Total.Click += new System.EventHandler(this.label4_Click);
            // 
            // hitungSampah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(562, 584);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.listoutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.textnominal);
            this.Controls.Add(this.textinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "hitungSampah";
            this.Text = "INPUT SAMPAH!";
            this.Load += new System.EventHandler(this.hitungSampah_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textinput;
        private System.Windows.Forms.TextBox textnominal;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listoutput;
        private System.Windows.Forms.Label Total;
    }
}

