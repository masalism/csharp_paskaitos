using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 0;

            while (skaicius % 9 != 0)
            {
                Console.WriteLine("iveskite skaiciu");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivedete skaiciu kuris dalinasi is 9!");
        }
    }
}
