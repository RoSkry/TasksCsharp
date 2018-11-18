using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Абстрактный класс Company.Id(типа int). Реализует интерфейсы выше.GetBillingInfo и GetShippingInfo реализуются через перегрузку ToString() на адресах.
    //Также нужны свойства BusinessOwner, SalesContact и FinanceContact типа Contact; FileFinancialStatementsToTaxAuthority() должен содержать проверку на то, что FinanceContact задан.Добавить абстрактный метод ListProducts, который возвращает массив BaseProduct.Также имеет свойтво с именем Orders типа Order[] и метод ListOrders.
   abstract class Company: IBillingAddressable,IShippingAddressable,ITaxable
    {
        public int Id { get; set; }
        public Address BillingAddress { get ; set ; }
        public Contact BusinessOwner { get; set; }
        public Contact SalesContact { get; set; }
        public Contact FinanceContact { get; set; }
        public Address ShippingAddress { get ; set ; }
        public Order[] Orders { get; set; }
        public string TaxIdentificationNumber { get ; set ; }


        public bool FileFinancialStatementsToTaxAuthority()
        {
            if (FinanceContact != null)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

        public abstract BaseProduct[] ListProducts();
        
        public void GetBillingInfo()
        {
            Console.WriteLine(BillingAddress);
        }

        public void GetShippingInfo()
        {
            Console.WriteLine(ShippingAddress);
        }

        public void GetTaxInfo()
        {
           
        }
        public void ListOrders()
        {
            foreach (var item in Orders)
            {
                Console.WriteLine(item);
            }
        }
    }
}
