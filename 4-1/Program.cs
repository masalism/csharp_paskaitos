using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo varda ir amziu:");
            var vardas = Console.ReadLine();
            var amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas {0}, o amzius {1}", vardas, amzius);
        }
    }
}
