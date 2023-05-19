using System;
 
namespace Qus6
{
    public class Birds
    {
       public string color = "black";
    }
    public class sparrow : Birds 
    {
        string color = "Grey";
        public void display()
        {
            Console.WriteLine("The color of parent class is {0}",base.color);     //parent class 
            Console.WriteLine("The color of parent class is {0}",color);       //child class
        }
    }
    public class Testbirds
    {
        static void Main(string[] args)
        {
            sparrow sp = new sparrow();
            sp.display();

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
