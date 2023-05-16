using System;

namespace Qus9
{
    public partial class IT
    {
        public void Csit() => Console.WriteLine("Csit is science course");
      
    }
    public partial class IT
    {
        public void bbm() => Console.WriteLine("bbm is management course");
    }
    public class TestPartialClass
    {
        static void Main()
        {
            IT i = new IT();
            i.Csit();
            i.bbm();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
} 