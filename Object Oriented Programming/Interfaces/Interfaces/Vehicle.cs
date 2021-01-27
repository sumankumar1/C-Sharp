using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Vehicle : IDrivable
    {
        public int Wheels { get; set; }
        public int Speed { get ; set ; }

        public string Brand { get; set; }

        public Vehicle(string brand = "No Brand", int speed = 0, int wheels =0 )
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"This {Brand} moves at speed {Speed}");
        }

        public void Stop()
        {
            Speed = 0;
            Console.WriteLine($"This {Brand} moves at speed {Speed}");
        }
    }
}
