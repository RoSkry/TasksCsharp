using System;
using System.Collections.Generic;

namespace MyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(1,4,5,6);
            myList.Add(8);
            myList.Remove(5);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
