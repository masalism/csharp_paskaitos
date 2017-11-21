using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bandymai1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testi = true;

            do
            {
                Console.WriteLine("testi? t/n");
                var pasirinkimas = Console.ReadLine();
                if (pasirinkimas != "t")
                {
                    testi = false;
                }
            } while (testi);
        }
    }
}
