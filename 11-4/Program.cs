using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "";
            var zodis = "";
            while (a != "exit")
            {
                Console.WriteLine("Ivesktie zodi arba exit");
                a = Console.ReadLine();

                if (a != "exit")
                {
                    zodis += a + " ";
                }
            }
            Console.WriteLine(zodis);
        }
    }
}
