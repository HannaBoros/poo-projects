
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRelements
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = int.Parse(Console.ReadLine());
            int[] v = new int[l];
           
            
            int countmax = 0;
            int countmin = 0;

            for (int i = 0; i < l; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            int min = v[l - 1];
            int max = v[0];

            for (int i = 1; i < l-1; i++)
            {
                if(v[i]>=max)
                {
                    countmax++;
                    max = v[i];
                }
            }
            for (int i = l-2; i >= 1; i--)
            {
                if (v[i] <= min)
                {
                    countmin++;
                    min= v[i];
                }
            }
            if(countmax==countmin)
            {
                Console.WriteLine($"Sunt {countmax} numere LR");
            }
            else
            {
                int countLR = Math.Abs(countmin - countmax);
                Console.WriteLine($"Sunt {countLR} numere LR");
            }
           


        }

  
    }
}
