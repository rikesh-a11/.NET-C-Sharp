using System;

namespace Qus13
{
    class BinaryReadeWrite
    {
        static void Main(string[] args)
        {
            string fName = @"E:\dummy\File";
            int v1 = 18;
            int v2 = 20;
            using (BinaryWriter bw = new BinaryWriter(File.Open(fName, FileMode.Create)))
            {
                bw.Write(v1);
                bw.Write(v2);
            }
            using (BinaryReader br = new BinaryReader(File.Open(fName, FileMode.Open)))
            {
                int a = br.ReadInt32();
                int b = br.ReadInt32();
                Console.WriteLine("First value is {0} Second Value is {1}", a, b);
            }
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}