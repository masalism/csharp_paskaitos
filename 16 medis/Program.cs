using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_medis
{
    class Program
    {
        static void Main(string[] args)
        {
            var medis = new Medis("Lapuotis", 58, 98);
            medis.Isvedimas();

            Console.WriteLine("Medzio aukstis centimetrais {0}",medis.Aukstis * 100);
            Console.WriteLine("Medzio amzius menesiais {0}", medis.Amzius * 12);
        }
    }

}   
