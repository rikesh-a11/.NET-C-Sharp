//File Reading 
using System;
using System.IO;
using System.Text;
namespace Qus13
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            string myfilepath = @"E:\dummy\mynextfile.txt";
            FileStream f = new FileStream(myfilepath, FileMode.Open, FileAccess.Read);
            Console.WriteLine("File is opened and contents are being Read");
            Console.WriteLine("----Contents of the file ------\n\n");
            int i = 0;
            while ((i = f.ReadByte()) != -1)
            {
                Console.Write((char)i);
            }
            f.Close();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
