using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas
{
    class Automobilis
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public double DarbinisTuris { get; private set; }
        public int Galia { get; private set; }
        public int Kaina { get; private set; }

        public Automobilis(string marke, string modelis, int metai, double darbinisTuris, int galia, int kaina)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisTuris;
            Galia = galia;
            Kaina = kaina;
        }

        //isvedimas

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.). {3}, {4} kw. kurio kaina yra {5} Euru", Marke, Modelis, Metai, DarbinisTuris, Galia, Kaina);
        }
    }
}
