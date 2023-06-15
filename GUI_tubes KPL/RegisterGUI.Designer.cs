namespace GUI_tubes_KPL
{
    partial class RegisterGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterGUI));
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.cpassword = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.cpasswordText = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.registerbtn = new System.Windows.Forms.Button();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(96, 164);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 1;
            this.email.Text = "Email:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(96, 211);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(56, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password:";
            // 
            // cpassword
            // 
            this.cpassword.AutoSize = true;
            this.cpassword.Location = new System.Drawing.Point(96, 250);
            this.cpassword.Name = "cpassword";
            this.cpassword.Size = new System.Drawing.Size(93, 13);
            this.cpassword.TabIndex = 3;
            this.cpassword.Text = "Confirm password:";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(223, 111);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(100, 20);
            this.usernameText.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(223, 164);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(100, 20);
            this.emailText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(223, 211);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(100, 20);
            this.passwordText.TabIndex = 6;
            // 
            // cpasswordText
            // 
            this.cpasswordText.Location = new System.Drawing.Point(223, 250);
            this.cpasswordText.Name = "cpasswordText";
            this.cpasswordText.Size = new System.Drawing.Size(100, 20);
            this.cpasswordText.TabIndex = 7;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(96, 111);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(58, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username:";
            // 
            // registerbtn
            // 
            this.registerbtn.Location = new System.Drawing.Point(223, 294);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(102, 33);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(90, 294);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(99, 33);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // RegisterGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(442, 401);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.registerbtn);
            this.Controls.Add(this.cpasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.cpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Name = "RegisterGUI";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.RegisterGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label cpassword;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox cpasswordText;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Button loginbtn;
    }
}