﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class E11Z1
    {
        public static void Izvedi()
        {
            int b1 = Pomocno.UcitajCijeliBroj("Unesi 1. broj");
            int b2 = Pomocno.UcitajCijeliBroj();
            Console.WriteLine(b1+b2);
        }
    }
}