using System;

namespace Qus16
{
    //The custom exception class called odd num exception class is created by inheriting the exception class
    public class OddException : Exception
    {
        //The property message is being overridden here
        public override string Message
        {
            get
            {
                return "Divisor can't be odd";
            }
        }
    }
    class TestCustomEXception
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two numbers:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            try
            {
                //checking if the divisor is an odd number or an even number
                if (b % 2 > 0)
                {
                    //exception is thrown if the divisor is an odd number
                    throw new OddException();
                }
                c = a / b;
                Console.WriteLine("The result is:" + c);
            }
            catch (OddException msg)
            {
                Console.WriteLine(msg.Message);
            }
           
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}


