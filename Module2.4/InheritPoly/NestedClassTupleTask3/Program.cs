using System;

namespace NestedClassTupleTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3.Работа с nested class & tuples
            //Создать вложенный enum Compass со значениям сторон света(N, S, E, W)           
//Создать влаженною структуру GeoCoordinate(свойства Value типа double; Suffix типа Compass)
//Создать метод GetRandomCoordinates возвращаюший кортеж(tuple) типа(GeoCoordinate Latitude, GeoCoordinate Longtitude)
//В этом методе создать локальную функцию генерирующую GeoCoordinate из случайных чисел(случайное число для value, и случайное для Compass) : на вход ограничение для координат(широта на больше 90 долгота не больше 180, стороны света должны соответствовать)
//Из метода мейн в переменную вернуть значение GetRandomCoordinates; Переменную объявит неявно через var.Вывести на экран что получилось
             CompassClass compassClass = new CompassClass();
            var coordinates = compassClass.GetRandomCoordinates();
            Console.WriteLine($"Latitude {coordinates.Latitude.Value}, Longtitude {coordinates.Longtitude.Value}");


    }
    }
}
