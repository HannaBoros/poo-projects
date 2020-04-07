using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FileAnalyzer
    {
        private string fileName;
        private string fileContent;

        public FileAnalyzer(string filename)
        {
            this.fileName = filename;
        }

        public void readFile()
        {
           this.fileContent = System.IO.File.ReadAllText(this.fileName);
            Console.WriteLine("DEBUG - file read");
        }

        public void printFileContent()
        {
            Console.WriteLine(this.fileContent);
            Console.WriteLine("DEBUG - file display");
        }

        public int countNonWhiteSpaceCaracters()
        {
            int countC = 0;
            foreach (char c in fileContent)
            {
                if (!char.IsWhiteSpace(c))
                {
                    countC++;
                }
            }
            return countC;
        }

        public int countTotalCaracters()
        {
            return this.fileContent.Length;
        }

        public int countVowels()
        {
            int countV = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in fileContent)
            {
                if (vowels.IndexOf( c) != -1)
                {
                    countV++;
                }
            }
            return countV;
        }
        public int countConsonants()
        {
            int countC = 0;
            string consonants = "bcdfghjklmnpqrstvxzwyBCDFGHJKLMNPQRSTVXZWY";
            foreach (char c in fileContent)
            {
                if (consonants.IndexOf(c) != -1)
                {
                    countC++;
                }
            }
            return countC;
        }

        public int countLines()
        {
            int i = 1;
            foreach (char c in fileContent)
            {
                if (c == '\n')
                {
                    i++;
                }
            }
            return i;
        }

        static void main(string[] args)
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
