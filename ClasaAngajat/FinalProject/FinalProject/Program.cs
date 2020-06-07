using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static char[] delimiterChars = { ' ' };
        public static Angajat lineToPerson(string line)
        {
            string[] delimitedLines = line.Split(delimiterChars);
            Angajat s = new Angajat();
            s.lastName = delimitedLines[0];
            s.firstName = delimitedLines[1];
            CultureInfo provider = new CultureInfo("en-US");
            s.time = DateTime.ParseExact(delimitedLines[2], "dd/MM/yyyy", provider);

            return s;
        }

        public static int OrderByTimeComparator(Angajat a1, Angajat a2)
        {
            int result = DateTime.Compare(a1.time, a2.time);
            return result;
        }
       

        static void Main(string[] args)
        {
            // Angajat a = new Angajat();
            // a.firstName = "hanna";
            // a.lastName = "boros";
            // a.time = new DateTime(2017, 1, 18);
            //// Console.WriteLine(a.ToString());
            // Angajat b = new Angajat();
            // b.firstName = "hanni";
            // b.lastName = "bor";
            // b.time = new DateTime(2014, 1, 18);
            // //Console.WriteLine(b.ToString());

            // Lista<Angajat> l = new Lista<Angajat>();
            // l.Add(a);
            //l.Add(b);
            // Console.WriteLine(l.ToString()); 
           
            List<string> lines = FileIO.file_Reader("../../input.txt");
            Console.WriteLine("Print the lines");
            foreach (string v in lines)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

            Console.WriteLine("Create the people");
            Lista<Angajat> angajati = new Lista<Angajat>();
            foreach (string line in lines)
            {
                Angajat a = lineToPerson(line);
                angajati.Add(a);
            }
          
            Console.WriteLine(angajati.ToString());
            Console.WriteLine("sort by name");

            angajati.Sort(null);
            FileIO.file_writer("name_sorted.txt", angajati.getLines());

            Console.WriteLine(angajati.ToString());
            Console.WriteLine("sort by time");

            angajati.Sort(OrderByTimeComparator);
            FileIO.file_writer("vechime_sorted.txt", angajati.getLines());

            Console.WriteLine(angajati.ToString());





        }
    }
}
