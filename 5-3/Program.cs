using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            if (skaicius <= 0)
            {
                Console.WriteLine("Daunas!!!");
            }
            if (skaicius > 0)
            {
                Console.WriteLine("Mldc");
            }
            if (skaicius % 2 == 0)
            {
                Console.WriteLine("skaicius lyginis");
            }
            if (skaicius % 4 == 0)
            {
                Console.WriteLine(skaicius + " dalijasi is 4");
            }
            if (skaicius > 10)
            {
                Console.WriteLine(skaicius + " daugiau uz 10");
            }
        }
    }
}
