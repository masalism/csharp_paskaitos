using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite bet koki skaiciu:");
            var a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} kvadratas = {1}", a, a *a);
        }
    }
}
