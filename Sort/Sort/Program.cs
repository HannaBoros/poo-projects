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
            int[] v = { 0, 4, 6, 2, 7,3 };
            s.heapSort(v);
            for (int i = 1; i < v.Length; i++)
            {
                Console.Write(v[i]+" ");
            }
        }
    }
}
