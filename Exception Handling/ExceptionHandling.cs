using System;
namespace Qus16
{
    class ExceptionHandling
    {
        static void Main()
        {
            try
            {
                // Code that might throw an exception
                int numerator = 5;
                int denominator = 0;
                int result = numerator / denominator;
                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                // Handling specific exception
                Console.WriteLine("Divide by zero error: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handling general exception
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                // Code that will always execute, regardless of an exception
                Console.WriteLine("Finally block executed");
            }

            Console.WriteLine("Program continues after exception handling");
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }

}
