using System;
namespace Qus5
{
    public class Student
    {
        
        int id;
        string name;
       
        //constructor 
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        //indexer 
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return id;
                }
                else if (index == 1)
                {
                    return name;
                }
               
                return null;
            }
            set
            {
                if (index == 0)
                {
                    id = (int)value;
                }
                else if (index == 1)
                {
                    name = (string)value;
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
        }

    }

     class TestStudent
    {
        static void Main(string[] args)
        {
            Student S1 = new Student(18, "Rikesh");
            Student S2 = new Student(15, "razz");
            
            //getting the detail of Student using indexer 
            Console.WriteLine("--------Detail of Student-----------");
            Console.WriteLine("Student ID : " + S1[0]);
            Console.WriteLine("Student Name : " + S1[1]);
            Console.WriteLine("Student ID : " + S2[0]);
            Console.WriteLine("Student Name : " + S2[1]);

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }

}

