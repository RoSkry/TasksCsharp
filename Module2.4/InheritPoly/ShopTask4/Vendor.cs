using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс Vendor наследумый от Company.Имеет вложенный класс ProductsToSell со свойствами Product типа ProductBase, Qty (количество), Supplier (типа Vendor).  Имеет свойство ProductsInStock типа массив ProductsToSell. реализация ListProducts выводит на экран списко продкуктов из массива ProductsToSell. 
    //Имеет свойство CompleteOrder примающее аргуметом объект типа Order и проставлящее объекту CompletionDate = текущее время и меняет статус. Должна быть проверка чтоб в заказе были только товары, которые есть у вендора в количетсве не большем, чем есть на складе, иначе - сообщение о том, что невозможно закрыть заказ и ставить заказу статус UnableToComplete
    class Vendor : Company,ICloneable
    {
        public Vendor()
        {
            _completeOrder = new Order();
            


        }
        private Order _completeOrder;
        public ProductsToSell[] ProductsInStock { get; set; }
        public Order CompleteOrder
        {
            set
            {
                for (int i = 0; i < ProductsInStock.Length; i++)
                {
                    for (int j = 0; j < value.LineItems.Length; j++)
                    {
                        if (ProductsInStock[i].Qty > value.LineItems[i].Qty)
                        {
                            Console.WriteLine("Imposible to close the order");
                            value.OrderStatus = OrderStatus.UnableToComplete;
                        }
                        else
                       {
                        _completeOrder = value;
                       }
                    }
                }   
            }
            get
            {
                return _completeOrder;
            }
        }
    
        public override BaseProduct[] ListProducts()
        {
            foreach (var item in ProductsInStock)
            {
                Console.WriteLine(item);
            }
            return null;
        }
        public static explicit operator Vendor(Customer customer)
        {

            Vendor vendor = new Vendor();
            vendor.ProductsInStock = new ProductsToSell[customer.ProductsInUse.Length];

                for (int j = 0; j < customer.ProductsInUse.Length; j++)
                {
                vendor.ProductsInStock[j] = new ProductsToSell();
                vendor.ProductsInStock[j].Qty = customer.ProductsInUse[j].Qty;
                vendor.ProductsInStock[j].Supplier = null;
                vendor.ProductsInStock[j].Product = customer.ProductsInUse[j].Product;
                }

            vendor.BillingAddress = customer.BillingAddress;


            vendor.BusinessOwner =customer.BusinessOwner;
            vendor.SalesContact =customer.SalesContact;
            vendor.ShippingAddress =customer.ShippingAddress;
            vendor.Id =customer.Id;
            vendor.Orders =customer.Orders;
            vendor.FinanceContact =customer.FinanceContact;
            vendor.TaxIdentificationNumber =customer.TaxIdentificationNumber;
            return vendor;

        }
        public static explicit operator Customer(Vendor vendor)
        {
            Customer customer = new Customer();
            customer.ProductsInUse = new Customer.PurchasedProduct[vendor.ProductsInStock.Length];
            for (int j = 0; j < vendor.ProductsInStock.Length; j++)
            {
                customer.ProductsInUse[j] = new Customer.PurchasedProduct();
                customer.ProductsInUse[j].Qty = customer.ProductsInUse[j].Qty;
                customer.ProductsInUse[j].TimeofPurchase = DateTime.MinValue;
                customer.ProductsInUse[j].Product = customer.ProductsInUse[j].Product;
            }


            customer.Id = vendor.Id;
            customer.BillingAddress =vendor.BillingAddress;
            customer.BusinessOwner =vendor.BusinessOwner;
            customer.FinanceContact =vendor.FinanceContact;
            customer.Orders =vendor.Orders;
            customer.SalesContact =vendor.SalesContact;
            customer.ShippingAddress =vendor.ShippingAddress;
            customer.TaxIdentificationNumber =vendor.TaxIdentificationNumber;
            return customer;      
            
        }

        public object Clone()
        {
            //deep copy
            return new Vendor {
                BillingAddress = new Address()
            { AddressLine1=this.BillingAddress.AddressLine1,
               AddressLine2= this.BillingAddress.AddressLine2,
               City= this.BillingAddress.City,
               Country= this.BillingAddress.Country,
               PostalCode=this.BillingAddress.PostalCode,
               Province= this.BillingAddress.Province
            },
                BusinessOwner=new Contact()
                {
                    Email= this.BusinessOwner.Email,
                    FirstName= this.BusinessOwner.FirstName,
                    Id= this.BusinessOwner.Id,
                    LastName= this.BusinessOwner.LastName,
                    PhoneNumber= this.BusinessOwner.PhoneNumber,
                    Position= this.BusinessOwner.Position
                },
                FinanceContact = new Contact()
                {
                    Email = this.FinanceContact.Email,
                    FirstName = this.FinanceContact.FirstName,
                    Id = this.FinanceContact.Id,
                    LastName = this.FinanceContact.LastName,
                    PhoneNumber = this.FinanceContact.PhoneNumber,
                    Position = this.FinanceContact.Position
                },
                Id = this.Id,
                SalesContact = new Contact()
                {
                    Email = this.SalesContact.Email,
                    FirstName = this.SalesContact.FirstName,
                    Id = this.SalesContact.Id,
                    LastName = this.SalesContact.LastName,
                    PhoneNumber = this.SalesContact.PhoneNumber,
                    Position = this.SalesContact.Position
                },
                ShippingAddress=new Address()
                {
                    AddressLine1 = this.ShippingAddress.AddressLine1,
                    AddressLine2 = this.ShippingAddress.AddressLine2,
                    City = this.ShippingAddress.City,
                    Country = this.ShippingAddress.Country,
                    PostalCode = this.ShippingAddress.PostalCode,
                    Province = this.ShippingAddress.Province
                },
                 TaxIdentificationNumber = this.TaxIdentificationNumber,   
            };
            //shallow copy
            //return new Vendor { BillingAddress = this.BillingAddress, BusinessOwner = this.BusinessOwner, FinanceContact = this.FinanceContact, CompleteOrder = this.CompleteOrder, Id = this.Id, ProductsInStock = this.ProductsInStock, Orders = this.Orders, SalesContact = this.SalesContact, ShippingAddress = this.ShippingAddress, TaxIdentificationNumber = this.TaxIdentificationNumber };
            // return this.MemberwiseClone();
        }

        public class ProductsToSell 
            {
            public BaseProduct Product { get; set; }
            public int Qty { get; set; }
            public Vendor Supplier { get; set; }
            public ProductsToSell()
            {
                Product = new BaseProduct();
                Supplier = new Vendor();
            }
        }

    }
}
