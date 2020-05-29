using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasaNames
{
    class Program
    {

        static void Main(string[] args)
        {
            Names a = new Names(4);
            a[0] = "Hanna";
            a[1] = "Boros";
            Console.WriteLine(a.ToString());

           //testing index out of range exeption
           //   a[5] = "error";
          
            //testing indexer of type string
            Console.WriteLine(a["1"]);

            //testing not corract format of indexer
            //Console.WriteLine(a["one"]);



        }
    }
}
