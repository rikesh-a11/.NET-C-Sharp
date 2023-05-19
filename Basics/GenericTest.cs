using System;
namespace ncit2076
{
	internal class Calculator<T>
	{
		public void Add(T a, T b)
		{
			dynamic x = a;
			dynamic y = b;
			T sum = x + y;
			Console.WriteLine("sum of {0} and {1} is {2}", a, b, sum);
		}
		public void Diff(T a, T b)
		{
			dynamic x = a;
			dynamic y = b;
			T diff = x - y;
			Console.WriteLine("Difference of {0} and {1} is {2}", a, b, diff);
		}
		public void Mult(T a, T b)
		{
			dynamic x = a;
			dynamic y = b;
			T mul = x * y;
			Console.WriteLine("multiplication of {0} and {1} is {2}", a, b, mul);
		}
	}  

		internal class GenericTest
		{
            static void Main(string[] args)
            {
                Calculator<int> gtInt = new Calculator<int>();
                gtInt.Add(3, 4);
                gtInt.Diff(5, 6);
                gtInt.Mult(5, 6);
                Calculator<double> gtDb1 = new Calculator<double>();
                gtDb1.Add(3.5f, 6.5f);
                gtDb1.Mult(3.4, 5.6);
           
			}
        }
	
}

