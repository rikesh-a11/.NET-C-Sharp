using System;
namespace Qus6
{
    public class BaseClass
    {
        int num;
        public BaseClass()
        {
            Console.WriteLine("in BaseClass()");
        }
        public BaseClass(int i)
        {
            num = i;
            Console.WriteLine("in BaseClass(int i)");
        }
        public int GetNum()
        {
            return num;
        }
    }
    public class DerivedClass : BaseClass
    {
        // This constructor will call BaseClass.BaseClass()
        public DerivedClass() : base()
        {
        }
        // This constructor will call BaseClass.BaseClass(int i)
        public DerivedClass(int i) : base(i)
        {
        }
        static void Main(string[] args)
        {
            DerivedClass md = new DerivedClass();
            DerivedClass md1 = new DerivedClass(15);
            Console.WriteLine("Number = " + md1.GetNum());

            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}
