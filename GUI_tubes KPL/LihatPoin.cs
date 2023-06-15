using Newtonsoft.Json;
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
    public partial class LihatPoin : Form
    {
        private Dictionary<string, int> categoryPoints; // Dictionary to store the category points
        private List<SampahData> sampahDataList; // List to store the sampah data

        public LihatPoin()
        {
            InitializeComponent();
        }

        private void LihatPoin_Load(object sender, EventArgs e)
        {
            listpoin.Columns.Add("Kategori Sampah", 100);
            listpoin.Columns.Add("Nominal Sampah", 100);
            listpoin.Columns.Add("Poin", 100);

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sampahData.json");

            // Deserialize the sampahDataList from the file
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                sampahDataList = JsonConvert.DeserializeObject<List<SampahData>>(json);
            }

            // Get all distinct categories from the sampahDataList
            var categories = sampahDataList.Select(s => s.KategoriSampah).Distinct();

            // Display the categories and their respective points in the ListView
            foreach (var category in categories)
            {
                int totalNominal = sampahDataList
                    .Where(s => s.KategoriSampah == category)
                    .Sum(s => s.NominalSampah);

                int poin = CalculatePoin(category, totalNominal); // Calculate the points based on the category

                ListViewItem item = new ListViewItem(category);
                item.SubItems.Add(totalNominal.ToString());
                item.SubItems.Add(poin.ToString());
                listpoin.Items.Add(item);
            }

            int totalPoints = CalculateTotalPoints();
            totalPointsLabel.Text = "Total Points: " + totalPoints.ToString();
        }


        private int CalculatePoin(string kategoriSampah, int nominalSampah)
        {
            int poin = 0;

            // Calculate points based on the category
            switch (kategoriSampah.ToLower())
            {
                case "plastic":
                    poin = 3 * nominalSampah;
                    break;
                case "glass":
                    poin = 4 * nominalSampah;
                    break;
                case "paper":
                    poin = 2 * nominalSampah;
                    break;
                case "cardboard":
                    poin = 3 * nominalSampah;
                    break;
                default:
                    poin = 0;
                    break;
            }

            return poin;
        }

        public void SetSampahDataList(List<SampahData> data)
        {
            sampahDataList = data;
        }

        private int CalculateTotalPoints()
        {
            int totalPoints = 0;

            foreach (SampahData sampahData in sampahDataList)
            {
                int poin = CalculatePoin(sampahData.KategoriSampah, sampahData.NominalSampah);
                totalPoints += poin;
            }

            return totalPoints;
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            // Close the current instance of the form
            this.Close();
        }
    }
}

