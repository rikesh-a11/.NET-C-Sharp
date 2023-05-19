using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qus17
{
    [Obsolete("This class is deprecated. Use the NewClass instead.")]
    public class DeprecatedClass
    {
        public void DeprecatedMethod()
        {
            Console.WriteLine("This method is deprecated.");
        }
    }

    public class NewClass
    {

        [Serializable]
        public class SerializableClass
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }

    class BuiltinAttribute
    {
        static void Main(string[] args)
        {
            DeprecatedClass d1 = new DeprecatedClass();
            d1.DeprecatedMethod();

            NewClass.SerializableClass s = new NewClass.SerializableClass();
            s.Name = "Rikesh Shrestha";
            s.Age = 23;

            Console.WriteLine("Serializable Object: {0}, {1}", s.Name, s.Age);
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}