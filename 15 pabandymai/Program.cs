using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_pabandymai
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Mantas");
            programa.Pasisveikinti("Mantas ", "Masalis");
            statitinismetodas();

            var sumosats = programa.Suma(4, 5);
            Console.WriteLine(sumosats);

            Console.WriteLine(programa.Suma(7, 15));

            var skirtumoats = programa.Skirtumas(9, 4);
            Console.WriteLine(skirtumoats);

            var dalybosats = programa.dalyba(765, 34);
            Console.WriteLine(dalybosats);

            var daugybosats = programa.daugyba(45, 654);
            Console.WriteLine(daugybosats);

            Console.WriteLine("Ivesskite du skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var daugyba = programa.daugyba(pirmas, antras);
            var dalmuo = programa.dalyba(pirmas, antras);

            Console.WriteLine("{0}+{1}={2}", pirmas, antras, suma);
            Console.WriteLine("{0}-{1}={2}", pirmas, antras, skirtumas);
            Console.WriteLine("{0}*{1}={2}", pirmas, antras, daugyba);
            Console.WriteLine("{0}/{1}={2}", pirmas, antras, dalmuo);

            Console.WriteLine("`Iveskite dvi staciakampio krastines");
            var krastine1 = Convert.ToInt32(Console.ReadLine());
            var krastine2 = Convert.ToInt32(Console.ReadLine());

            var plotas = programa.Plotas(krastine1, krastine2);
            var perimetras = programa.Perimetras(krastine1, krastine2);

            Console.WriteLine("plotas: " + plotas);
            Console.WriteLine("perimetras: " + perimetras);

            Console.WriteLine("Iveskite trikampio ilgiausia krastine ir aukstine");
            var krastine3 = Convert.ToInt32(Console.ReadLine());
            var aukstine = Convert.ToInt32(Console.ReadLine());

            var plotastrikampio = programa.Trikampis(krastine3, aukstine);

            Console.WriteLine("Trikampio plotas: " + plotastrikampio);




        }// main metodo pabaigos skliautas

        //rasysim cia
        /* 
         pasiekiamumuas tipas pavadinimas
        */

        public void Pasisveikinti()
        {
            Console.WriteLine("Labas rytas");
        }

        public void Pasisveikinti(string vardas)
        {
            
            Console.WriteLine("Labas " + vardas);
            
        }

        public void Pasisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas, " + vardas + pavarde);
        }

        public static void statitinismetodas()
        {
            Console.WriteLine("Statitinis metodas");
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Skirtumas(int a, int b)
        {
            return a - b; 
        }

        public double dalyba(double a, double b)
        {
            return a / b;
        }

        public int daugyba(int a, int b)
        {
            return a * b;
        }

        public int Plotas(int a, int b)
        {
            return a * b;
        }

        public int Perimetras(int a, int b)
        {
            return a + a + b + b;
        }

        public int Trikampis(int a, int b)
        {
            return (a * b) / 2;
        }
    }
}
