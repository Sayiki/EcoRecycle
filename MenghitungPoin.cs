using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class MenghitungPoin : Form
    {
        private Dictionary<string, int> garbagePoints; // Deklarasi variabel garbagePoints

        private void UpdatePointsLabel()
        {
            int totalPoints = 0;

            // Menghitung total poin
            foreach (var kvp in garbagePoints)
            {
                totalPoints += kvp.Value;
            }

            // Memperbarui label dengan total poin
            label1.Text = $"{totalPoints}";
        }
        private string configFilePath = "MenghitungSampah.json";
        private Dictionary<string, int> LoadGarbagePoints()
        {
            string json = "";

            try
            {
                if (File.Exists(configFilePath))
                {
                    json = File.ReadAllText(configFilePath);
                    return JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
                }
                else
                {
                    return GetDefaultGarbagePoints();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading config file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return GetDefaultGarbagePoints();
        }
        private void SaveGarbagePoints()
        {
            try
            {
                string json = JsonConvert.SerializeObject(garbagePoints, Formatting.Indented);
                File.WriteAllText(configFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving config file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveGarbagePoints();
        }
        private Dictionary<string, int> GetDefaultGarbagePoints()
        {
            return new Dictionary<string, int>
            {
                { "aluminum", 0 },
                { "plastic", 0 },
                { "glass", 0 },
                { "paper", 0 },
                { "cardboard", 0 },
                { "etc", 0 }
            };
        }
        private void AddPoints(string garbageType)
        {
            Contract.Requires(garbageType != null, "garbageType cannot be null");

            if (garbagePoints.ContainsKey(garbageType))
            {
                // Jika jenis sampah ada dalam kamus, tambahkan poin
                garbagePoints[garbageType] += 5;
                UpdatePointsLabel();
            }
            else
            {
                MessageBox.Show("Jenis sampah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearPoints()
        {
            foreach (var garbageType in garbagePoints.Keys.ToList())
            {
                garbagePoints[garbageType] = 0;
            }

            UpdatePointsLabel();
        }
        private void UpdatePointsConfiguration(string garbageType, int points)
        {
            if (garbagePoints.ContainsKey(garbageType))
            {
                garbagePoints[garbageType] = points;
                UpdatePointsLabel();
            }
            else
            {
                MessageBox.Show("Jenis sampah tidak valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public MenghitungPoin()
        {
            InitializeComponent();
            garbagePoints = LoadGarbagePoints();
            UpdatePointsLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // jenis sampah alumunium
            AddPoints("aluminum");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // jenis sampah plastic
            AddPoints("plastic");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            // jenis sampah glass
            AddPoints("glass");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // jenis sampah paper
            AddPoints("paper");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            // jenis sampah cardboard
            AddPoints("cardboard");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            // jenis sampah lainnya
            AddPoints("etc");

            // Mengambil nilai konfigurasi dari TextBox
            if (int.TryParse(textBox1.Text, out int newPoints))
            {
                // Mengubah konfigurasi poin sampah aluminium saat runtime
                UpdatePointsConfiguration("etc", newPoints);
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // hasil point yang dihasilkan dari setiap sampah yang masuk,
            // dengan setiap jenis sampah yang masuk bertambah 5 point 
        }
        private void label2_Click(object sender, EventArgs e)
        {
            // merupakan hanya tulisan "The total points you get!"
        }
        private void label3_Click(object sender, EventArgs e)
        {
            // merupakan hanya tulisan "Total Points"
        }
        private void label4_Click(object sender, EventArgs e)
        {
            // merupakan hanya tulisan "Thank you for disposing of trash properly!"
        }
        private void label5_Click(object sender, EventArgs e)
        {
            // Merupakan hanya tulisan edit points
        }
        private void button7_Click(object sender, EventArgs e)
        {
            // kalimat clear untuk me-reset total poin yang sudah didapatkan
            ClearPoints();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            // kelimat exit untuk keluar dari tampilan
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int newPoints))
            {
                // Mengubah konfigurasi poin sampah lainnya saat runtime
                UpdatePointsConfiguration("etc", newPoints);
            }
            else
            {
                MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
