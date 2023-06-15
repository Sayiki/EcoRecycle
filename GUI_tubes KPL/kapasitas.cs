using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KapasitasLibrary;

namespace GUI_tubes_KPL
{
    public partial class kapasitas : Form
    {
        public kapasitas()
        {
            InitializeComponent();
        }

        private void totalinput_Click(object sender, EventArgs e)
        {

        }

        private void kapasitas_Load(object sender, EventArgs e)
        {
            // Load sampahDataList from the file
            hitungSampah hs = new hitungSampah();
            hs.LoadSampahData();

            // Calculate the total sampah
            int totalSampah = hs.sampahDataList.Sum(data => data.NominalSampah);

            // Update the total sampah in the kapasitas form
            totalinput.Text = kapasitaslibrary.UpdateTotalInput(totalSampah);
        }


    }
}
