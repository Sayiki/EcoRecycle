using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_tubes_KPL
{
    public partial class hitungSampah : Form
    {
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
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for Nominal Sampah.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private string GetKategoriSampah(string namaSampah)
        {
            string kategori = "";

            // Map input to categories
            switch (namaSampah.ToLower())
            {
                case "bungkus indomie":
                    kategori = "plastic";
                    break;
                case "kertas a4":
                    kategori = "kertas";
                    break;
                case "kotak sepatu":
                    kategori = "kardus";
                    break;
                // Add more cases for other inputs and their corresponding categories
                default:
                    kategori = "Tidak diketahui";
                    break;
            }

            return kategori;
        }


        private void hitungSampah_Load_1(object sender, EventArgs e)
        {
            listoutput.Columns.Add("Nama Sampah", 100);
            listoutput.Columns.Add("Kategori Sampah", 100); // Menambahkan kolom kategori
            listoutput.Columns.Add("Nominal Sampah", 100);

        }

        private void CalculateTotalSampah()
        {
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
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
