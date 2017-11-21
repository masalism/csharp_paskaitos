using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paband2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = { 8, 7, 4, 6, 4, 5, 4 };
            Console.WriteLine(skaiciai[0]);
            Console.WriteLine(skaiciai[6]);
            Console.WriteLine(skaiciai[4]);
            Console.WriteLine(skaiciai[2]);

            char[] raides = { 'a', 't', 'b', 'p', 'o' };
            Console.WriteLine(raides[1]);
            Console.WriteLine(raides[2]);
            Console.WriteLine(raides[3]);

            string[] tekstas =
            {
                "Pirma teksto eilute",
                "antra teksto eilute",
                "trecia teksto eilute"
            };

            Console.WriteLine(tekstas[2]);

            int[] skaiciai2 = new int[5];
            skaiciai2[0] = 5;
            skaiciai2[1] = 4;
            skaiciai2[2] = 3;
            skaiciai2[3] = 6;
            skaiciai2[4] = 94;

            Console.WriteLine(skaiciai2[4]);

            string[] tekstas2 = new string[3];
            tekstas2[0] = "bla";
            tekstas2[1] = "ble";
            tekstas2[2] = "bli";

            Console.WriteLine(tekstas2[2]);

            // masyvo dydis ir paskutine reiksme

            int[] skaiciai3 = { 8, 7, 9, 5, 4, 3 };
            Console.WriteLine(skaiciai3.Length);
            Console.WriteLine("pirma reiksme masyve: {0}", skaiciai3[0]);
            Console.WriteLine("paskutine reiksme masyve: {0}", skaiciai3[skaiciai.Length-1]);
        }
    }
}
