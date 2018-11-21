using System;
using System.Collections.Generic;
using System.Text;

namespace EventTask2
{
    class Car
    {
        private double _fuelTank;
        public delegate void LevelChanged(double level);
        public event LevelChanged OnLevelChanged;
        public double FuelTank
        {
            set
            {
                if(value>0.15&&value<=1)
                {
                    _fuelTank = value;
                }
                else if(value>=0&&value<=0.15)
                {
                    OnLevelChanged(value);
                    _fuelTank = value;
                }
                else
                {
                    throw new Exception("You entered wrong level");
                }
            }
            get
            {
                return _fuelTank;
            }
        }
    }
}
