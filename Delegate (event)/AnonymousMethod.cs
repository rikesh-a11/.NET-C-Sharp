namespace Qus10
{
    public delegate string AnonymousDelegate(String name);
    internal class LamdaDemo
    {
        // public string Greeting (string name)
        // {
        //   return "Hello" + name + "Namaskar";
        // }
        static void Main(string[] args)
        {
            LamdaDemo demo = new LamdaDemo();

            //anonymous method  // (name) => this is lamda expression
            AnonymousDelegate gd = (name) =>
            {
                return "Hello " + name + " Namaskar!";
            };
            string str = gd("Everyone");
            Console.WriteLine(str);
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
    }
}
