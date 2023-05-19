using System;
using System.Transactions;

namespace Qus10
{
    public delegate void RectDelegate(double length, double breadth);
    public class Rect
    {
        public void GetArea(double length,double breadth){
            string Area = $"Area of Rectangle = {length * breadth}";
            Console.WriteLine(Area);
        }
        public void GetPerimeter(double length,double breadth)
        {
            string perimeter = $"Perimeter of Rectangle = {2 * (length + breadth)}";
            Console.WriteLine(perimeter);
        }
        static void Main(string[] args)
        {
           Rect rectangle = new Rect();
           RectDelegate rd1 = rectangle.GetArea;
           RectDelegate rd2 = rectangle.GetPerimeter;
            RectDelegate rd = rd1 + rd2;
            rd.Invoke(4, 6);
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
    }
}
