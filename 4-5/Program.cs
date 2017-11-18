using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite bet koki sveikaji skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            var daugiklis = 1;

            Console.WriteLine("{0}*{1}={2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", a, daugiklis, a * daugiklis++);
            Console.WriteLine("{0}*{1}={2}", a, daugiklis, a * daugiklis++);
        }
    }
}
