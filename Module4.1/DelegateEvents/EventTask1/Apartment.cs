using System;
using System.Collections.Generic;
using System.Text;

namespace EventTask1
{
    class Apartment
    {
        private double _temperature;       
        public delegate void TemperatureChanged(double temp);
        public event TemperatureChanged OnTemperatureChanged;
        public double AirTemperature
        {
            set
            {
               
                    if(OnTemperatureChanged != null)
                    {
                        OnTemperatureChanged(value);
                    }
                _temperature = value;

            }
            get
            {
                return _temperature;
            }
        }
    }
}
