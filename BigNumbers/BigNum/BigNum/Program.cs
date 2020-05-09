using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNum
{
    class Program
    {
        static void Main(string[] args)
        {
            BigNumber b2 = new BigNumber("869");
            BigNumber b3 = new BigNumber("2352");

            Console.WriteLine("Big number 1:");
            b2.display();
            Console.WriteLine("Big number 2:");
            b3.display();
            Console.WriteLine();
            //Console.WriteLine($"{b2}+{b3}={b2.Add(b3)}");
            Console.WriteLine("Sum:");
            b2.Add(b3).display();
            Console.WriteLine();
            Console.WriteLine("Multiply:");
            b2.Multiply(b3).display();
        }
    }
}
