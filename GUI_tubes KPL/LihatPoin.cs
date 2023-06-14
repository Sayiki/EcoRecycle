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

            // Deserialize the sampahDataList from the file
            string filePath = "sampahData.dat"; // Update the file path to match the serialization path
            if (File.Exists(filePath))
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    sampahDataList = (List<SampahData>)formatter.Deserialize(fs);
                }
            }

            // Display the sampahDataList in the ListView
            foreach (SampahData sampahData in sampahDataList)
            {
                int poin = CalculatePoin(sampahData.KategoriSampah, sampahData.NominalSampah); // Calculate the points based on the category

                ListViewItem item = new ListViewItem(sampahData.KategoriSampah);
                item.SubItems.Add(sampahData.NominalSampah.ToString());
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

    }
}

