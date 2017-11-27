using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas1
{
    class Darbuotojas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pareigos { get; private set; }
        public string DarboValandos { get; private set; }
        public string EPastas { get; private set; }

        public Darbuotojas(string vardas, string pavarde, string pareigos, string darboValandos, string ePastas)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pareigos = pareigos;
            DarboValandos = darboValandos;
            EPastas = ePastas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Darbuotojas {0} {1}\n{2}\nDarbo laikas:{3}\nEmail - {4}", Vardas, Pavarde, Pareigos, DarboValandos, EPastas);
        }
    }
}
