using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HermawanLibrary
{
    public class Kapasitas
    {
        public static T periksaKapasitas<T>()
        {
            dynamic Isi = 0;
            int Max = 6;

            try
            {
                string Sampah = Console.ReadLine();
                int SampahInt = Convert.ToInt32(Sampah);
                if (SampahInt <= Max)
                {
                    Isi++;
                }
                else
                {
                    Console.WriteLine("Kapasitas sudah penuh");
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return Isi;
        }
    }
}
