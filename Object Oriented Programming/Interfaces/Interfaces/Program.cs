using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle("BMW", 150, 4);
            car.Move();
            car.Stop();
            Console.ReadKey();
        }
    }
}
