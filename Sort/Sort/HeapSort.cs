using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class HeapSort
    {
        public void MaxHeapify(int[] v,int i, int n)
        {
            int largest;
            int r = 2 * i+1;
            int l = 2 * i;
            if (l <= n && v[l] > v[i])
                largest = l;
            else largest = i;
            if (r <=n && v[r] > v[largest])
                largest = r;
            if (largest!=i)
            {
                Swap(ref v[i], ref v[largest]);
                MaxHeapify(v, largest, n);
            }
        }
        private void Swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        public void BuildMaxHeapify(int[] v, int n)
        {
            int size = v.Length - 1;
            for (int i = size/2; i >=1 ; i--)
            {
                MaxHeapify(v, i, n);
            }
        }
        public void heapSort(int[] v)
        {
            int n = v.Length-1;
            BuildMaxHeapify(v, n);
            for (int i = n; i >=2; i--)
            {
                Swap(ref v[1], ref v[i]);
                n--;
                MaxHeapify(v, 1, n);
            }

        }
    }
}
