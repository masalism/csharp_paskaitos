using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 - laptopas, 2 - stacionaras");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 2)
                {
                    Console.WriteLine("blogai ivestas skaicius");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 2);

            Console.WriteLine("Pasirinkimas: " + pasirinkimas);
        }
    }
}
