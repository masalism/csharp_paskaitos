using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite reziu pradzia ir pabaiga");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine("{0} - {1}", i, i * i);
                }
            }
            else if (a > b)
            {
                Console.WriteLine("Neteisingai ivedete");
            }
        }
    }
}
