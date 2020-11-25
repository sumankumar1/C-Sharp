using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPolymorphism
{
    class Circle : Shape
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a radius of {Radius}");
        }
        public override double Area()
        {
            return 0.5 * Math.PI * Math.Pow(Radius, 2);
        }
    }
}
