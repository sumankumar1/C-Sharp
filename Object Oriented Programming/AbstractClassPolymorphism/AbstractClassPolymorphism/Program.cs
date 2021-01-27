using System;

namespace AbstractClassPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();

                Console.WriteLine("{0} Area: {1:f2}", shape.Name, shape.Area());

                Circle testCirc = shape as Circle;
                if(testCirc == null)
                {
                    Console.WriteLine("This is not a circle\n");
                }

                if(shape is Circle)
                {
                    Console.WriteLine("This is not a rectangle\n");
                }
            }

            object circ1 = new Circle(5);
            Circle circ2 = (Circle)circ1;

            Console.WriteLine("{0} Area: {1:f2}", circ2.Name, circ2.Area());

        }
    }
}
