using System;
namespace Qus10
{
    public delegate void AddDelegate(int x, int y);
    public delegate string GreetDelegate(string str);
    public class TestDelegate
    {
        public void Addnum(int a,int b)
        {
            Console.WriteLine("Sum = " + (a + b));
        }
        public static string Greeting(string name)
        {
            return "Hey " + name;
        }
        static void Main(string[] args) 
        { 
            TestDelegate td = new TestDelegate();
            AddDelegate ad = new AddDelegate(td.Addnum);
            GreetDelegate gd = Greeting;
            ad.Invoke(5,7);
            string msg = gd("Alice");
            Console.WriteLine(msg);

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");

        }
    }
}
