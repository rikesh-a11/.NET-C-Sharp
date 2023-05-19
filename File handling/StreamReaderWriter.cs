using System;
using System.IO;
using System.Text;
namespace Qus13
{
    class StreamReaderWriter
    {
        static void Main(string[] args)
        {
            string fpath = @"E:\dummy\File4.txt";
            FileStream f1 = new FileStream(fpath, FileMode.OpenOrCreate);
            StreamWriter s1 = new StreamWriter(f1);
            s1.WriteLine("StreamReader and StreamWriter");
            s1.Close();
            f1.Close();
            FileStream f2 = new FileStream(fpath, FileMode.Open);
            StreamReader s2 = new StreamReader(f2);
            string data = s2.ReadLine();
            Console.WriteLine("The file is handle  through:");
            Console.WriteLine(data);
            s2.Close();
            f2.Close();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
