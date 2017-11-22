using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasibandymai3
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti("Mantai");
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);
        }
    }
}
