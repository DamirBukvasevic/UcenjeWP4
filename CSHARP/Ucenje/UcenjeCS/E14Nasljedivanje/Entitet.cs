using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal abstract class Entitet: object
    {
        public int? Sifra { get; set; }

        protected int VidiSeUPodklasi = 7;

        private int VidiSeSamoUKlasiKojojJeDefinirano = 2;

        public override string ToString()
        {
            Console.WriteLine(VidiSeSamoUKlasiKojojJeDefinirano);
            return Sifra.ToString();
        }

    }
}
