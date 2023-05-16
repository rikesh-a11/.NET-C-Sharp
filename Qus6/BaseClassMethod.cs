using System;
namespace Qus6
{ 
   public class Animal
    {
        public void Makesound()
        {
            Console.WriteLine("Animal makes sound..");
        }
    }
    public class Dog : Animal
    {
        public  void Barksound()
        {
            
            Console.WriteLine("Dog barking..");
            base.Makesound();
        }
    }
     public class TestSound
    {
         static void Main()
        {
            Dog d = new Dog();
            d.Barksound();

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}