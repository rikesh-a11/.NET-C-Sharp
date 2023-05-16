using System;

namespace Qus10
{
    public delegate void Notify(); // delegate
    public class Process
    {
        public event Notify ProcessCompleted; // event
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Console.WriteLine("processing ...");
            OnProcessCompleted(); //raises an even
        }
        protected virtual void OnProcessCompleted() //protected virtual method
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke(); //'?.' is null-conditional operator
        }
    }
    public class EventDemo
    {
        public static void Main(string[] args)
        {
            Process pl = new Process();
            pl.ProcessCompleted += pl_ProcessCompleted; // register with an event
            pl.StartProcess();
            Console.WriteLine();
            Console.WriteLine("Lab 1");
            Console.WriteLine("Name : Rikesh Shrestha");
            Console.WriteLine("Roll :18");
        }
        // event handler
        public static void pl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
