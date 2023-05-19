using System;
namespace Qus12
{
    class DataStore<T>
    {
        public T Data { get; set; }
    }
 

    class GenericsClassDemo
    {
        static void Main(string[] args)
        {
            DataStore<string> strStore = new DataStore<string>();
            strStore.Data = "Hello Everyone";
            //strStorage.Data = 123; // compile-time error
            Console.WriteLine(strStore.Data);
           
            Console.WriteLine();
            Console.WriteLine("Lab: 1");
            Console.WriteLine("Name:Rikesh");
            Console.WriteLine("Roll : 18");
        }
    }
}

