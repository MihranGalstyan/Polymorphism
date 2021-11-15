using System;

namespace Polymorphism
{
    public class Drawing
    {
        public virtual double Area()
        {
            return 0;
        }
    }

    public class Circle : Drawing
    {
        public double Radius { get; set; }

        //Class constructor
        public Circle()
        {
            Radius = 5;
        }

        //Overriding of method Area
        public override double Area()
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }

    public class Square : Drawing
    {
        public double Length { get; set; }

        //Class constructor
        public Square()
        {
            Length = 6;
        }

        //Overriding of method Area
        public override double Area()
        {
            return Math.Pow(Length, 2);
        }
    }

    public class Rectangle : Drawing
    {
        public double Height { get; set; }
        public double Width { get; set; }

        //Class constructor
        public Rectangle()
        {
            Height = 5.3;
            Width = 3.4;
        }

        //Overriding of method Area
        public override double Area()
        {
            return Height * Width;
        }
    }
}
