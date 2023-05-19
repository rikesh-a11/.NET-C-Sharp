using System;

namespace ncit2076
{
    public delegate string GreetDelegate(String name);
    internal class LamdaDemo
    {
       // public string Greeting (string name)
       // {
         //   return "Hello" + name + "Namaskar";
       // }
        static void Main(string[] args)
        {
            LamdaDemo demo = new LamdaDemo();

            //anonymous method
            GreetDelegate gd =  (name) =>
            {
                return "Hello " + name  + "Namaskar !";
            };
            String res = gd("Ram");
            Console.WriteLine(res);
        }
    }
}
