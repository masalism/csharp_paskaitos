using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas1
{
    class Autosalonas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Automobilis> Automobilis { get; private set; }
        public List<Darbuotojas> Darbuotojas { get; private set; }

        public Autosalonas(string pavadinimas, string adresas, List<Automobilis> automobilis, List<Darbuotojas> darbuotojas)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Automobilis = automobilis;
            Darbuotojas = darbuotojas;

            Console.WriteLine("Pasirinkite skaiciu ka norite matyti: \n1. Automobiliai\n 2. Darbuotojai");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    IveskiteSkaiciu();
                    break;
                case 2:
                    Darbuotojai();
                    break;
                default:
                    Isvedimas();
                    break;
                    
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine();

            foreach (var automobilis in Automobilis)
            {
                automobilis.Isvedimas();
            }
        }

        public void IveskiteSkaiciu()
        {
            Console.WriteLine("Iveskite automobilio skaiciu: ");
            var kuris = Convert.ToInt32(Console.ReadLine());

            if (kuris == 1)
            {
                Automobilis[0].Isvedimas();
            }
        }

        public void Darbuotojai()
        {
            foreach (var darbuotojas in Darbuotojas)
            {
                darbuotojas.Isvedimas();
            }
        }


    }
}
