using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    class Masina
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public double DarbinisTuris { get; private set; }
        public int Galia { get; private set; }
        public int Rida { get; private set; }

        public Masina(string marke, string modelis, int metai, double darbinisturis, int galia, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            DarbinisTuris = darbinisturis;
            Galia = galia;
            Rida = rida;

        }

        public void Isvedimas()
        {
            Console.WriteLine("Automobilis {0} {1} ({2} m.). {3}, {4} kw. nuvaziaves {5} km.", Marke, Modelis, Metai, DarbinisTuris, Galia, Rida);
        }

    }
        
}
