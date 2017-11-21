using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paband4
{
    class Program
    {
        static void Main(string[] args)
        {

            //sumos paieska
            var skaiciai = new int[] { 4, 5, 4, 3, 9, 7, 6, 5 };
            var suma = 0;

            for (int i = 0; i < skaiciai.Length; i++)
            {
                suma += skaiciai[i];
            }

            Console.WriteLine((double)suma);

            //2 budas
            var skaiciai2 = new int[] { 4, 5, 4, 3, 9, 7, 6, 5 };

            var suma2 = 0;

            foreach (var skaicius2 in skaiciai2)
            {
                suma2 += skaicius2;

                
            }
            Console.WriteLine(suma2);

            // 3 budas

            var skaiciai3 = new int[] { 4, 6, 4, 3, 9, 7, 6, 5, 4, 6 };

            var suma3 = skaiciai3.Sum();
            Console.WriteLine(suma3);
        }
    }
}
