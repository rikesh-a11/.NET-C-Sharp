using System;
using System.IO;
using System.Text;
namespace Qus13
{
    class TextReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\dummy\myFile3.txt";
            // Check file if exists
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }
            // Create the file
            using (TextWriter tw = File.CreateText(fpath))
            {
                tw.WriteLine("C# File Handling textReader and textWriter");
                tw.WriteLine("Its Intersting");
            }
           
            using (TextReader tr = File.OpenText(fpath))
            {
                Console.WriteLine(tr.ReadToEnd());
            }
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
