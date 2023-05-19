using System;
namespace ncit2076
{
    internal class Property
    {
        double _radius = 4.6;           // private field
        public double Radius            //property declaration
        { 
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
    }
    class Testcircle
    {
        static void Main(string[] args)
        {
            Property fcircle = new Property();
            double oldradius = fcircle.Radius;     //getting value using property
            Console.WriteLine("first radius of circle is :" + oldradius);
            fcircle.Radius = 5.5;       //setting value using property
            double newradius = fcircle.Radius;
            Console.WriteLine("New radius of circle is: " +  newradius);
        }
    }
}
