using System;
using System.Drawing;

namespace Qus8
{
    public interface Ishape
    {
        public void Draw();
    }
    public interface Icolor
    {
        public void Fill();
    }
    public class Oval : Ishape , Icolor
    {
        public void Draw()
        {
            Console.WriteLine("Lets draw a Oval");
        }
        public void Fill()
        {
            Console.WriteLine("Fill red Color");
        }
    }
    public class Rectangle : Ishape , Icolor
    {
        public void Draw()
        {
            Console.WriteLine("Lets draw a rectangle");
        }
        public void Fill()
        {
            Console.WriteLine("Fill black color");
        }
    }
    public class TestMultiInheritance
    {
        static void Main(String[] args) {
            Ishape s1 = new Oval();
            Icolor c1 = new Oval();
            s1.Draw();
            c1.Fill();

            Ishape s2 = new Rectangle();
            Icolor c2 = new Rectangle();
            s2.Draw();
            c2.Fill();
   
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
