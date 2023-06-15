using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_tubes_KPL
{
    public partial class Login : Form
    {
        private Dictionary<string, string> userCredentials; // Dictionary to store user credentials
        public Login()
        {
            InitializeComponent();
            textPassword.PasswordChar = '*';
            InitializeUserCredentials();

            this.FormClosing += login_FormClosing;

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

                    return true; // Valid login
                }
            }

            return false; // Invalid login
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            // Login button
            string username = textUsername.Text;
            string password = textPassword.Text;

            if (ValidateLogin(username, password))
            {
                this.Hide();
                MessageBox.Show("Login successful!");
                dashboard db = new dashboard();
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
                // Handle invalid login attempt
            }

        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterGUI rg = new RegisterGUI();
            rg.Show();
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sampahData.json");

            // Delete the JSON file if it exists
            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while deleting the JSON file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
