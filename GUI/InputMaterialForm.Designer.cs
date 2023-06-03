namespace GUI
{
    partial class InputMaterialForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_inputmaterial = new System.Windows.Forms.TextBox();
            this.InputMat_label = new System.Windows.Forms.Label();
            this.AddMore_Button = new System.Windows.Forms.Button();
            this.Done_button = new System.Windows.Forms.Button();
            this.MaterialList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_inputmaterial
            // 
            this.textBox_inputmaterial.Location = new System.Drawing.Point(148, 161);
            this.textBox_inputmaterial.Name = "textBox_inputmaterial";
            this.textBox_inputmaterial.Size = new System.Drawing.Size(160, 20);
            this.textBox_inputmaterial.TabIndex = 1;
            this.textBox_inputmaterial.TextChanged += new System.EventHandler(this.textBox_inputmaterial_TextChanged);
            // 
            // InputMat_label
            // 
            this.InputMat_label.AutoSize = true;
            this.InputMat_label.Location = new System.Drawing.Point(68, 164);
            this.InputMat_label.Name = "InputMat_label";
            this.InputMat_label.Size = new System.Drawing.Size(74, 13);
            this.InputMat_label.TabIndex = 2;
            this.InputMat_label.Text = "Input Material:";
            this.InputMat_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // AddMore_Button
            // 
            this.AddMore_Button.Location = new System.Drawing.Point(95, 230);
            this.AddMore_Button.Name = "AddMore_Button";
            this.AddMore_Button.Size = new System.Drawing.Size(75, 23);
            this.AddMore_Button.TabIndex = 3;
            this.AddMore_Button.Text = "Add more";
            this.AddMore_Button.UseVisualStyleBackColor = true;
            this.AddMore_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Done_button
            // 
            this.Done_button.Location = new System.Drawing.Point(213, 230);
            this.Done_button.Name = "Done_button";
            this.Done_button.Size = new System.Drawing.Size(75, 23);
            this.Done_button.TabIndex = 4;
            this.Done_button.Text = "Done";
            this.Done_button.UseVisualStyleBackColor = true;
            this.Done_button.Click += new System.EventHandler(this.Done_button_Click);
            // 
            // MaterialList
            // 
            this.MaterialList.AutoSize = true;
            this.MaterialList.Location = new System.Drawing.Point(68, 118);
            this.MaterialList.Name = "MaterialList";
            this.MaterialList.Size = new System.Drawing.Size(0, 13);
            this.MaterialList.TabIndex = 5;
            this.MaterialList.Click += new System.EventHandler(this.MaterialsList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Materials that were added:";
            // 
            // InputMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaterialList);
            this.Controls.Add(this.Done_button);
            this.Controls.Add(this.AddMore_Button);
            this.Controls.Add(this.InputMat_label);
            this.Controls.Add(this.textBox_inputmaterial);
            this.Name = "InputMaterialForm";
            this.Text = "InputMaterialForm";
            this.Load += new System.EventHandler(this.InputMaterialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_inputmaterial;
        private System.Windows.Forms.Label InputMat_label;
        private System.Windows.Forms.Button AddMore_Button;
        private System.Windows.Forms.Button Done_button;
        private System.Windows.Forms.Label MaterialList;
        private System.Windows.Forms.Label label2;
    }
}