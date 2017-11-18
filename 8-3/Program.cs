using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris egzaminu rezultatus [0-10]");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());
            var vid = (double)(a + b + c) / 3;

            if (vid <= 10 && vid >= 8)
            {
                Console.WriteLine(vid + " vidurkis [8-10]");
            }
            else if (vid < 8 && vid >= 5)
            {
                Console.WriteLine(vid + " vidurkis [5-8)");
            }
            else if (vid < 5 && vid >= 0)
            {
                Console.WriteLine(vid + " vidurkis maziau negu 5");
            }
            else
            {
                Console.WriteLine("klaida");
            }
        }
    }
}
