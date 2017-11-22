using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            var skaicius = 15;
            Console.WriteLine(p.skaicius(skaicius));
            skaicius = 30;
        }

        private int skaicius(int sk)
        {
            return sk * 2 - 5;
        }
    }
}
