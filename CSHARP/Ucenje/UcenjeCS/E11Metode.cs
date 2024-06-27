namespace UcenjeCS
{
    internal class E11Metode
    {
        public static void Izvedi()
        {
            for (int i = 0; i < 55; i++)
            {
                Tip1();
            }

            Tip2("Edunova");

            Console.WriteLine("Unesi ime: ");
            Tip2(Console.ReadLine());

            Tip2("Pero", "Perić");

            int broj = Tip3();
            Console.WriteLine(broj);

            for (int i = 0; i < 55; i++)
            {
                Console.WriteLine(Tip3());
            }

            Console.WriteLine(Tip4(2,8));
        }

        private static void Tip1()
        {
            Console.WriteLine("Hello iz metode koja ne prima parametre i ne vraća vrijednosti");
            Console.WriteLine("Drugi red");
            Console.WriteLine("Treći red");
        }

        static void Tip2(string ime)
        {
            Console.WriteLine("Hello {0}", ime);
        }

        static void Tip2(string ime, string prezime)
        {
            Console.WriteLine("Hello {0} {1} {2} {3}", ime, prezime, ime, ime);
        }

        static int Tip3()
        {
            return new Random().Next(20, 30);

            //return '7';
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="odBroja"></param>
        /// <param name="doBroja"></param>
        /// <returns></returns>

        protected static int Tip4(int odBroja, int doBroja)
        {
            int suma = 0;
            for (int i = odBroja; i <= doBroja; i++)
            {
                suma += i;
            }

            return suma;
        }

        static bool primBroj(int broj)
        {
            for(int i=2; i<broj;i++)
            {
                if(broj% i == 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
