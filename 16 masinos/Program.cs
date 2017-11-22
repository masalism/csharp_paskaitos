using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audi", "A4", 2017, 2.2, 150, 3);
            automobilis.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis ("Ferarri", "LaFerarri", 2013, 7.0, 600, 10),
                new Automobilis("Porsche", "Carrera GT", 2003, 5.5, 450, 10000),
                new Automobilis("BMW", "M5", 2003, 5.0, 300, 20000),
                new Automobilis("Audi", "RS6", 2016, 6.0, 500, 12000),
                new Automobilis("Bentley", "GT", 2012, 6.0, 468, 13400),
                new Automobilis("Holden", "Monaro", 2006, 4.0, 278, 134000),
            };

            var programa = new Program();
            programa.Isvedimas(automobiliai);

            var naujausias = programa.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto: ");
            naujausias.Isvedimas();

            var seniausias = programa.SeniausiasAuto(automobiliai);
            Console.WriteLine("Seniausias auto: ");
            seniausias.Isvedimas();

            var didziausiagalia = programa.DidziausiaGalia(automobiliai);
            Console.WriteLine("Galingiausias auto: ");
            didziausiagalia.Isvedimas();

            var maziausiainuvaziaves = programa.MaziausiaiNuvaz(automobiliai);
            Console.WriteLine("Maziausios ridos auto: ");
            maziausiainuvaziaves.Isvedimas();
        }

        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        //naujausias automobilis

        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }

        public Automobilis SeniausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas2 = automobiliai.Last();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai < laikinas2.Metai)
                {
                    laikinas2 = auto;
                }
            }

            return laikinas2;
        }

        public Automobilis DidziausiaGalia(List<Automobilis> automobiliai)
        {
            var laikinas3 = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Galia > laikinas3.Galia)
                {
                    laikinas3 = auto;
                }
            }

            return laikinas3;
        }

        public Automobilis MaziausiaiNuvaz(List<Automobilis> automobiliai)
        {
            var laikinas4 = automobiliai.Last();

            foreach (var auto in automobiliai)
            {
                if (auto.Rida < laikinas4.Rida)
                {
                    laikinas4 = auto;
                }
            }

            return laikinas4;

        }
    }
}
