using System;
namespace ncit2076
{
    internal class Staticconstructor
    {
        static string name;
        static int age;
        static Staticconstructor() {            //  static constructor     
            name = "rikesh";
            age = 23;
            Console.WriteLine("static constructor invoked!");
        }
        public Staticconstructor() {            //default constructor
            Console.WriteLine("Instance constructor invoked!");
        }
        public void display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
        }
        static void Main(string[] args)
        {
            Staticconstructor st1 = new Staticconstructor();
            Staticconstructor st2 = new Staticconstructor();
            Console.WriteLine("For object 1");
            st1.display();
            Console.WriteLine("For object 2");
            st2.display();

        }
    }
}
