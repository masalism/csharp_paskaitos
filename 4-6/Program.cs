using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ivestu skaiciu {0}, {1}, {2} vidurkis: {3}", a, b, c, (double)(a + b + c) / 3);
        }
    }
}
