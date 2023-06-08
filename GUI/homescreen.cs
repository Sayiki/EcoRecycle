using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HermawanLibrary;

namespace GUI
{
    public partial class homescreen : Form
    {
        public homescreen()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string input = textBox1.Text;
            switch (input)
            {
                case "1":
                    Console.WriteLine("jenis sampah");
                    break;
                case "2":
                    Console.WriteLine("edit profil");
                    break;
                case "3":
                    Console.WriteLine("lihat poin");
                    break;
                case "4":
                    Kapasitas.periksaKapasitas<int>();
                    break;
            }
        }
    }
}
