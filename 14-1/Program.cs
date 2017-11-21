using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            //atsitiktiniu skaiciu generavimui
            var random = new Random();

            // kiek skaiciu noresime sugeneruoti
            var kieksugeneruoti = random.Next(1, 101); // [1 - 100]

            //sudedam norima kiek atsitiktiniu skaiciu
            for (int i = 0; i < kieksugeneruoti; i++)
            {
                // generuojam atsitiktini skaiciu ir ji dedam i sarasa
                skaiciai.Add(random.Next(1, 101));
                Console.Write(skaiciai[i] + " ");
            }

            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());

            var zemesniuuzvid = 0;

            var vidurkis = skaiciai.Average();
            Console.WriteLine("vidurkis skaicius: " + skaiciai.Average());

            foreach (var skaicius in skaiciai)
            {
                if (vidurkis > skaicius)
                {
                    zemesniuuzvid++;
                }
            }
            Console.WriteLine("zemensiu uz vid: " + zemesniuuzvid);

            var suma = 0;

            foreach (var sumalyginiu in skaiciai)
            {
                if (sumalyginiu % 2 == 0)
                {
                    suma += sumalyginiu;
                }
            }
            Console.WriteLine("suma lyginiu: " + suma);


        }
    }
}
