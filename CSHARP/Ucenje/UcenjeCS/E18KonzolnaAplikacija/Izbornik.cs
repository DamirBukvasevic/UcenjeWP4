﻿using UcenjeCS.E13KlasaObjekt.Edunova;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class Izbornik
    {

        public ObradaSmjer ObradaSmjer { get; set; }  // da ne mora raditi instancu u konstruktoru
        public ObradaPolaznik ObradaPolaznik { get; set; } 
        public ObradaGrupa ObradaGrupa { get; set; } 

        public Izbornik() 
        {
            Pomocno.DEV = true;
            ObradaSmjer = new ObradaSmjer();
            ObradaPolaznik = new ObradaPolaznik();
            ObradaGrupa = new ObradaGrupa(this); 
            PozdravnaPoruka();
            PrikaziIzbornik();
        }

        private void PrikaziIzbornik()
        {
            Console.WriteLine("Glavni izbornik");
            Console.WriteLine("1. Smjerovi");
            Console.WriteLine("2. Polaznici");
            Console.WriteLine("3. Grupe");
            Console.WriteLine("4. Izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private void OdabirOpcijeIzbornika()
        {
            
            switch(Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 4))
            {
                case 1:
                    Console.Clear();
                    ObradaSmjer.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    ObradaPolaznik.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaGrupa.PrikaziIzbornik();
                    PrikaziIzbornik();
                    break;
                case 4:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    break;
            }
        }

        private void PozdravnaPoruka()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("*** Edunova Console App v 1.0 ***");
            Console.WriteLine("*********************************");
        }
    }
}
