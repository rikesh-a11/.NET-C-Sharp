using System;
namespace ncit2076
{
    internal class Parameterizedconstructor
    {
        string name;
        int age;
        public Parameterizedconstructor(string n, int a)       //parameterized constructor
        {
            name = n;
            age = a;
        }
        public void display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("age : " + age);
        }

        static void Main(string[] args)
        {
            Parameterizedconstructor pc = new Parameterizedconstructor("Rikesh",23);
            pc.display();
        }
    }
}
