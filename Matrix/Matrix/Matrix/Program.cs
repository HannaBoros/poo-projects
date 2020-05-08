using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix M1 = new Matrix(3, 3);
            Matrix M2 = new Matrix(3, 3);
            Console.WriteLine("M1: ");
            M1.RandomMatrix();
            Console.WriteLine(M1);
            Console.WriteLine("M2: ");
            M2.RandomMatrix();
            Console.WriteLine(M2);
            Matrix M3;
            Console.WriteLine("Add: ");
            M3 = M1.Add(M2);
            Console.WriteLine(M3);
            Matrix M4;
            Console.WriteLine("Diff: ");
            M4 = M1.Diff(M2);
            Console.WriteLine(M4);
            Matrix M5;
            Console.WriteLine("Multiply: ");
            M5 = M1.Multiply(M2);
            Console.WriteLine(M5);
            Matrix M6;
            Console.WriteLine("Power: ");
            M6 = M1.Power(3);
            Console.WriteLine(M6);
            Matrix M7;
            double d = M2.GetDeterminant();
            Console.WriteLine("Determinant: ");
            Console.WriteLine(d);
            Console.WriteLine();
            if (d != 0)
            {
                
                M7 = M2.GetInverseMatrix(d);
                Console.WriteLine("Inverse");
                Console.WriteLine(M7);
            }
            else
            {
                Console.WriteLine("Matrix is not inversable");
            }
            Console.WriteLine();
        }
    }
}
