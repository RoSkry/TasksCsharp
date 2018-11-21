
using System;

namespace DelegateTask1
{
    public delegate double Calculate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            //            Кейс по делегатам
            //Создать класс калькулятор с методами DoSum, DoSubstraction, DoDivision, DoMultiplication.Каждый из них принимает два инта и возвращает дабл.
            //Создать делегат примающий два инта и возвращающий дабл.
            //Создать инстанс делегата и записать в его invocation list указанные четыре метода калькулятора.
            //Вызвать методы из инвокейшн листа делегата через его метод Invoke(передать в Invoke пару переменных типа инт)
            try
            {
                Calculator calculator = new Calculator();
                Calculate calculate = calculator.DoSum;
                calculate += calculator.DoSubstraction;
                calculate += calculator.DoMultiplication;
                calculate += calculator.DoDivision;
              
                calculate.Invoke(12, 0);
                
                
             
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
            }
            catch (ArithmeticException ar)
            {
                Console.WriteLine(ar.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
