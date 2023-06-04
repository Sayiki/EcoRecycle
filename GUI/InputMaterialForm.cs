using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class InputMaterialForm : Form
    {
        private List<string> materials;
        public InputMaterialForm()
        {
            InitializeComponent();
            materials = new List<string>();
        }

        private void UpdateMaterialList()
        {
            MaterialList.Text = string.Join(", ", materials);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string material = textBox_inputmaterial.Text.Trim();

            if (!string.IsNullOrEmpty(material))
            {
                materials.Add(material);
                UpdateMaterialList();
                textBox_inputmaterial.Clear();
            }
        }

        private void MaterialsList_Click(object sender, EventArgs e)
        {

        }

        private void textBox_inputmaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void Done_button_Click(object sender, EventArgs e)
        {

        }

        private void InputMaterialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
