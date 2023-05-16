using System;
namespace Qus3
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][]
            {
            new int[] { 1, 2, 6, 8 },
             new int[] { 2, 5 , 7, 9 },
             new int[] { 2, 5 , 7 , 10 }
            };

            // Display the jagged array
            Console.WriteLine("The jagged array is:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("name: Rikesh shrestha");
            Console.WriteLine("Roll: 18");
        }
    }
}

