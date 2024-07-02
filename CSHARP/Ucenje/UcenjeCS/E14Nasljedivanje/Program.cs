using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E14Nasljedivanje
{
    internal class Program
    {

        public Program()
        {

            //Console.WriteLine("Hello");
            Smjer s = new Smjer();
            s.Naziv = "Web programiranje";
            Console.WriteLine(s);

            var p = new Polaznik() { Ime = "Pero", Sifra = 1 };

            Console.WriteLine(p);

            //var e = new Entitet();

            Obrada[] poslovi = new Obrada[2];
            poslovi[0] = new ObradaIzlazniRacun();
            poslovi[1] = new ObradaUlazniRacun();

            foreach(Obrada o in poslovi)
            {
                o.Procesuiraj();
            }

        }

        public Program(string s)
        {

            Console.WriteLine(s);
        
        }

    }
}
