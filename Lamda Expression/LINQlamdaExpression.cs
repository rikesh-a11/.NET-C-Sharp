using System;

namespace Qus15
{
    class LINQlamdaExpression
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int> {8,6,4,7,3,10,13,14 };
            var nm = num.Where(x => x < 10);
            Console.WriteLine("Numbers less than 10 are:");
            foreach (int x in nm)
            { 
                Console.Write(x + " ");
            }
            var sum = num.Where(x => x < 10).Sum();
            Console.WriteLine("\nSum of the numbers is: " + sum);
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}