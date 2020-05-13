using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfata
{
    class Program
    {
        public static void GeometricOperations(IForma2D figure)
        {
            Console.WriteLine($"Aria of figure {figure.Denumire} is:{figure.Arie()}");
            Console.WriteLine($"Perimeter of figure {figure.Denumire} is:{figure.LungimeaFrontierei()}");
        }
        static void Main(string[] args)
        {
            Cerc c = new Cerc(3, "Cerc");
            Patrat p = new Patrat(8, "Patrat");
            GeometricOperations(c);
            GeometricOperations(p);

        }
    }
}
