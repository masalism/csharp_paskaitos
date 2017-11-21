using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paband3
{
    class Program
    {
        static void Main(string[] args)
        {
            // duomenu ivedimas i masyva

            int[] skaiciai = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iveskite skaiciu: ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }

            // ivedima susiejam su vartotoju pasirinkimu kiek duomenu jis nori ivesti

            Console.WriteLine("Kiek duomenu ivesti?");
            int kiek = Convert.ToInt32(Console.ReadLine());

            string[] tekstas = new string[kiek];

            for (int i = 0; i < tekstas.Length; i++)
            {
                Console.WriteLine("iveskite teksta");
                tekstas[i] = Console.ReadLine();
            }

            //duomenu isvedimas is masyvo

            int[] skaiciai2 = { 5, 8, 6, 4, 3, 5, 7, 5 };

            foreach (var skaicius2 in skaiciai2)
            {
                Console.Write(skaicius2 + " ");
            }
            Console.WriteLine();
        }
    }
}
