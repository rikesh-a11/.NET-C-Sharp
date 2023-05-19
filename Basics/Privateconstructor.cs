using System;
namespace ncit2076
{
    internal class Privateconstructor
    {
        private Privateconstructor() { }            //private constructor
        public static int cnt;                     // static variable
        public static int IncrementCount()
        {
            return ++cnt;
        }
    }

     internal class Testcounter
    {
        static void Main(string[] args)
        {
            
           //Privateconstructor pc = new Privateconstructor();     // Error cant access private constructor
            Privateconstructor.cnt = 100;
            Privateconstructor.IncrementCount();
            Console.WriteLine("Now the value of cnt = {0}", Privateconstructor.cnt);
        }
    }
}
