using System;

namespace EventTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            2) Контроль расхода топлива
            //Class Car, свойство FuelTank типа дабл. Класс FuelController с методом Warning принимающим параметр типа дабл и сообщением $"Fuel level is at {входной параметр}%. Please refill".Метод Warning срабатывает если уровень топлива равен или ниже 15 % (double level = 0.15; .ToString("P"))
            try
            {
                FuelController fuelController = new FuelController();
                Car car = new Car() { FuelTank = 0.6 };
                car.OnLevelChanged += fuelController.Warning;
                car.FuelTank = 0.1;
                Console.WriteLine();
                car.FuelTank = 1.0;

                car.FuelTank = 1.5;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }







        }
    }
}
