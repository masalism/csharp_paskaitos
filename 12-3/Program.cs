using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int pasirinkimas;

            do
            {
                Console.WriteLine("1 - suo\n2 - kate\n3 - ziurkenas");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());

                if (pasirinkimas < 1 || pasirinkimas > 3)
                {
                    Console.WriteLine("blogai ivestas skaicius");
                }
            } while (pasirinkimas < 1 || pasirinkimas > 3);

            Console.WriteLine("pasirinkimas: " + pasirinkimas);
        }
    }
}
