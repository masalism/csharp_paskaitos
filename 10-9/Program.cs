﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;
            for (int i = 30; i < 60; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                }
            }
            Console.WriteLine("suma " + suma);
        }
    }
}
