using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Parduotuve
{
    class Parduotuve
    {
        //propg
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Preke> Prekes { get; private set; }

        public Parduotuve(string pavadinimas, string adresas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = new List<Preke>();

            // cia buvo generuoti prekes
            Console.WriteLine("1. Generuoti prekes");
            Console.WriteLine("2. Suvesti prekes");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    SugeneruotiPrekes();
                    break;
                case 2:
                    SuvestiPrekes();
                    break;
                default:
                    SugeneruotiPrekes();
                    break;
            }
        }

        public Parduotuve(string pavadinimas, string adresas, List<Preke> prekes)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Prekes = prekes;
        }

        public void SugeneruotiPrekes()
        {
            var rnd = new Random();
            var kiekPrekiu = rnd.Next(1, 20);
            var zodziai = new string[]
            {
                "Morbi",  "interdum", "ante", "ut", "rutrum", "interdum", "justo", "mi", "hicula", "tortor", "vitae", "fermentum", "nunc", "nibh", "eu", "tellus", "Suspendisse", "tincidunt", "metus", "ad"
            };

            for (int i = 0; i < kiekPrekiu; i++)
            {
                var pavadinimas = zodziai[rnd.Next(zodziai.Length)];
                var kodas = rnd.Next(10000, 100000).ToString();
                var kaina = rnd.Next(50, 100);
                var savikaina = rnd.Next(1, 50);
                var kiekis = rnd.Next(1, 100);
                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);
            }
        }

        // parduotuves isvedimo metodas
        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine("Prekiu kiekis: " + Prekes.Count);
            Console.WriteLine();

            foreach (var preke in Prekes)
            {
                // naudojamas metodas yra prekes klaseje!
                preke.Isvedimas();
            }

            Console.WriteLine("Skaiciavimai: ");
            Console.WriteLine("Visu prekiu kainu suma: " + KainuSuma());
            Console.WriteLine("Visu prekiu savikainu suma: " + SavikainuSuma());
            Console.WriteLine("Visu prekiu pajamos: " + Pajamos());
            Console.WriteLine("Bendras pelnas: " + BendrasPelnas());
            Console.WriteLine("Maziausias kiekis: ");
            MaziausiasKiekis().Isvedimas();
            /*var maziausiaskiekis = MaziausiasKiekis();
            maziausiaskieks.Isvedimas();*/
            Console.WriteLine("Brangiausia preke: ");
            BrangiausiaPreke().Isvedimas();
        }

        public void SuvestiPrekes()
        {
            Console.WriteLine("Kiek prekiu suvesti?");
            var kiekSuvesti = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiekSuvesti; i++)
            {
                Console.WriteLine("{0}-oji preke", i + 1);
                Console.Write("Pavadinimas: ");
                var pavadinimas = Console.ReadLine();
                Console.Write("Kodas: ");
                var kodas = Console.ReadLine();
                Console.Write("Kaina: ");
                var kaina = Convert.ToInt32(Console.ReadLine());
                Console.Write("Savikaina: ");
                var savikaina = Convert.ToInt32(Console.ReadLine());
                Console.Write("Kiekis: ");
                var kiekis = Convert.ToInt32(Console.ReadLine());

                var preke = new Preke(pavadinimas, kodas, kaina, savikaina, kiekis);
                Prekes.Add(preke);

            }
        }

        public double KainuSuma()
        {
            var suma = 0.0;

            foreach (var preke in Prekes)
            {
                suma += preke.Kaina * preke.Kiekis;
            }

            return suma;
        }

        public double SavikainuSuma()
        {
            var suma1 = 0.0;

            foreach (var preke in Prekes)
            {
                suma1 += preke.Savikaina * preke.Kiekis;
            }

            return suma1;
        }

        public double Pajamos()
        {
            var suma2 = 0.0;

            foreach (var preke in Prekes)
            {
                suma2 += preke.Kaina * preke.Kiekis;
            }

            return suma2;
        }

        public double BendrasPelnas()
        {
            var suma3 = 0.0;

            foreach (var preke in Prekes)
            {
                suma3 += preke.PelnasPradavusVisaKieki();
            }

            return suma3;
        }

        public Preke MaziausiasKiekis()
        {
            var maziausias = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kiekis < maziausias.Kiekis)
                {
                    maziausias = preke;
                }
            }

            return maziausias;

        }

        public Preke BrangiausiaPreke()
        {
            var brangiausia = Prekes[0];

            foreach (var preke in Prekes)
            {
                if (preke.Kaina > brangiausia.Kaina)
                {
                    brangiausia = preke;
                }
            }

            return brangiausia;
        }



    }
}
