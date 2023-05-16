using System;
namespace Qus4
{
    class SubstringtoUppercase
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string:");
            string str = Console.ReadLine();

            /*  string[] BeforeComa = str.Split(',');
              string Upstr= BeforeComa[0].ToUpper();

              Console.WriteLine( $"The substring before coma is {BeforeComa[0]} and In (uppercase) is  {Upstr}");*/

            int indOfComa = str.IndexOf(',');
            string substr = str.Substring(0, indOfComa);
            string uperStr = substr.ToUpper();

            Console.WriteLine($"Sub string in upper case is {uperStr}");

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}