using System;
using System.Collections.Generic;
using System.Text;

namespace EventTask1
{
    class AC
    {

        public void TempChange(double temp)
        {
            if (temp > 25)
            {
                SwitchOn();
            }
            else
            {
                SwitchOff();
            }

        }

        public void SwitchOn()
        {
            Console.WriteLine("Air conditioner switched on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Air conditioner switched off");
        }
    }
}
