using System;
namespace Qus4
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            string str, reverseString = " ";
            Console.Write("Enter a string: ");
             str = Console.ReadLine();
            for(int i = str.Length-1; i >= 0; i--)
            {
                reverseString = reverseString + str[i];
            }
            Console.WriteLine("reverseString is {0}",reverseString);
            while(str.Length > 0)
            {
                int count = 0;
                Console.Write(str[0] + ":");
                for(int i = 0;i < str.Length;i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.WriteLine();
            Console.WriteLine("Lab : 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll : 18");
        }
    }
}