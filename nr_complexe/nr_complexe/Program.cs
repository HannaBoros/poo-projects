
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nr_complexe
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex nr1 = new Complex(3, 5);
            Complex nr2 = new Complex(4, 3);

            Complex.Sum(nr1, nr2);
            Complex.Diff(nr1, nr2);
            Complex.Multiply(nr1, nr2);
            Complex.Pow(nr2, 3);
            Complex.TrigonometricForm(nr2);
        }

        
    }
}
