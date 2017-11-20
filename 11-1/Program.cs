using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());

            while (a > 0)
            {
                Console.WriteLine(a);
                a--;
            }
        }
    }
}
