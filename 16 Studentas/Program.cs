using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Haris", "Poteris", "Floperis", 113, new List<int>
            {
                3, 5, 8, 10, 1, 6
            }, new List<int>
            {
                4, 6, 10, 8, 9, 3
            }, new List<int>
            {
                10, 10, 10, 9, 9
            });

       
        studentas.Isvedimas();

        }
    }
}
