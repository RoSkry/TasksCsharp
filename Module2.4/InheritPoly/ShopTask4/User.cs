using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс User наслеуемы от Person.Добавлены свойства DisplayName, Password, добавлен метод Login, Logout.В сеттерах свойст сделать проверку чтоб строка не была пустой (!string.IsNullOrEmpty). В логин передаем email и пассворд, выдаем сообщение если данные совпадают с данными объекта, если нет - сообщения(password is wrong, email not found)
    class User : Person
    {
        private string _displayName;
        private string _password;
        public string DisplayName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _displayName = value;
                }
                else
                {
                    throw new Exception("FirstName cannot be empty");
                }
            }
            get
            {
                return _displayName;
            }
        }
        public string Password {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _password = value;
                }
                else
                {
                    throw new Exception("FirstName cannot be empty");
                }
            }
            get
            {
                return _password;
            }
        }
        public void Login(string email, string password)
        {
            if(this.Email== email&&this.Password==password)
            {
                Console.WriteLine("Everything is ok");
            }
            else
            {
                Console.WriteLine("Password is wrong, email not found");
            }
        }
        public void Logout()
        {

        }

    }
}
