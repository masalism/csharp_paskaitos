﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite laipsnius pagal celsiju:");
            var celsijus = Convert.ToInt32(Console.ReadLine());
            double farenheitai = celsijus * 1.8 + 32;
            double kelvinai = celsijus + 273.15;

            Console.WriteLine("Temperatura pagal farenheita: " + farenheitai);
            Console.WriteLine("Temperatura pagal kelvinus: " + kelvinai);

        }
    }
}
