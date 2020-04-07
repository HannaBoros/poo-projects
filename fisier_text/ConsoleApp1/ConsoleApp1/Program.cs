using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            FileAnalyzer fa = new FileAnalyzer(args[0]);
            fa.readFile();
            fa.printFileContent();
            Console.WriteLine(fa.countNonWhiteSpaceCaracters());
            Console.WriteLine(fa.countTotalCaracters());
            Console.WriteLine(fa.countVowels());
            Console.WriteLine(fa.countConsonants());
            Console.WriteLine(fa.countLines());
        }
    }
}
