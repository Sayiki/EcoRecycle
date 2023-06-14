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

namespace GUI_tubes_KPL
{
    public partial class dashboard : Form
    {
        hitungSampah hs = new hitungSampah();
        LihatPoin lp = new LihatPoin();
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
                this.Close();
            }
            else if (result == DialogResult.No)
            {

            }

        }

        private void btnkapasitas_Click(object sender, EventArgs e)
        {

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
            // Deserialize the sampahDataList from the file
            if (File.Exists("sampahData.dat"))
            {
                using (FileStream fs = new FileStream("sampahData.dat", FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    sampahDataList = (List<SampahData>)formatter.Deserialize(fs);
                }
            }
            


        }

        private void dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            string filePath = "sampahData.dat";

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                }
                catch (IOException ex)
                {
                    MessageBox.Show("An error occurred while deleting the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Logout()
        {
            // Implementasikan logika logout sesuai kebutuhan
        }

        private void btnpoin_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            lp.TopLevel = false;
            lp.FormBorderStyle = FormBorderStyle.None;
            lp.Dock = DockStyle.Fill;

            // Pass the sampahDataList to the LihatPoin form
            lp.SetSampahDataList(sampahDataList);

            panel2.Controls.Add(lp);
            lp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
