using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_tubes_KPL
{
    public partial class EditProfile : Form
    {
        private enum TextBoxType
        {
            Nama,
            Email,
            Sandi
        }

        public EditProfile()
        {
            InitializeComponent();
            textsandi.PasswordChar = '*';
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            string nama = textnama.Text;
            string email = textemail.Text;
            string sandi = textsandi.Text;

            if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sandi))
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Perform the edit operation here

                MessageBox.Show("Successfully edited profile!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextbox(TextBoxType.Nama);
                ClearTextbox(TextBoxType.Email);
                ClearTextbox(TextBoxType.Sandi);
            }
        }

        private void ClearTextbox(TextBoxType textBoxType)
        {
            switch (textBoxType)
            {
                case TextBoxType.Nama:
                    textnama.Text = "";
                    break;
                case TextBoxType.Email:
                    textemail.Text = "";
                    break;
                case TextBoxType.Sandi:
                    textsandi.Text = "";
                    break;
            }
        }


        private void textnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void textemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textsandi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
