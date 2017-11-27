using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autosalonas1
{
    class Konsultantas : Darbuotojas
    {
        public int PerMetusParduoda { get; private set; }
        public int KlientuIvertinimas { get; private set; }

        public Konsultantas(string vardas, string pavarde, string pareigos, string darboValandos, string ePastas, int perMetusParduoda, int klientuIvertinimas)
        {
            PerMetusParduoda = perMetusParduoda;
            KlientuIvertinimas = klientuIvertinimas;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Per metus parduoda automobiliu: " + PerMetusParduoda);
            Console.WriteLine("Ivertinimas: " + KlientuIvertinimas);
            Console.WriteLine();
        }
    }
}
