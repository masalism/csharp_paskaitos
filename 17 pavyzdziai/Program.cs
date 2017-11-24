using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("Mantas", "Masalis", 20, 500, 1);
            darbuotojas.Isvedimas();
            Console.WriteLine();

            var policininkas = new Policininkas("Darius", "Tulauskas", 30, 600, 1, 100, 20);
            policininkas.Isvedimas();

            var medikas = new Medikas("Ignas", "Racius", 25, 800, 0.5, 45, 124.4);
            medikas.Isvedimas();

            var darbuotojai = new List<Darbuotojas>
            {
                new Medikas("Indre", "Masalyte", 18, 300, 0.75, 1, 999.9),
                new Medikas("Galina", "Masalyte", 80, 100, 0.75, 78, 1)
            };
        }
    }
}
