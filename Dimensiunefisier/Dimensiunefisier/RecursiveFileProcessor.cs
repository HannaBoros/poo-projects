using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// For Directory.GetFiles and Directory.GetDirectories
// For File.Exists, Directory.Exists
using System;
using System.IO;
using System.Collections;

namespace Dimensiunefisier
{
    class RecursiveFileProcessor
    {
        public static void Main(string[] args)
        {
            string fileOrFolderName = args[0];
            {
                if (File.Exists(fileOrFolderName))
                {
                    //get size of file
                    var fi = new FileInfo(fileOrFolderName);
                    Console.WriteLine("Size of the file {0} is {1}", fi.Name, fi.Length);
                }
                else if (Directory.Exists(fileOrFolderName))
                {
                    Console.WriteLine("Size of the file {0} is {1}", fileOrFolderName, ProcessDirectory(fileOrFolderName));
                }
                else
                {
                    Console.WriteLine("{0} is not a valid file or directory.", fileOrFolderName);
                }
            }
        }

        // Process all files in the directory passed in, recurse on any directories 
        // that are found, and process the files they contain.
        public static long ProcessDirectory(string targetDirectory)
        {
           long size = 0;
            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                size += ProcessFile(fileName);
            }


            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                size += ProcessDirectory(subdirectory);
            }

            return size;
        }

        // Insert logic for processing found files here.
        public static long ProcessFile(string path)
        {
            Console.WriteLine("Processed file '{0}'.", path);
            var fi = new FileInfo(path);
            return fi.Length;
        }
    }
}
