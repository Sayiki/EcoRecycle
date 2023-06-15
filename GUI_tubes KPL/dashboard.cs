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
    public partial class dashboard : Form
    {
        hitungSampah hs = new hitungSampah();

        enum LogoutState
        {
            LoggedIn,
            LoggingOut,
            LoggedOut
        }

        LogoutState currentState = LogoutState.LoggedIn;
        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Gunakan switch case untuk menentukan tindakan berdasarkan state saat ini
            switch (currentState)
            {
                case LogoutState.LoggedIn:
                    // Lakukan tindakan yang diperlukan saat tombol logout ditekan saat dalam kondisi logged in
                    currentState = LogoutState.LoggingOut;
                    // Lakukan proses logout di sini (misalnya, hapus session, hapus token, dll.)
                    // Setelah logout berhasil, ubah state menjadi LoggedOut
                    currentState = LogoutState.LoggedOut;
                    break;
                case LogoutState.LoggingOut:
                    // Jika tombol logout ditekan saat sedang dalam proses logout, tidak melakukan apa-apa
                    break;
                case LogoutState.LoggedOut:
                    // Jika tombol logout ditekan saat sudah logged out, bisa melakukan tindakan lain (misalnya, menampilkan pesan)
                    MessageBox.Show("Anda sudah logout");
                    break;
                default:
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hs.TopLevel = false; // Set TopLevel property to false
            hs.FormBorderStyle = FormBorderStyle.None; // Set FormBorderStyle property to None
            hs.Dock = DockStyle.Fill; // Dock the new form inside the panel
            panel2.Controls.Add(hs); // Add the new form to the panel's Controls collection
            hs.Show(); // Show the new form
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Logout()
        {
            // Implementasikan logika logout sesuai kebutuhan
        }


    }
}
