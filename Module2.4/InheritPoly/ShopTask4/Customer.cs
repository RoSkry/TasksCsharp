using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс Customer наследумый от Company.Имеет вложенный класс PurchasedProduct со свойствами Product типа ProductBase, Qty(количество), время покупки.Имеет свойство ProductsInUse типа массив PurchasedProduct.реализация ListProducts выводит на экран списко продкуктов из массива PurchasedProduct.  Имеет метод CreateOrder принимающий массив кортежей (таплов) под названием LineItems типа (BaseProduct, Qty) и возращающий объект типа Order с CreationDate = текущее время.Метод ApproveOrder проставляет ApprovalDate заказу и меняет статус

     class Customer:Company
    {
        public PurchasedProduct[] ProductsInUse { get; set; }

        public override BaseProduct[] ListProducts()
        {
            foreach (var item in ProductsInUse)
            {
                Console.WriteLine(item);
            }
            return null;
        }

        public Order CreateOrder((BaseProduct,int)[] LineItems)
        {
            return new Order() { CreationDate = DateTime.Now };
        }

        public Order ApproveOrder(DateTime date, OrderStatus orderStatus)
        {
            return new Order() { ApprovalDate = date, OrderStatus= orderStatus };
        }

        public class PurchasedProduct
        {
            public BaseProduct Product { get; set; }
            public int Qty { get; set; }
            public DateTime TimeofPurchase { get; set; }

        }
    }
}
