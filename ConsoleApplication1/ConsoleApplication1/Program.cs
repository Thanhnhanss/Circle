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
        }
    }
}
