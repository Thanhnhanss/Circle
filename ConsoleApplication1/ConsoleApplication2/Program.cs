using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle1 c1 = new Circle1();
            Console.WriteLine("The circle has radius" + c1.getRadius() + "has of" + c1.getArea());
            Circle1 c2 = new Circle1(2);
            Console.WriteLine("The circle has radius" + c2.getRadius() + "has of" + c2.getArea());
            Circle1 c3 = new Circle1(3.0, "Orange");
            Console.WriteLine("The circle has radium of {0} and color of {1}", c3.getRadius(), c3.GetColor());
            Console.WriteLine(c3.ToString());
        }
    }
}
