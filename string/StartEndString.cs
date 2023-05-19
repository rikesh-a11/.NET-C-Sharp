using System;

namespace Qus4
{
    class StartEndString
    {
        static void Main(string[] args)
        {
            string str = "hey how are you";
            string start = "he";
            string end = "ou";
            Console.WriteLine(str);
            bool A = str.StartsWith(start);
            bool B = str.EndsWith(end);

            if (A && B)
            {
                Console.WriteLine($"String start with {start}");
                Console.WriteLine($"String end with {end}");

            }
            else if (A)
            {

                Console.WriteLine($"The string starts with {start} but does not end with {end}");
            }
            else if (B)
            {
                Console.WriteLine($"The string  does not starts with {start} but end with {end}");

            }
            else
            {
                Console.WriteLine($"The string  does not starts with {start} and end with {end}");
            }
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}