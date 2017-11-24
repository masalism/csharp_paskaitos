using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas
{
    class Autosalonas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Automobilis> Automobiliai { get; private set; }

        public Autosalonas(string pavadinimas, string adresas, List<Automobilis> automobiliai)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Automobiliai = automobiliai;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Adresas: " + Adresas);
            Console.WriteLine();
        }
    }

}
