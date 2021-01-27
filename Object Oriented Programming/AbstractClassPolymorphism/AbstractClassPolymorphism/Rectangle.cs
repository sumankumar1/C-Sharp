using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPolymorphism
{
    class Rectangle : Shape
    {
        double Length, Width;

        public Rectangle(double len, double wid)
        {
            Name = "Rectangle";
            Length = len;
            Width = wid;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length {Length} and width {Width}");
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
}
