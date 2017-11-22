using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_pabandymai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Atsisveikinti();
            programa.Atsisveikinti("Mantai");
        }

        public void Atsisveikinti()
        {
            Console.WriteLine("Viso");
        }

        public void Atsisveikinti(string vardas)
        {
            Console.WriteLine("Viso " + vardas);
        }
    }
}
