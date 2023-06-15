using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Login : Form
    {
        private Dictionary<string, string> userCredentials; // Dictionary to store user credentials

        public Login()
        {
            InitializeComponent();

            // Initialize user credentials
            InitializeUserCredentials();
        }

        private void InitializeUserCredentials()
        {
            // Initialize user credentials using table-driven approach
            userCredentials = new Dictionary<string, string>()
            {
                { "admin", "password123" },
                { "user1", "pass456" },
                { "user2", "qwerty" },
                { "triani", "trianipm" }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Merupakan hanya tulisan "Log In"
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Merupakan hanya tulisan "Please login to your akun"
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Merupakan hanya tulisan "Username"
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Merupakan hanya tulisan "Password"
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Input for username
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Input for password
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Checkbox to show/hide password
            if (checkBox1.Checked)
            {
                textPassword.PasswordChar = '\0'; // Show password characters
                textPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textPassword.PasswordChar = '*'; // Hide password characters
                textPassword.UseSystemPasswordChar = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Clear login inputs
            textUsername.Text = "";
            textPassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Exit button to cancel login
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login button
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Login successful!");
                // Perform further actions after successful login
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                // Handle invalid login attempt
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            // Design by contract: Precondition
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Username and password must be provided!");
            }

            // Check if the entered username exists in the user credentials dictionary
            if (userCredentials.ContainsKey(username))
            {
                // Check if the entered password matches the stored password for the username
                if (userCredentials[username] == password)
                {
                    // Design by contract: Postcondition
                    if (username != "triani" || password != "trianipm")
                    {
                        throw new Exception("Invalid postcondition: triani user should have trianipm");
                    }

                    return true; // Valid login
                }
            }

            return false; // Invalid login
        }
    }
}
