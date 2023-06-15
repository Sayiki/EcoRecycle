using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Register;

namespace GUI_tubes_KPL
{
    public partial class RegisterGUI : Form
    {
        public RegisterGUI()
        {
            InitializeComponent();
            passwordText.PasswordChar = '*';
            cpasswordText.PasswordChar = '*';
        }

        private void RegisterGUI_Load(object sender, EventArgs e)
        {

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            string username = usernameText.Text;
            string email = emailText.Text;
            string password = passwordText.Text;
            string cpassword = cpasswordText.Text;

            Register<string> newUser = new Register<string>(username, password, cpassword, email);

            bool registrationSuccessful = newUser.RegisterUser();

            if (registrationSuccessful)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Hide the current form (Form1)
                this.Hide();

                // Create an instance of InputMaterialForm
                dashboard db = new dashboard();

                // Show the InputMaterialForm
                db.Show();
            }
            else
            {
                MessageBox.Show("Input is invalid, please retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();   
        }
    }
}
