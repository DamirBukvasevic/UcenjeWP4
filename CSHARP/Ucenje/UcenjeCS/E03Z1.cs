namespace UcenjeCS
{
    internal class E03Z1
    {

        public static void Izvedi()
        {
            int godine;

            Console.Write("Unesite broj godina: ");
            godine = int.Parse(Console.ReadLine());

            if (godine >= 18)
            {
                Console.WriteLine("Osoba je punoljetna");
            }
            else
            {
                Console.WriteLine("Nije punoljetna");
            }
        }

    }
}
