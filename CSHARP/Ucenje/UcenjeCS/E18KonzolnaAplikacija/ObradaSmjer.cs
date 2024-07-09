
using UcenjeCS.E18KonzolnaAplikacija.Model;

namespace UcenjeCS.E18KonzolnaAplikacija
{
    internal class ObradaSmjer
    {
        public List<Smjer> Smjerovi { get; set; }

        public ObradaSmjer()
        {
            Smjerovi = new List<Smjer>();


        }
        public void PrikaziIzbornik()
        {
            Console.WriteLine("Izbornik za rad s smjerovima");
            Console.WriteLine("1. Pregled svih smjerova");
            Console.WriteLine("2. Unos novog smjera");
            Console.WriteLine("3. Promjena podataka postojećeg smjera");
            Console.WriteLine("4. Brisanje smjera");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirOcijeIzbornika();

        }
        private void OdabirOcijeIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    PrikazSmjerova();
                    PrikaziIzbornik();
                    break;
                case 2:
                    UnosNovogSmjera();
                    PrikaziIzbornik();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        private void PrikazSmjerova()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Smjerovi u aplikaciji");
            foreach (var s in Smjerovi)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("******************************");
        }

        private void UnosNovogSmjera()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("Unesi tražene podatke o smjeru");
            Smjerovi.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue),
                Naziv = Pomocno.UcitajString("Unesi naziv smjera", 50, true),
                Trajanje = Pomocno.UcitajRasponBroja("Unesi trajanje smjera", 1, 500),
                Cijena = Pomocno.UcitajDecimalniBroj("Unesi cijenu smjera", 0, 10000),
                IzvodiSeOd = Pomocno.UcitajDatum("Unesi datum od kad se izvodi smjer", true),
                Verificiran = Pomocno.UcitajBool("Da li je smjer verificiran (DA/NE)", "da")
            });
        }
    }
}
