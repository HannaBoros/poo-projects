using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapSort s = new HeapSort();
            int[] v = { 0, 8, 56, 2, 67, 98, 100 };
            s.heapSort(v);
            for (int i = 1; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }
            Console.WriteLine();
            GenericHS<Double> h1 =  new GenericHS<Double>();
            double[] v2 = { 0, 8.3, 56.9,56.11, 67.3, 98.9, 100 };
            h1.heapSort(v2);
            for (int i = 1; i < v2.Length; i++)
            {
                Console.Write(v2[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
