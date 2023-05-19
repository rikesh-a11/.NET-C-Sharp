using System;

namespace ncit2076
{
    internal class LINQ
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 97, 92, 81, 60, 100 };

            //LINQ query expression
            var result1 = from scr in scores where scr > 80 select scr;
           
            //execute the query
            Console.WriteLine("scores greater than 80 are: ");
            foreach (int i in result1) {
              Console.WriteLine(i + " ");
            }

            //another LINQ
            var result2 = from scr in scores where scr > 80 orderby scr descending select scr;
            Console.WriteLine("scores greater than 80 in descending order");
            foreach(int a in result2)
            {
                Console.WriteLine(a + " ");
            }
        }
    }
}
