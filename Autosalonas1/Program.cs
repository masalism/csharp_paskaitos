using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas1
{
    class Program
    {
        static void Main(string[] args)
        {
            var autosalonas = new Autosalonas("Salonas 11", "Masinu gatve 11", new List<Automobilis> {
                new Automobilis ("1. Ferarri", "LaFerarri", 2013, 1000, 600, 7.0, 10000000),
                new Automobilis("2. Porsche", "Carrera GT", 2003, 10000, 450, 5.5, 500000),
                new Automobilis("3. BMW", "M5", 2003, 20000, 300, 5.0, 20000),
                new Automobilis("4. Audi", "RS6", 2016, 65000, 500, 5.5, 66000),
                new Automobilis("5. Bentley", "GT", 2012, 55000, 560, 6.0, 100000),
                new Automobilis("6. Holden", "Monaro", 2009, 200000, 350, 4.8, 30000)
            });
            autosalonas.Isvedimas();
            autosalonas.IveskiteSkaiciu();
        }
    }
}
