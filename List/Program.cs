using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //sintakse
            //List<tipas> pavadinimas = new List<tipas>();
            //List<int> pavadinimas = new List<int> {[kintamasis], [kintamasis], [kintamasis]};

            // 1 budas
            List<int> skaiciai = new List<int>();
            skaiciai.Add(8);
            skaiciai.Add(4);
            skaiciai.Add(3);
            skaiciai.Add(4);
            skaiciai.Add(6);

            foreach (var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }


            List<char> simboliai = new List<char>();
            simboliai.Add('c');
            simboliai.Add('v');
            simboliai.Add('k');
            simboliai.Add('d');
            simboliai.Add('t');

            //saraso su duomenimis kurimas

            List<int> skaiciai2 = new List<int> { 4, 5, 4, 3, 7, 5 };
            List<double> skaiciai3 = new List<double> { 2.4, 5.8, 3.2 };
            List<string> zodziai2 = new List<string>
            {
                "kelis",
                "galas",
                "pieva"
            };

        }
    }
}
