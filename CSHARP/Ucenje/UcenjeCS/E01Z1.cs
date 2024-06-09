namespace UcenjeCS
{
    internal class E01Z1
    {

        public static void Izvedi()
        {
            // zadatak
            // Korisnik unosi dva cijela broja i ispisuje njihov zbroj

            int broj1;
            int broj2;

            Console.Write("Unesite broj1: ");
            broj1 = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj2: ");
            broj2 = int.Parse(Console.ReadLine());

            Console.Write("Rezultat: ");
            Console.WriteLine(broj1 + broj2);

        }

    }
}
