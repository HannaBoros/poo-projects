using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class GenericHS<T> where T : IComparable<T>
    {
        public GenericHS()
        {

        }
        public void MaxHeapify(T[] v, int i, int n)
        {
            int largest = i;
            int r = 2 * i + 1;
            int l = 2 * i;
            if (l <= n)
            {
                int left_bigger_than_parrent = v[l].CompareTo(v[i]);

                if (left_bigger_than_parrent == 1)
                    largest = l;
                else largest = i;
            }
            if (r <= n)
            { int right_bigger_than_largest = v[r].CompareTo(v[largest]);
                if ( right_bigger_than_largest == 1)
                    largest = r;
            }
            if (largest != i)
            {
                Swap(ref v[i], ref v[largest]);
                MaxHeapify(v, largest, n);
            }
        }
        private void Swap(ref T a, ref T b)
        {
           T aux = a;
            a = b;
            b = aux;
        }
        public void BuildMaxHeapify(T[] v, int n)
        {
            int size = v.Length - 1;
            for (int i = size / 2; i >= 1; i--)
            {
                MaxHeapify(v, i, n);
            }
        }
        public void heapSort(T[] v) 
        {
            int n = v.Length - 1;
            BuildMaxHeapify(v, n);
            for (int i = n; i >= 2; i--)
            {
                Swap(ref v[1], ref v[i]);
                n--;
                MaxHeapify(v, 1, n);
            }

        }
    }
}
