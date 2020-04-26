using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angenda.utility
{
    class Display
    {
        public static void DisplayList<T>(List<T> genericList)
        {
            foreach(T elem in genericList)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }
}
