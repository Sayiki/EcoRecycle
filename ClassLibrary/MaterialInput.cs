using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary
{
    public class MaterialInput
    {
        // A list of strings to store deposited materials
        public List<string> materials;

        // Constructor
        public MaterialInput()
        {
            materials = new List<string>();
        }
        // Method untuk menerima input material
        public void InputMaterial()
        {
            Console.WriteLine("Deposit material logam/plastik/aluminium/kaca/kertas/kardus (type '0' to exit)");

            string input = Console.ReadLine();
            Contract.Requires(input != null, "material must not be null");
            Contract.Requires(IsValidMaterial(input), "material must be 'logam', 'plastik', 'aluminium', 'kaca', 'kertas', or 'kardus'");

            while (input != "0")
            {
                if (IsValidMaterial(input))
                {
                    materials.Add(input.ToLower());
                    Console.WriteLine("Material yang dimasukkan adalah " + input);
                }
                else
                {
                    Console.WriteLine("Material tidak bisa dimasukkan");
                }

                input = Console.ReadLine();
                Contract.Requires(input != null, "material must not be null");
                Contract.Requires(IsValidMaterial(input), "material must be 'logam', 'plastik', 'aluminium', 'kaca', 'kertas', or 'kardus'");
            }
            Console.WriteLine("Exiting input material mode");
        }

        public void PrintMaterialList()
        {
            Console.Write("Material list: ");
            Contract.Requires(materials.Count != 0, "List tidak kosong");

            if (materials.Count > 0)
            {
                string a = $"Material list: {string.Join(", ", materials)}\nTotal yang dimasukkan: {materials.Count}\n\n";
                Console.WriteLine(a);
            }

        }

        // Method untuk cek ketika material valid
        private bool IsValidMaterial(string material)
        {
            switch (material.ToLower())
            {
                case "logam":
                case "plastik":
                case "kertas":
                case "kardus":
                case "aluminium":
                case "kaca":
                    return true;
                default:
                    return false;
            }
        }
    }
}
