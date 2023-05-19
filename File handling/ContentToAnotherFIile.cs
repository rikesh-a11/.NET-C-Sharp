using System;
using System.IO;

namespace Qus13
{
    class ContentToAnotherFile
    {
        static void Main()
        {
            string sourceFilePath = @"E:\dummy\File4.txt";  // Path to the source file
            string destinationFilePath = @"E:\dummy\anotherfile.txt";     // Path to the destination file

            // Read the contents of the source file
            string[] fileLines = File.ReadAllLines(sourceFilePath);

            // Write the contents to the destination file
            File.WriteAllLines(destinationFilePath, fileLines);

            Console.WriteLine("File contents copied successfully!");
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}