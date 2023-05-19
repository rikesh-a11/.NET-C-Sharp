using System;
namespace Qus12
{
    internal class GenericField<T>
    {
        public void Add(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            T sum = x + y;
            Console.WriteLine("sum of {0} and {1} is {2}", a, b, sum);
        }
    }
    internal class GenericFieldTest
    {
        static void Main(string[] args)
        {
            GenericField<int> gtInt = new GenericField<int>();
            gtInt.Add(3, 4);
            
            GenericField<double> gtDb1 = new GenericField<double>();
            gtDb1.Add(3.5f, 6.5f);
           
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }

}

