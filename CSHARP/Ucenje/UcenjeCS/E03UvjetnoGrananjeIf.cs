namespace UcenjeCS
{
    internal class E03UvjetnoGrananjeIf
    {

        public static void Izvedi()
        {

            int i = 8;

            bool uvjet = i == 7;

            Console.WriteLine(uvjet);

            if (uvjet)
            {
                Console.WriteLine("1. Usao sam u If granu");
            }
            else
            {
                Console.WriteLine("2. Uvjet nije zadovoljen, otisao u else granu");
            }

            if (i > 2)
                Console.WriteLine("3. Usao u if bez viticastih zagrada");
            Console.WriteLine("4. Ovo se izvodi bez obzira na gornji if");


            var j = 2;

            if (i < 2 && j == 2)
            {
                Console.WriteLine("5. Logicko &");
            }

            if (j == 2 || i < 2)
            {
                Console.WriteLine("6. Logicko or | ");
            }

            if (i != 5)
            {
                Console.WriteLine("7. i nema vrijednost 5");
            }

            var ocjena = 4;

            if (ocjena == 1)
            {
                Console.WriteLine("9. nedovoljan");
            }
            else
            {
                Console.WriteLine("10. Ocjena nije dobra");
            }

            if (ocjena == 4)
            {
                Console.WriteLine("11. Vrlo dobar si");
            }
            else
            {
                Console.WriteLine("12. Ok si");
            }

            Console.WriteLine(ocjena == 4 ? "11. Vrlo dobar si" : "12. Ok si");

            if(i > 0)
            {
                if(ocjena ==4)
                {
                    Console.WriteLine("12. Gnježđenje se može zapravo zamjeniti s &&");
                }
            }


        }

    }
}
