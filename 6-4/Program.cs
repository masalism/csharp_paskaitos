using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo pazymi");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 10)
            {
                Console.WriteLine("Puikiai");
            }
            else if (a == 9 || a == 8)
            {
                Console.WriteLine("labai gerai");
            }
            else if (a <= 7 && a >= 5)
            {
                Console.WriteLine("patenkinamai");
            }
            else if (a == 3 || a == 4)
            {
                Console.WriteLine("Prastai");
            }
            else if (a == 2 || a == 1)
            {
                Console.WriteLine("visiskai blogai");
            }
        }
    }
}
