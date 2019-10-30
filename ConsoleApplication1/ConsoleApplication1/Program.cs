using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("The circle has radius" + c1.getRadius() + "has of" + c1.getArea());
            Circle c2 = new Circle(2);
            Console.WriteLine("The circle has radius" + c2.getRadius() + "has of" + c2.getArea());
            Circle c3 = new Circle(3.0, "Orange");
            Console.WriteLine("The circle has radium of {0} and color of {1}", c3.getRadius(), c3.GetColor());
            Console.WriteLine(c3.ToString());
        }
    }
}
