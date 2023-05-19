using System;
namespace Qus10
{
    public class ActionDelegate
    {
        public static void AddNums(int x, float y, double z)
        {
           Console.WriteLine(x + y + z);
        }
        static void Main(string[] args)
        {
            Action<int, float, double> obj = AddNums;       //action delegate
            obj.Invoke(23, 4.56f, 970.8);
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
    }
}
