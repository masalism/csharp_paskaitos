using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            var suma = 0;

            for (int i = 0; i <= 100; i++)
            {
                suma += i;
            }
            Console.WriteLine(suma);

            var suma2 = 0;

            for (int i = 20; i <= 50; i++)
            {
                if (i % 2 != 0)
                {
                    suma2 += i;
                }
            }

            Console.WriteLine(suma2);
        }
    }
}
