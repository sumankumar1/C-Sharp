using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassPolymorphism
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        // Must be implemented
        public abstract double Area();
    }
}
