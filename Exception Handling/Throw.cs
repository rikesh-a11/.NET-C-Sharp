using System;

namespace Qus16
{
    class ThrowDemo
    {
        static void DisplayAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("age is: " + age);
            }
            else
            {
                throw new ArithmeticException("Age cannot be Negative !!!");
            }
        }
        static void Main(string[] args)
        {
            try
            {
                DisplayAge(23);
                DisplayAge(-6);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Exception caught: " + e.Message);
            }
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}