using System;
namespace Qus3
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            // Take input from the user
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter integer {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Sort the array in ascending order
            Array.Sort(arr);

            // Display the sorted array
            Console.WriteLine("The sorted array is:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("name:rikesh shrestha");
            Console.WriteLine("roll:18");
        }
    }
}

