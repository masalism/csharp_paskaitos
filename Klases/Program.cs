using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Program
    {
        static void Main(string[] args)
        {
            var masinos = new List<Masina>
            {
                new Masina("Ferarri", "LaFerarri", 2013, 7.0, 600, 10),
                new Masina("Porsche", "Carrera GT", 2003, 5.5, 450, 10000),
                new Masina("BMW", "M5", 2003, 5.0, 300, 20000),
                new Masina("Audi", "RS6", 2016, 6.0, 500, 12000),
                new Masina("Bentley", "GT", 2012, 6.0, 468, 13400),
                new Masina("Holden", "Monaro", 2006, 4.0, 278, 134000),
                new Masina("Ford", "Mustang", 1969, 5.0, 250, 430000)
            };

            var programa = new Program();
            programa.Isvedimas(masinos);
        }

        public void Isvedimas(List<Masina> masinos)
        {
            foreach (var masina in masinos)
            {
                masina.Isvedimas();
            }
        }
    }
}
