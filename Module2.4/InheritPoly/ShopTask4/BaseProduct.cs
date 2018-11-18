using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс BaseProduct со свойства Id(типа int),  Name, ListPrice, UnitName(еденица измерения) RegularDiscountQty, PremiumDiscountQty.В сетере свойства нейм сделать проверку строка не была пустой(!string.IsNullOrEmpty), в сетере свойства прайс - чтоб цена была больше нуля.В сетере RegularDiscountQty - количество товара не должно быть меньше 10 (едениц товара). в сетере PremiumDiscountQty - количество товара не должно быть меньше чем значение RegularDiscountQty.ДОбавить метод GetSalesPrice.На вход qty - количество.В нем учесть: если qty больше RegularDiscountQty но меньше PremiumDiscountQty - возвращаем цену со скидкой 10%, если больше PremiumDiscountQty - цену со скидкой 15%. Перезаписать ToSting() с тем чтоб нам возвращалось описание продукта.Инкапсулировать вызов ToSting в методе GetDesciption();
    class BaseProduct
    {
        private string _name;
        private decimal _listPrice;
        private int _regularDiscountQty;
        private int _premiumDiscountQty;
        public int Id { get; set; }       
        public string Name {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Name cannot be empty");
                }
            }
            get
            {
                return _name;
            }
           
        }
        public decimal ListPrice
        {
            set
            {
                if(value>0)
                {
                    _listPrice = value;
                }
                else
                {
                    throw new Exception("Price cannot be smaller than 0");
                }
            }
            get
            {
                return _listPrice;
            }
        }
        public string UnitName { get; set; }
        public int RegularDiscountQty
        {
            set
            {
                if(value>=10)
                {
                    _regularDiscountQty = value;
                }
                else
                {
                    _regularDiscountQty = 0;
                }
            }
            get
            {
                return _regularDiscountQty;
            }
        }
        public int PremiumDiscountQty
        {
            set
            {
                if(value>= _regularDiscountQty)
                {
                    _premiumDiscountQty = value;
                }
                else
                {
                    _premiumDiscountQty = 0;
                }
            }
            get
            {
                return _premiumDiscountQty;
            }
           
        }
        public decimal GetSalesPrice(int qty)
        {
            if (qty > RegularDiscountQty && qty < PremiumDiscountQty)
            {
                return ListPrice * 0.9m;
            }
            else
            {
                return ListPrice * 0.85m;
            }
        }
        public void GetDesciption()
        {
            Console.WriteLine(ToString()); 
        }

        protected new virtual string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nListprice: {ListPrice}\nRegularDiscountQty: {RegularDiscountQty}\nPremiumDiscountQty: {PremiumDiscountQty}\n";
        }
    }
}
