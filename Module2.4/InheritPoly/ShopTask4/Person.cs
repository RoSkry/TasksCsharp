using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Абстрактный класс Person: Id(типа int), FirstName, LastName, Email.В сеттерах свойст сделать проверку чтоб строка не была пустой(!string.IsNullOrEmpty) и чтоб имейл содержал в себе знак @ и знак точки.
    abstract class Person
    {
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        public int Id { get; set; }
        public string FirstName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
                else
                {
                    throw new Exception("FirstName cannot be empty");
                }
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _lastName = value;
                }
                else
                {
                    throw new Exception("LastName cannot be empty");
                }
            }
            get
            {
                return _lastName;
            }
        }
        public string Email
        {
            set
            {
                if (!string.IsNullOrEmpty(value)&&value.Contains("@")&& value.Contains("."))
                {
                    _email = value;
                }
                else
                {
                    throw new Exception("_email cannot be empty and has to contain @ and .");
                }
            }
            get
            {
                return _email;
            }
        }
    }
}
