using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("{0}=1, {0}+{1}+{2}={3}", a, b, c, a + b + c);
                    break;
                case 2:
                    Console.WriteLine("{0}=2, {0}-{1}={2}", a, c, a - c);
                    break;
                case 3:
                    Console.WriteLine("{0}=3, {1}*{2}={3}", a, b, c, b * c);
                    break;
            }
        }
    }
}
