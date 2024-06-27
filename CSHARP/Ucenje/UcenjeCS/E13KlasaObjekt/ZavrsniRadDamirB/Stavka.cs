using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E13KlasaObjekt.ZavrsniRadDamirB
{
    internal class Stavka
    {
        public Nabava? SifraNabave { get; set; }

        public Artikl? SifraArtikla { get; set; }

        public int? KolicinaArtikla { get; set; }

        public int? Cijena { get; set; }
    }
}
