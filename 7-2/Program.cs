using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("skaicius neigiamas");
            }
            else if (a > 0)
            {
                Console.WriteLine("skaicius teigiamas");
            }
            else
            {
                Console.WriteLine("Skaicius lygus 0");
            }
        }
    }
}
