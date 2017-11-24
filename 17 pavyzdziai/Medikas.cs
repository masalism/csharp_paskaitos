using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Medikas : Darbuotojas
    {
        public int KiekIsgelbejoZmoniu { get; private set; }
        public double KiekSunaudojoDiazepamo { get; private set; }

        public Medikas(string vardas, string pavarde, int amzius, double alga, double etatas, int kiekIsgelbejoZmoniu, double kiekSunaudojoDiazepamo)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            KiekIsgelbejoZmoniu = kiekIsgelbejoZmoniu;
            KiekSunaudojoDiazepamo = kiekSunaudojoDiazepamo;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Isgelbejo zmoniu: " + KiekIsgelbejoZmoniu);
            Console.WriteLine("Sunaudojo diazepamo ml: " + KiekSunaudojoDiazepamo);
            Console.WriteLine();
        }
    }
}
