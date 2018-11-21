using System;

namespace EventTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1) Климат контроль помещения
            //Класс Apartment со свойством AirTemperature. Класс AC с методом SwitchOn и сообщением "Air conditioner switched on", методом SwitchOff и сообщением "Air conditioner switched off".Класс Heater с методом SwitchOn и сообщением "Heater switched on", методом SwitchOff и сообщением "Heater switched off".При повышении температуры выше 25 градусов - включаем кондиционер, при понижении ниже 24 градусов - выключаем кондиционер.При понижении ниже 14 градусов - включаем отопление, при повышении выше 18 градусов - выключаем отопление
            Apartment apartment = new Apartment { AirTemperature = 23 };
            Heater heater = new Heater();
            AC ac = new AC();
            apartment.OnTemperatureChanged += ac.TempChange;
            apartment.OnTemperatureChanged += heater.TempChange;

            apartment.AirTemperature = 15;

            apartment.AirTemperature = 23;

        }
    }
}
