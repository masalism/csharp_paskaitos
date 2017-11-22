using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_medis
{
    class Medis
    {
        public string Rusis { get; private set; }
        public int Amzius { get; private set; }
        public int Aukstis { get; private set; }


        public Medis(string rusis, int amzius, int aukstis)
        {
            Rusis = rusis;
            Amzius = amzius;
            Aukstis = aukstis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Medzio rusis {0}, aukstis {1} metru aukscio ({2} metu amziaus)", Rusis, Aukstis, Amzius);
        }
    }
}
