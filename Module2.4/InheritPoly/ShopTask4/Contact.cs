using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс Contact наследуемы от Person.Добавлены свойства PhoneNumber, Position.Добавлен метод SendEmail принимающий текст.На консольку выводим $"Email with {text} has been successfully send to address  {Email}". Используем интерполяцию строк через знак доллара в начале строки. { Email}
    //в данном случае имейл контакта
    class Contact :Person
    {
        public string PhoneNumber { get; set; }
        public Position Position { get; set; }
        public void SendEmail(string text)
        {
            Console.WriteLine($"Email with {text} has been successfully send to address {Email}");
        }
    }
}
