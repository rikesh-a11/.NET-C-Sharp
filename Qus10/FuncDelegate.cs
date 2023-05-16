using System;

namespace Qus10
{
    public class FuncDelegate
    {
        public static double AddNums(int x,float y,double z)
        {
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Func<int, float, double, double> obj = AddNums;     //Func Delegate
            double result = obj.Invoke(18, 34.5f, 1928.789);
            Console.WriteLine("The Result is in double");
            Console.WriteLine("result :" + result);
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
    }
}
