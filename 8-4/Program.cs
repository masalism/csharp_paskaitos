using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b || a == 0)
            {
                Console.WriteLine(a + " didesnis uz " + b + " arba lygus 0");
            }
            if (b > a || a == 5)
            {
                Console.WriteLine(b + " didesnis uz " + a + " arba lygus 5");
            }
            if (a > b && a == 20)
            {
                Console.WriteLine(a + " didesnis uz " + b + " ir lygus 20");
            }
            if (b > a && b < 100)
            {
                Console.WriteLine(b + " didesnis uz " + a + " ir mazesnis 100");
            }
            else
            {
                Console.WriteLine("klaida");
            }
        }
    }
}
