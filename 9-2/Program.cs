﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite gyvuno rusi:");
            var gyvunas = Console.ReadLine();

            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("Suo");
                    break;
                case "kate":
                    Console.WriteLine("Kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("Ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("Triusis");
                    break;
                case "papuga":
                    Console.WriteLine("Papuga");
                    break;
            }
        }
    }
}
