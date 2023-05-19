using System;
namespace Qus7
{
    public class Father
    {
        public virtual void Marriage()      //overridable method
        {
            Console.WriteLine("Love Marriage"); 
         }
    }
    public class Son : Father
    {
        public  override void Marriage()  //overriding method
        {
            Console.WriteLine("Son does Arrange Marriage");
        }
    }
    public class TestOverriding
    {
         static void Main(string[] arg)
        {
            Son s = new Son();
            s.Marriage();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");

        }
    }
}