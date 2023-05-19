using System;
namespace Qus4
{
    internal class CountStringChar
    {
        static void Main(string[] args)
        {
            string str;
            int count = 1;
            int i = 0;
            Console.Write("Enter a string: ");
            str = Console.ReadLine();
            while(i < str.Length)
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {
                    count++;
                }
               i++;
            }
            Console.WriteLine("Total number of words in string {0} ",count);
            int charCount = str.Length;
            Console.WriteLine("The total characters in string {0}", charCount);
        }

    }
}

