using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_tubes_KPL
{
    [Serializable]
    public class SampahData
    {
        public string NamaSampah { get; set; }
        public string KategoriSampah { get; set; }
        public int NominalSampah { get; set; }

        public SampahData(string namaSampah, string kategoriSampah, int nominalSampah)
        {
            NamaSampah = namaSampah;
            KategoriSampah = kategoriSampah;
            NominalSampah = nominalSampah;
        }
    }

}
