using System;
using System.Collections.Generic;
using System.Text;

namespace NestedClassTupleTask3
{
    public class CompassClass
    {
        Random _random = new Random();
        //Создать вложенный enum Compass со значениям сторон света(N, S, E, W)
        public enum Compass
        {
            North,South,East,West
        }
       //Создать влаженною структуру GeoCoordinate(свойства Value типа double; Suffix типа Compass)
        public struct GeoCoordinate
        {
            public double Value { get; set; }
            public Compass Suffix { get; set; }
        }
        //Создать метод GetRandomCoordinates возвращаюший кортеж(tuple) типа(GeoCoordinate Latitude, GeoCoordinate Longtitude)
//В этом методе создать локальную функцию генерирующую GeoCoordinate из случайных чисел(случайное число для value, и случайное для Compass) : на вход ограничение для координат(широта на больше 90 долгота не больше 180, стороны света должны соответствовать)
        public (GeoCoordinate Latitude, GeoCoordinate Longtitude) GetRandomCoordinates()
        {
           // int s = _random.Next(1, 4);
            GeoCoordinate lat = new GeoCoordinate { Suffix = (Compass)_random.Next(1, 4), Value = _random.Next(0, 90) };
            GeoCoordinate lon =new GeoCoordinate { Suffix = (Compass)_random.Next(1, 4), Value = _random.Next(0, 180) };
            return (lat, lon);
        }
    }
}
