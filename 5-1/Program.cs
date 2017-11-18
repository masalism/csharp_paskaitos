using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris sveikuosius skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine(a + " = " + b);
            }
            if (b == c)
            {
                Console.WriteLine(b + " = " + c);
            }
            if (a > b)
            {
                Console.WriteLine(a + " > " + c);
            }
            if (b > c * 2)
            {
                Console.WriteLine((double)b + " daugiau uz " + c);
            }
            if (a % 2 == 0)
            {
                Console.WriteLine(a + " liginis skaicius");
            }
            if (b % 2 != 0)
            {
                Console.WriteLine(b + " nelyginis");
            }
            if (c > 0)
            {
                Console.WriteLine(c + " daugiau uz 0");
            }
            if (c < 0)
            {
                Console.WriteLine(c + " neigiamas skaicius");
            }

            Console.WriteLine("Programos pabaiga");
        }
    }
}
