using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var slaptas = rnd.Next(1, 11); // [1-10)
            var spejimas = 1;

            while (spejimas != slaptas)
            {
                Console.WriteLine("Bandykite atspeti skaiciu nuo 1 iki 10");
                spejimas = Convert.ToInt32(Console.ReadLine());
                if (slaptas > spejimas)
                {
                    Console.WriteLine("slaptas skaicius didesnis");
                }
                else if (slaptas < spejimas)
                {
                    Console.WriteLine("slaptas skaicius mazesnis");
                }
                else
                {
                    Console.WriteLine("jus laimejote");
                }
            }
        }
    }
}
