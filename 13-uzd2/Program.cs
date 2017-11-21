using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_uzd2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pazymiai = { 5, 7, 4, 3, 10, 10, 6 };

            var didz = pazymiai[0];

            foreach (var didziausias in pazymiai)
            {
                if (didziausias > didz)
                {
                    didz = didziausias;
                }
            }
            Console.WriteLine("didziausias " + didz);

            var kiekdidziausiasmokiniu = 0;

            foreach (var pazymis in pazymiai)
            {
                if (pazymis == 10)
                {
                    kiekdidziausiasmokiniu++;
                }
            }
            Console.WriteLine("Mokiniu gavo 10 " + kiekdidziausiasmokiniu);

            var kiekgavomaziauuz4 = 0;

            foreach (var pazymis in pazymiai)
            {
                if (pazymis < 4)
                {
                    kiekgavomaziauuz4++;
                }
            }
            Console.WriteLine("Maziau nei 4 gavo " + kiekgavomaziauuz4);

        }
    }
}
