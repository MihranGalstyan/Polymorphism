using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleOne firstExample = new ExampleOne();

            //Static Polymorphism by oveloading
            firstExample.Add(11, 12, 13);
            firstExample.Add(14, 15);

            //Dynamic Polymorphism examples
            Drawing circle = new Circle();
            Console.WriteLine("Area :" + circle.Area());

            Drawing square = new Square();
            Console.WriteLine("Area :" + square.Area());

            Drawing rectangle = new Rectangle();
            Console.WriteLine("Area :" + rectangle.Area());
        }
    }
}
