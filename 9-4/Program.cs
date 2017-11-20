using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-Stacionarus kompiuteris\n2-Nesiojamas kompiuteris\n3-Plansete");
            var a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Galite zaisti zaidimus");
                    break;
                case 2:
                    Console.WriteLine("Jus busite mobilus");
                    break;
                case 3:
                    Console.WriteLine("Ilgai laikanti baterija");
                    break;
                default:
                    Console.WriteLine("Neteisingas pasirinkimas");
                    break;
            }
        }
    }
}
