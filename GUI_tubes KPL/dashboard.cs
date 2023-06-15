using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GUI_tubes_KPL
{
    public partial class dashboard : Form
    {
        hitungSampah hs = new hitungSampah();
        LihatPoin lp = new LihatPoin();
        kapasitas kp = new kapasitas();
        EditProfile ep = new EditProfile();
        private List<SampahData> sampahDataList = new List<SampahData>();

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

            this.FormClosing += dashboard_FormClosing;
        }

        private void btnlogout_Click(object sender, EventArgs e)
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
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                    break;
                default:
                    break;
            }


        }

        private void btnkapasitas_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            kp = new kapasitas(); // Create a new instance of kapasitas
            kp.TopLevel = false;
            kp.FormBorderStyle = FormBorderStyle.None;
            kp.Dock = DockStyle.Fill;

            panel2.Controls.Add(kp);
            kp.Show();

        }

        private void btnhitung_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            hs.TopLevel = false; // Set TopLevel property to false
            hs.FormBorderStyle = FormBorderStyle.None; // Set FormBorderStyle property to None
            hs.Dock = DockStyle.Fill; // Dock the new form inside the panel
            panel2.Controls.Add(hs); // Add the new form to the panel's Controls collection
            hs.Show(); // Show the new form


        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sampahData.json");

            // Deserialize the sampahDataList from the file
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                sampahDataList = JsonConvert.DeserializeObject<List<SampahData>>(json);
            }



        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
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

        private void SaveSampahData()
        {
            // Serialize the sampahDataList to a file
            using (FileStream fs = new FileStream("sampahData.dat", FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, sampahDataList);
            }
        }

        private void AddSampahData(string namaSampah, string kategoriSampah, int nominalSampah)
        {
            SampahData sampahData = new SampahData(namaSampah, kategoriSampah, nominalSampah);
            sampahDataList.Add(sampahData);

            SaveSampahData();
        }


        private void btnpoin_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lp = new LihatPoin(); // Create a new instance of LihatPoin
            lp.TopLevel = false;
            lp.FormBorderStyle = FormBorderStyle.None;
            lp.Dock = DockStyle.Fill;

            // Pass the sampahDataList to the new instance of LihatPoin
            lp.SetSampahDataList(sampahDataList);

            panel2.Controls.Add(lp);
            lp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editprofilebtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            ep.TopLevel = false; // Set TopLevel property to false
            ep.FormBorderStyle = FormBorderStyle.None; // Set FormBorderStyle property to None
            ep.Dock = DockStyle.Fill; // Dock the new form inside the panel
            panel2.Controls.Add(ep); // Add the new form to the panel's Controls collection
            ep.Show(); // Show the new form
        }
    }
}
