using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal class ObradaUlazniRacun : Obrada
    {
        public override void Procesuiraj()
        {
            Console.WriteLine("1. Vidi koliki je iznos");
            Console.WriteLine("2. Plati račun");
        }
    }
}
