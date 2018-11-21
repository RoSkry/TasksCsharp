using System;
using System.Collections.Generic;
using System.Text;

namespace EventTask2
{
    class FuelController
    {
       public void Warning(double level)
        {
            Console.WriteLine($"Fuel level is at {level}%. Please refill.");
        }
    }
}
