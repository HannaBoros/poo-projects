using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalProject
{
    class FileIO
    {
        public static List<string> file_Reader(string path)
        {

            List<string> fileLines = new List<string>();
            string line = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {

                    while (true)
                    {
                        line = sr.ReadLine();
                        if (line == null) break;
                        fileLines.Add(line);
                        //Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            return fileLines;
        }

        public static void file_writer(string path, List<String> lines)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
