using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoRecycleGUI
{
    public partial class Form1 : Form
    {
        private enum EditProfilState
        {
            InputNama,
            InputEmail,
            InputPassword,
            Selesai
        }

        private EditProfilState currentState = EditProfilState.InputNama;
        private string nama = "";
        private string email = "";
        private string password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (currentState == EditProfilState.Selesai)
            {
                SubmitEditProfil();
                return;
            }

            if (currentState == EditProfilState.InputNama)
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Data belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentState = EditProfilState.InputEmail;
                textBox2.PasswordChar = '\0'; // Tampilkan karakter asli
                return;
            }

            if (currentState == EditProfilState.InputEmail)
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Data belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(textBox2.Text))
                {
                    MessageBox.Show("Format email tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                currentState = EditProfilState.InputPassword;
                textBox3.PasswordChar = '*'; // Sembunyikan karakter dengan '*'
                return;
            }

            if (currentState == EditProfilState.InputPassword)
            {
                if (string.IsNullOrEmpty(textBox3.Text))
                {
                    MessageBox.Show("Data belum terisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SubmitEditProfil();
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                return;
            }   
        }
        private bool IsValidEmail(string email)
        {
            // Gunakan regular expression untuk memvalidasi format email
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void SubmitEditProfil()
        {
            MessageBox.Show("Profil berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
