﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("Suma " + suma);
        }
    }
}
