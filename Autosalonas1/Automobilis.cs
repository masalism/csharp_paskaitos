using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas1
{
    class Automobilis
    {
        public string Marke { get; private set; }
        public string Modelis { get; private set; }
        public int Metai { get; private set; }
        public int Rida { get; private set; }
        public int Galia { get; private set; }
        public double Variklis { get; private set; }
        public int Kaina { get; private set; }

        public Automobilis(string marke, string modelis, int metai, int rida, int galia, double variklis, int kaina)
        {
            Marke = marke;
            Modelis = modelis;
            Metai = metai;
            Rida = rida;
            Galia = galia;
            Variklis = variklis;
            Kaina = kaina;
        }

        public void Isvedimas()
        {
            Console.WriteLine("{0} {1} ({2} m.), nuvaziavus {3} km., {4} kw, {5} L\nkaina - {6} EUR.", Marke, Modelis, Metai, Rida, Galia, Variklis, Kaina);
        }
        
    }
}
