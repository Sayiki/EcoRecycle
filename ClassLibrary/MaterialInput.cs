﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArzaqLibrary
{
    public class MaterialInput
    {
        public List<string> materials;

        public MaterialInput()
        {
            materials = new List<string>();
        }

        public void InputMaterial()
        {
            Console.WriteLine("Deposit material metal/plastic/aluminium/glass/paper/cardboard (type '0' to exit)");
            string input = Console.ReadLine();

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
            }

            Console.WriteLine("");

            Console.Write("Material list: ");

            if (materials.Count > 0)
            {
                Console.Write(string.Join(", ", materials));
            }

            Console.WriteLine("\nTotal yang dimasukkan: " + materials.Count);

            Console.WriteLine();
        }

        private bool IsValidMaterial(string material)
        {
            switch (material.ToLower())
            {
                case "metal":
                case "plastic":
                case "paper":
                case "cardboard":
                case "aluminium":
                case "glass":
                    return true;
                default:
                    return false;
            }
        }
    }
}
