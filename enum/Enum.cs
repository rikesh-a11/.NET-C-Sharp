using System;

namespace Qus9
{
    public class TestEnum
    {
        enum DaysOfWeek 
        { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
        static void Main(string[] args)
        {
            DaysOfWeek today = DaysOfWeek.Thursday;
            DaysOfWeek yesterday = DaysOfWeek.Wednesday;
            DaysOfWeek tomorrow  = DaysOfWeek.Friday;

            Console.WriteLine("Yesterday was " + yesterday);
            Console.WriteLine("Today is " + today);
            Console.WriteLine("Tomorrow is " + tomorrow);
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");

        }
    }

}
