using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;


namespace KapasitasLibrary
{
    public static class kapasitaslibrary
    {
        public static string UpdateTotalInput<T>(T total)
        {
            return "Total Sampah yang telah dimasukkan: " + total.ToString();
        }
    }
}
