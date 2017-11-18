using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite 3 skaicius:");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a + " > " + b);
            }
            else if (b > c)
            {
                Console.WriteLine(b + " > " + c);
            }
            else if (c > a)
            {
                Console.WriteLine(c + " > " + a);
            }
            else if (a == b && b == c && a == c)
            {
                Console.WriteLine("visi skaiciai lygus");
            }
        }
    }
}
