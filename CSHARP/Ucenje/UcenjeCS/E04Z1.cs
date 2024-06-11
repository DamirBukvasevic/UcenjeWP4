namespace UcenjeCS
{
    internal class E04Z1
    {
        public static void Izvedi()
        {
            int ocjena;

            Console.Write("Unesite ocjenu: ");
            ocjena = int.Parse(Console.ReadLine());

            switch (ocjena)
            {
                case 1 :
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2 :
                    Console.WriteLine("Dovoljan");
                    break;
                case 3 :
                    Console.WriteLine("Dobar");
                    break;
                case 4 :
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5 :
                    Console.WriteLine("Odlican");
                    break;
                default : Console.WriteLine("Nije definirano");
                    break ;
            }    


        }


    }
}
