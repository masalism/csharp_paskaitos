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

        public Autosalonas(string pavadinimas, string adresas, List<Automobilis> automobilis)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Automobilis = automobilis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine();

            foreach (var automobilis in Automobilis)
            {

            }
        }
    }
}
