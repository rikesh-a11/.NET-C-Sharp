using System;
namespace ncit2076
{
    internal class Defaultconstructor
    {
        int roll;
        string name;
        public Defaultconstructor()     //constructor
        {
            Console.WriteLine("constructor is called here");
            roll = 18;
            name = "Rikesh Shrestha";
        }
        static void Main(string[] args)
        {
            Defaultconstructor dc = new Defaultconstructor();  //object is created and constructor is called
            Console.WriteLine("name : " +dc.name);
            Console.WriteLine("roll : " +  dc.roll);
        }
    }
}
