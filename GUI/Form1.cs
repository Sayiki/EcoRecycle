using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArzaqLibrary;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passwordText.PasswordChar = '*';
            cpasswordText.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = NameText.Text;
            string email = EmailText.Text;
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
                InputMaterialForm inputMaterialForm = new InputMaterialForm();

                // Show the InputMaterialForm
                inputMaterialForm.Show();
            }
            else
            {
                MessageBox.Show("Input is invalid, please retry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
