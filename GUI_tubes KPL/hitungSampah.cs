using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace GUI_tubes_KPL
{
    public partial class hitungSampah : Form
    {

        public List<SampahData> sampahDataList = new List<SampahData>();
        public hitungSampah()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            string namaSampah = textinput.Text;
            int nominalSampah;

            // Check if the input for nominalSampah is a valid integer
            if (int.TryParse(textnominal.Text, out nominalSampah))
            {
                // Determine the category of the sampah based on the input
                string kategoriSampah = GetKategoriSampah(namaSampah);

                // Add the values to the ListView
                ListViewItem item = new ListViewItem(namaSampah);
                item.SubItems.Add(kategoriSampah); // Menambahkan kategori sebagai subitem
                item.SubItems.Add(nominalSampah.ToString());
                listoutput.Items.Add(item);

                // Clear the textboxes
                textinput.Text = "";
                textnominal.Text = "";

                // Calculate and display the total sampah
                CalculateTotalSampah();

                // Save the sampahDataList
                SaveSampahData();
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for Nominal Sampah.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveSampahData()
        {
            // Retrieve the sampah data from the ListView and create SampahData objects
            sampahDataList.Clear();
            foreach (ListViewItem item in listoutput.Items)
            {
                string namaSampah = item.SubItems[0].Text;
                string kategoriSampah = item.SubItems[1].Text;
                int nominalSampah = int.Parse(item.SubItems[2].Text);

                SampahData sampahData = new SampahData(namaSampah, kategoriSampah, nominalSampah);
                sampahDataList.Add(sampahData);
            }

            // Specify the new file path
            string newFilePath = Path.Combine(Application.StartupPath, "sampahData.json");

            // Serialize the sampahDataList to JSON and save it to the new file path
            string jsonData = JsonConvert.SerializeObject(sampahDataList);
            File.WriteAllText(newFilePath, jsonData);
        }

        public void LoadSampahData()
        {
            string filePath = Path.Combine(Application.StartupPath, "sampahData.json");
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);

                // Deserialize the JSON data to the sampahDataList
                sampahDataList = JsonConvert.DeserializeObject<List<SampahData>>(jsonData);
            }
        }

        private string GetKategoriSampah(string namaSampah)
        {
            string kategori = "";

            Contract.Requires(!string.IsNullOrEmpty(namaSampah));

            // Map input to categories
            switch (namaSampah.ToLower())
            {
                case "bungkus indomie":
                    kategori = "plastic";
                    break;
                case "kertas a4":
                    kategori = "paper";
                    break;
                case "kotak sepatu":
                    kategori = "cardboard";
                    break;
                case "gelas kaca":
                    kategori = "glass";
                    break;
                default:
                    kategori = "Tidak diketahui";
                    break;
            }
            Contract.Ensures(Contract.Result<int>() >= 0);

            return kategori;

        }



        private void hitungSampah_Load(object sender, EventArgs e)
        {
            listoutput.Columns.Add("Nama Sampah", 100);
            listoutput.Columns.Add("Kategori Sampah", 100); // Menambahkan kolom kategori
            listoutput.Columns.Add("Nominal Sampah", 100);

            // Load sampahDataList from the file
            LoadSampahData();

            // Display the sampahDataList in the ListView
            foreach (SampahData sampahData in sampahDataList)
            {
                ListViewItem item = new ListViewItem(sampahData.NamaSampah);
                item.SubItems.Add(sampahData.KategoriSampah);
                item.SubItems.Add(sampahData.NominalSampah.ToString());
                listoutput.Items.Add(item);
            }

            // Calculate and display the total sampah
            CalculateTotalSampah();

        }

        private void CalculateTotalSampah()
        {
            Contract.Ensures(Contract.Result<int>() >= 0);

            int totalSampah = 0;

            // Iterate through the items in the ListView and sum up the nominal sampah values
            foreach (ListViewItem item in listoutput.Items)
            {
                int nominalSampah;
                if (int.TryParse(item.SubItems[2].Text, out nominalSampah))
                {
                    totalSampah += nominalSampah;
                }
            }

            // Display the total sampah in the label
            Total.Text = "Total Sampah: " + totalSampah.ToString();

            Contract.Assert(totalSampah >= 0);

        }

        public System.Windows.Forms.ListView GetGarbageListView()
        {
            return listoutput;
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            string filePath = Path.Combine(Application.StartupPath, "sampahData.json");


            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("Data Sampah berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listoutput.Items.Clear(); // Clear the ListView if needed
                }
                else
                {
                    MessageBox.Show("Data Sampah tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("An error occurred while deleting the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listoutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
