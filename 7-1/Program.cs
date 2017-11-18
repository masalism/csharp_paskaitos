using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("pirmas skaicius didesnis");
            }
            else if (a < b)
            {
                Console.WriteLine("antras skaicius didesnis");
            }
            else 
            {
                Console.WriteLine("skaiciai lygus");
            }
        }
    }
}
