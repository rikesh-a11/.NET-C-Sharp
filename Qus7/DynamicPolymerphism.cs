using System;
namespace Qus7
{
   public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a square");
        }
    }

    class DynamicPolymerphism
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Square();

            shape1.Draw(); // Output: Drawing a circle
            shape2.Draw(); // Output: Drawing a square
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }

}
