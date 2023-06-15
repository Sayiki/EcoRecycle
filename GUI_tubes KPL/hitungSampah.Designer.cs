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
            this.textinput = new System.Windows.Forms.TextBox();
            this.btnenter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listoutput = new System.Windows.Forms.ListView();
            this.Total = new System.Windows.Forms.Label();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textnominal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Sampah";
            // 
            // textinput
            // 
            this.textinput.Location = new System.Drawing.Point(152, 70);
            this.textinput.Margin = new System.Windows.Forms.Padding(2);
            this.textinput.Name = "textinput";
            this.textinput.Size = new System.Drawing.Size(207, 20);
            this.textinput.TabIndex = 2;
            this.textinput.TextChanged += new System.EventHandler(this.textinput_TextChanged);
            // 
            // btnenter
            // 
            this.btnenter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnenter.Location = new System.Drawing.Point(308, 125);
            this.btnenter.Margin = new System.Windows.Forms.Padding(2);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(50, 19);
            this.btnenter.TabIndex = 4;
            this.btnenter.Text = "add";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(172, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "HITUNG SAMPAH";
            // 
            // listoutput
            // 
            this.listoutput.GridLines = true;
            this.listoutput.HideSelection = false;
            this.listoutput.Location = new System.Drawing.Point(45, 172);
            this.listoutput.Margin = new System.Windows.Forms.Padding(2);
            this.listoutput.Name = "listoutput";
            this.listoutput.Size = new System.Drawing.Size(309, 163);
            this.listoutput.TabIndex = 7;
            this.listoutput.UseCompatibleStateImageBehavior = false;
            this.listoutput.View = System.Windows.Forms.View.Details;
            this.listoutput.SelectedIndexChanged += new System.EventHandler(this.listoutput_SelectedIndexChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(45, 155);
            this.Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(27, 13);
            this.Total.TabIndex = 8;
            this.Total.Text = "total";
            this.Total.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.Location = new System.Drawing.Point(284, 343);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteData.TabIndex = 9;
            this.btnDeleteData.Text = "Delete data";
            this.btnDeleteData.UseVisualStyleBackColor = true;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nominal Sampah";
            // 
            // textnominal
            // 
            this.textnominal.Location = new System.Drawing.Point(152, 94);
            this.textnominal.Margin = new System.Windows.Forms.Padding(2);
            this.textnominal.Name = "textnominal";
            this.textnominal.Size = new System.Drawing.Size(207, 20);
            this.textnominal.TabIndex = 3;
            this.textnominal.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // hitungSampah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(375, 380);
            this.Controls.Add(this.btnDeleteData);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.listoutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.textnominal);
            this.Controls.Add(this.textinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "hitungSampah";
            this.Text = "INPUT SAMPAH!";
            this.Load += new System.EventHandler(this.hitungSampah_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textinput;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listoutput;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button btnDeleteData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textnominal;
    }
}

