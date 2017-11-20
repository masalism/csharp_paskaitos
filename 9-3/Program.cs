using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-vanduo\n2-kava\n3-arbata");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Jus pasirinote vandeni");
                    break;
                case 2:
                    Console.WriteLine("Jus pasirinkote kava");
                    break;
                case 3:
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;
                default:
                    Console.WriteLine("Neteisingas pasirinkimas");
                    break;
            }
        }
    }
}
