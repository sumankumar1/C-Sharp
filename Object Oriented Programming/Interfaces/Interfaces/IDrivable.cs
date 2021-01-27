using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IDrivable
    {
        int Wheels { get; set; }
        int Speed { get; set; }
        void Move();
        void Stop();

    }
}
