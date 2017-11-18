using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 546;
            var b = 272;
            var suma = a + b;
            var skirtumas = a - b;
            var dalmuo = (double)a / b;
            var sandauga = a * b;
            Console.WriteLine("{0}+{1}={2}", a, b, suma);
            Console.WriteLine("{0}-{1}={2}", a, b, skirtumas);
            Console.WriteLine("{0}/{1}={2}", a, b, dalmuo);
            Console.WriteLine("{0}*{1}={2}", a, b, sandauga);
            
        }
    }
}
