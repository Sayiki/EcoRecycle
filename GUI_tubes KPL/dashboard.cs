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

        public dashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Memeriksa opsi yang dipilih pengguna
            if (result == DialogResult.Yes)
            {
                // Lakukan tindakan logout
                // ...

                MessageBox.Show("Anda telah logout.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.No)
            {
                // Batal logout
                // ...
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
