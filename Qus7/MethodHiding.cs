using System;
namespace Qus7
{
    public class BaseClass
    {
        public void Display()
        {
            Console.WriteLine("BaseClass method");
        }
    }

    class DerivedClass : BaseClass
    {
        public new void Display()
        {
            Console.WriteLine("DerivedClass method");
        }
    }
    class Overhiding
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.Display();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }

}