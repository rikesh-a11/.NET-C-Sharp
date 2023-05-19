using System;
using System.Collections.Generic;
namespace Qus11
{
    public class GenericTest
    {
        public static void Main(string[] args)
        {
            // Create a List of strings
            List<string> li = new List<string>();

            // Add elements to the List
            li.Add("Mercides");
            li.Add("Farari");
            li.Add("Toyota");

            // Access elements in the List
            foreach (var item in li)
            {
                Console.WriteLine( item);
            }
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
    }
}