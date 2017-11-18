using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 46;
            var kvadratas = a * a;
            var kubu = a * a * a;
            Console.WriteLine("Skaicius: " + a);
            Console.WriteLine("{0} kvadratas = {1}", a, kvadratas);
            Console.WriteLine("{0} kubas = {1}", a, kubu);
            Console.WriteLine(Math.Pow(a, 3)); // Math.pow kelia pasirinkitu laipsniu!!
        }
    }
}
