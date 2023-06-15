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
        private List<SampahData> sampahDataList = new List<SampahData>();


        public dashboard()
        {
            InitializeComponent();

            this.FormClosing += dashboard_FormClosing;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Anda telah logout.", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else if (result == DialogResult.No)
            {
                // nothing
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
    }
}
