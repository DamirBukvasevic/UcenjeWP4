namespace UcenjeCS
{
    internal class E01Z4
    {
        public static void Izvedi()

        {
            // zadatak: Unijeti Adresu i grad te ispisati jedno ispod drugog adresu i grad

            string Adresa;
            string Grad;

            Console.Write("Unesite adresu: ");
            Adresa = Console.ReadLine();

            Console.Write("Unesite grad: ");
            Grad = Console.ReadLine();

            Console.WriteLine("Rezultat: ");
            Console.WriteLine(Adresa);
            Console.WriteLine(Grad);

        }

    }
}
