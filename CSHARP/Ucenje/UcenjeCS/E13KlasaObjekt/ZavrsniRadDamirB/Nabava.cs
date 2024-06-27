using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.ZavrsniRadDamirB
{
    internal class Nabava
    {
        public int? Sifra { get; set; }

        public int? BrojNabave { get; set; }

        public DateTime? DatumNabave { get; set; }

        public Dobavljac? Dobavljac { get; set; }
    }
}
