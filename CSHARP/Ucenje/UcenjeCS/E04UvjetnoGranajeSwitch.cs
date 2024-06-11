namespace UcenjeCS
{
    internal class E04UvjetnoGranajeSwitch
    {
        public static void Izvedi()
        {

            int i = 0;

            switch (i)
            {
                    case 0:
                    Console.WriteLine("Dobar");
                    break;
                    case 1: Console.WriteLine("Loš");
                    break;
                    case 2: Console.WriteLine("ZAO");
                    break;
                    default: Console.WriteLine("Nije definirano");
                    break;
            }

        }
    }
}
