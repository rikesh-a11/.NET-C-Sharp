using System;
namespace Qus9
{
    public struct Student
    {
        public string name;
        public int age;
        public int roll;
        public void display()
        {
            string details = $"Name: {name}\n Age: {age}\nROllno: {roll}";
            Console.WriteLine(details);
        }
    }
        public class TestStructure
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.name = "rajesh";
                s1.age = 22;
                s1.roll = 08;
            Console.WriteLine("-------Detail of first student-----");
                s1.display();

            Student s2 = new Student();
            s2.name = "sarita";
            s2.age = 24;
            s2.roll = 10;
            Console.WriteLine("-------Detail of second student-----");
            s2.display();

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
            }
        }
}

