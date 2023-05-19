using System;

namespace Qus8
{
    public interface Shape // Drawable is an interface
    {
        public void Draw();
    }
    public class Circle : Shape //implementing interface by a class
    {
        public void Draw() //implementing interface method
        {
            Console.WriteLine("Drawing Circle!!");
        }
    }
    public class Square : Shape
    {
        public void Draw() //implementing interface method
        {
            Console.WriteLine("Drawing Square!!");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Shape d1 = new Circle();
            Shape d2 = new Square();

            d1.Draw();
            d2.Draw();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");

        }
    }
}
