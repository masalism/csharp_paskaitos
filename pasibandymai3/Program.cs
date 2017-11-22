using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pasibandymai3
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti("Mantai");
            List<double> atlyginimai = new List<double>();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);
            

            Console.WriteLine("Vidurkis atlyginimu: " + programa.Vidurkis(atlyginimai));
            Console.WriteLine("Maksimalus atlyginimas buvo: " + programa.MaksimalusAtl(atlyginimai));
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);
        }

        public void Ivedimas(List<double> atlygnimai)
        {
            Console.WriteLine("Kiek atlyginimu norite ivesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Iveskite {0}-aji atlyginima: ", i + 1);
                atlygnimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> atlyginimai)
        {
            foreach (var atlyginimas in atlyginimai)
            {
                Console.Write("{0}, ", atlyginimas);
            }

            Console.WriteLine();
        }

        public double Vidurkis(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        public double MaksimalusAtl(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }
    }
}
