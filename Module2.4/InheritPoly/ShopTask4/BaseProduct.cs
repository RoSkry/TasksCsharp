using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс BaseProduct со свойства Id(типа int),  Name, ListPrice, UnitName(еденица измерения) RegularDiscountQty, PremiumDiscountQty.В сетере свойства нейм сделать проверку строка не была пустой(!string.IsNullOrEmpty), в сетере свойства прайс - чтоб цена была больше нуля.В сетере RegularDiscountQty - количество товара не должно быть меньше 10 (едениц товара). в сетере PremiumDiscountQty - количество товара не должно быть меньше чем значение RegularDiscountQty.ДОбавить метод GetSalesPrice.На вход qty - количество.В нем учесть: если qty больше RegularDiscountQty но меньше PremiumDiscountQty - возвращаем цену со скидкой 10%, если больше PremiumDiscountQty - цену со скидкой 15%. Перезаписать ToSting() с тем чтоб нам возвращалось описание продукта.Инкапсулировать вызов ToSting в методе GetDesciption();
    class BaseProduct
    {
        public int Id { get; set; }
        public string Name {
            set
            {
                if(!string.IsNullOrEmpty(value))
                {
                    Name = value;
                }
                else
                {
                    throw new Exception("Name cannot be empty");
                }
            }
            get
            {
                return Name;
            }
           
        }
        public decimal ListPrice
        {
            set
            {
                if(value>0)
                {
                    ListPrice = value;
                }
                else
                {
                    throw new Exception("Price cannot be smaller than 0");
                }
            }
            get
            {
                return ListPrice;
            }
        }
        public string UnitName { get; set; }
        public int RegularDiscountQty
        {
            set
            {
                if(value>=10)
                {
                    RegularDiscountQty = value;
                }
                else
                {
                    RegularDiscountQty = 0;
                }
            }
            get
            {
                return RegularDiscountQty;
            }
        }
        public int PremiumDiscountQty
        {
            set
            {
                if(value>= RegularDiscountQty)
                {
                    PremiumDiscountQty = value;
                }
                else
                {
                    PremiumDiscountQty = 0;
                }
            }
            get
            {
                return PremiumDiscountQty;
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

        private new string ToString()
        {
            return $"Id: {Id}/nName: {Name}/nListprice: {ListPrice}/nRegularDiscountQty/n: {RegularDiscountQty}/nPremiumDiscountQty: {PremiumDiscountQty}";
        }
    }
}
