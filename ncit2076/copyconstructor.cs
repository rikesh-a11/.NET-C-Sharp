using System;
namespace ncit2076
{
    internal class Copyconstructor
    {
        string name;
        double salary;
        public Copyconstructor(string n , double s)
        {
            name = n; 
            salary = s;
        }
        public Copyconstructor (Copyconstructor obj)        //Declaring copy constructor
        {
            name = obj.name;
            salary = obj.salary;
        }
        public void display()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("salary : " + salary);
        }
        static void Main(string[] args)
        {
            Copyconstructor cc = new Copyconstructor("Rikesh shrestha", 50000.988);
            cc.display();

        }
    }
}
