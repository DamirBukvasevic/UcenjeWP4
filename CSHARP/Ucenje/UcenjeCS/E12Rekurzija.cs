using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E12Rekurzija
    {
        public static void Izvedi()
        {
            do
            {
                //LosaMetoda();
                Console.WriteLine(Zbroj(Pomocno.UcitajCijeliBroj("Unesi broj za sumu svih brojeva do tog broja")));
            }
            while (Pomocno.UcitajCijeliBroj("-1 za prekid") != -1);
        }

        private static int Zbroj(int broj)
        {
            if (broj == 0)
            {
                return broj;
            }
            return broj + Zbroj(broj - 1);
        }

        static void LosaMetoda()
        {
            LosaMetoda();
        }


    }
}
