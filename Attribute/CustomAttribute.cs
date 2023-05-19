using System;

namespace Qus17
{
    // Define a custom attribute
    [AttributeUsage(AttributeTargets.Method)]
    public class CustomAttribute : Attribute
    {
        public string Description { get; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    public class MyClass
    {
        [CustomAttribute("This is a custom attribute")]
        public void MyMethod()
        {
            Console.WriteLine("Executing MyMethod");
        }
    }

    class CustomA
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myObject = new MyClass();

            // Retrieve the method information using reflection
            var methodInfo = typeof(MyClass).GetMethod("MyMethod");

            // Retrieve the custom attribute information
            var attribute = (CustomAttribute)Attribute.GetCustomAttribute(methodInfo, typeof(CustomAttribute));

            // Use the custom attribute
            if (attribute != null)
            {
                Console.WriteLine("Attribute Description: " + attribute.Description);
            }

            // Call the method
            myObject.MyMethod();
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}