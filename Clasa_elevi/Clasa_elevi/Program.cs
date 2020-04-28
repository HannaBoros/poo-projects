using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_elevi
{
    class Program
    {
        static char[] delimiterChars = { ' '};
        public static Student lineToPerson(string line)
        {
            string[] delimitedLines = line.Split(delimiterChars);
            Student s = new Student();
            s.lastName = delimitedLines[0];
            s.firstName = delimitedLines[1];
            int note = int.Parse(delimitedLines[2]);
           double sum = 0;
 
               
                for (int i=3; i < delimitedLines.Length; i++)
                {
                    sum = sum + int.Parse(delimitedLines[i]);
                }
            s.average = sum / note;
           
            return s;
     
        }
        public static void DisplayStudents(List<Student> students)
        {
            foreach(Student s in students)
            {
                Console.WriteLine(s.ToString());
            }
        }




        static void Main(string[] args)
        {
           // Student s = new Student();
            // read the file lines
            List<string> lines = FileIO.file_Reader("../../input.txt");
            Console.WriteLine("Print the lines");
            foreach(string v in lines)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();

            Console.WriteLine("Create the students");
            List<Student> students = new List<Student>();
            foreach (string line in lines)
            {
                Student s= lineToPerson(line);
                students.Add(s);
            }
            Console.WriteLine("Print the students");
            DisplayStudents(students);

            Console.WriteLine();
            Console.WriteLine("Order students by avarage grade");
            students.Sort();
            DisplayStudents(students);



        }
    }
}
