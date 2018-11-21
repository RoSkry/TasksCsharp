using System;
using System.Collections.Generic;
using System.Text;

namespace EventTask1
{
    class Heater
    {

        public void TempChange(double temp)
        {
            if (temp > 18)
            {
                SwitchOff();
            }
            else
            {
                SwitchOn();
            }
        }
        public void SwitchOn()
        {
            Console.WriteLine("Heater switched on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Heater switched off");
        }
    }
}
