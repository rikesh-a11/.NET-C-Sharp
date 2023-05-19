using System;
namespace Qus14
{
    internal class LINQ
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 90, 92, 81, 60, 100};

            //LINQ query expression
            var result1 = from scr in scores where scr > 80 select scr;

            //execute the query
            Console.WriteLine("scores greater than 80 are: ");
            foreach (int i in result1)
            {
                Console.Write(i + " ");
            }

            //another LINQ
            var result2 = from scr in scores where scr > 80 orderby scr ascending select scr;
            Console.WriteLine("\nscores greater than 80 in ascending order:");
            foreach (int a in result2)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
