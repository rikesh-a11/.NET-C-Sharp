using System;

namespace Qus8
{
    public abstract class Animal            //abstract class
    {
        public abstract void features();        //abstract method
    }
    public class Horse : Animal
    {
        public override void features()
        {
            Console.WriteLine("Horses run faster");
        }
    }
    public class Fox : Animal
    {
        public override void features()
        {
            Console.WriteLine("Foxes are clever");
        }
    }
    public class AbstractClassTest
    {
        static void Main(string[] args)
        {
            Animal an1 = new Horse();
            Animal an2 = new Fox();

            an1.features();
            an2.features();

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");

        }
    }
}

