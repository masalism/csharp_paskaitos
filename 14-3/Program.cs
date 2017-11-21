using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();

            Console.WriteLine("Kiek pazymiu norite ivesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite {0} pazimi", i + 1);
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var didziausias = pazymiai[0];

            foreach (var pazimys in pazymiai)
            {
                if (pazimys > didziausias)
                {
                    didziausias = pazimys;
                }
            }
            Console.WriteLine("didziausias: " + didziausias);

            var maziausias = pazymiai[0];

            foreach (var pazimys in pazymiai)
            {
                if (pazimys < maziausias)
                {
                    maziausias = pazimys;
                }
            }
            Console.WriteLine("maziausias: " + maziausias);

            Console.WriteLine("Vidurkis: " + (double)pazymiai.Average());

            var rnd = new Random();
            Console.WriteLine("belekoks skaicius: " + pazymiai[rnd.Next(pazymiai.Count)]);
        }
    }
}
