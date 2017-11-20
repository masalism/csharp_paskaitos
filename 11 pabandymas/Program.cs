using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_pabandymas
{
    class Program
    {
        static void Main(string[] args)
        {
            var atsitiktinisobj = new Random(); // susikurti  tik viena karta

            var atsitiktinis_skaicius1 = atsitiktinisobj.Next(20); // [0-20)
            var atsitiktinis_skaicius2 = atsitiktinisobj.Next(2, 10); // [2-10)
        }
    }
}
