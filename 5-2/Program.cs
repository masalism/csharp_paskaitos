using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite savo amziu");
            var amzius = Convert.ToInt32(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("jus galite balsuoti");
            }
        }
    }
}
