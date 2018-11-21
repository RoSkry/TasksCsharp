using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask1
{
    ////Создать класс калькулятор с методами DoSum, DoSubstraction, DoDivision, DoMultiplication.Каждый из них принимает два инта и возвращает дабл.
    public class Calculator
    {
        public double DoSum(int x, int y)
        {
            Console.WriteLine($"Sum: {x + y}");
            return x + y;
        }
        public double DoSubstraction(int x, int y)
        {
            Console.WriteLine($"Substraction: {x - y}");
            return x - y;
        }
        public double DoMultiplication(int x, int y)
        {
            Console.WriteLine($"Multiplication: {x * y}");
            return x * y;
        }
        public double DoDivision(int x, int y)
        {
            if(y!=0)
            {
                Console.WriteLine($"Division: {x / y}");
                return x / y;
            }
            throw new DivideByZeroException();
        }
    }
}
