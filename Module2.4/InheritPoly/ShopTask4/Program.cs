using System;

namespace ShopTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Написать модель данных B2B магазина
            //####
            //В Program.Main создать несколько продуктов, кастомера, вендора, создать заказ, выполнить заказ.
            try
            {
            BaseProduct samsung = new BaseProduct() { Id=4, Name="Samsung S10",ListPrice=7879, PremiumDiscountQty=12, RegularDiscountQty=23 };
                samsung.GetDesciption();
                UsageBaseProduct iphone = new UsageBaseProduct() { Id = 4, Name = "Iphone 7", ListPrice = 123, PremiumDiscountQty = 2, RegularDiscountQty = 10, ConsumptionLimit=50, SubscriptionId=Guid.NewGuid()  };

                
                Customer customer = new Customer()
                {
                    FinanceContact = new Contact()
                    {
                        Id = 1,
                        FirstName = "Ivan",
                        LastName = "Ivanov",
                        Position = Position.Accountant,
                        Email = "asdsdd@gmail.com",
                        PhoneNumber = "+43545656756"
                    },
                    BillingAddress = new Address()
                    {
                        AddressLine1 = "Central Street 12",
                        AddressLine2 = "Kharkiv region",
                        City = "Kharkiv",
                        Country = "Ukraine",
                        Province = "Central oblast",
                        PostalCode = 123
                    },
                    BusinessOwner = new Contact()
                    {
                        Id = 23,
                        FirstName = "Fedor",
                        LastName = "Fedorov",
                        Position = Position.BusinessOwner,
                        Email = "sdfer342@gmail.com",
                        PhoneNumber = "+23443456"
                    },
                    TaxIdentificationNumber = "12rtyrty",
                    ProductsInUse = new Customer.PurchasedProduct[2]
                    {new Customer.PurchasedProduct(){ Product=iphone, Qty=10, TimeofPurchase=DateTime.Now},
                        new Customer.PurchasedProduct(){Product=samsung, Qty=12, TimeofPurchase=DateTime.Now } },
                    ShippingAddress = new Address()
                    {
                        AddressLine1 = "Khreschatik 12",
                        AddressLine2 = "Kiev region",
                        City = "Kiev",
                        Country = "Ukraine",
                        Province = "Central oblast",
                        PostalCode = 11
                    },
                    SalesContact = new Contact()
                    {
                        Id = 2,
                        FirstName = "Kiril",
                        LastName = "Kirilov",
                        Position = Position.SalesManager,
                        Email = "123were@gmail.com",
                        PhoneNumber = "+2231243456"
                    },
                    Orders = new Order[2]
                    {
                      new Order()
                      { ApprovalDate=new DateTime(2018,11,15),
                      CompletionDate =new DateTime(2018,11,17),
                      CreationDate=new DateTime(2018,11,11),
                      OrderStatus=OrderStatus.Approved,
                      LineItems = new (BaseProduct,int)[2] {(samsung,2), (iphone, 3),}                    
                      }
                      , new Order()
                    { ApprovalDate=new DateTime(2018,11,12),
                      CompletionDate =new DateTime(2018,11,15),
                      CreationDate=new DateTime(2018,11,10),
                      OrderStatus=OrderStatus.Completed,
                      LineItems = new (BaseProduct,int)[2] {(iphone, 1), (samsung, 4),}
                      }},
                    Id =1

                };


                Vendor vendor = new Vendor()
                {
                    Id = 1,
                    BillingAddress = new Address
                    {
                        AddressLine1 = "Deribasovskaya Street 22",
                        AddressLine2 = "Odessa region",
                        City = "Odessa",
                        Country = "Ukraine",
                        Province = "Central oblast",
                        PostalCode = 34
                    },
                    BusinessOwner = new Contact()
                    {
                        Id = 24,
                        FirstName = "Vladimir",
                        LastName = "Vladimirov",
                        Position = Position.BusinessOwner,
                        Email = "vlad@gmail.com",
                        PhoneNumber = "+234433434456"
                    },
                   
                    SalesContact = new Contact
                    {
                        Id = 2,
                        FirstName = "Alexey",
                        LastName = "Alexeyev",
                        Position = Position.SalesManager,
                        Email = "alex@gmail.com",
                        PhoneNumber = "+123456"
                    },
                    TaxIdentificationNumber = "456534rfdfd",
                    FinanceContact = new Contact
                    {
                        Id = 2,
                        FirstName = "Alexey",
                        LastName = "Alexeyev",
                        Position = Position.Accountant,
                        Email = "alex@gmail.com",
                        PhoneNumber = "+123456"
                    },
                    Orders = new Order[2]
                    {
                      new Order()
                      { ApprovalDate=new DateTime(2018,11,15),
                      CompletionDate =new DateTime(2018,11,17),
                      CreationDate=new DateTime(2018,11,11),
                      OrderStatus=OrderStatus.Approved,
                      LineItems = new (BaseProduct,int)[2] {(iphone, 3), (samsung, 1),}
                      }
                      , new Order()
                    { ApprovalDate=new DateTime(2018,11,12),
                      CompletionDate =new DateTime(2018,11,15),
                      CreationDate=new DateTime(2018,11,10),
                      OrderStatus=OrderStatus.Completed,
                      LineItems = new (BaseProduct,int)[1] {(iphone, 1)
                      }

                      }
                    },
                    ProductsInStock = new Vendor.ProductsToSell[2]
                    {
                        new Vendor.ProductsToSell()
                        {
                            Product=iphone,
                            Qty=20,       
                        },
                         new Vendor.ProductsToSell()
                        {
                            Product=samsung,
                            Qty=10,
                        }
                    },
                };
                Order order = new Order()
                {
                    ApprovalDate = DateTime.Now.AddDays(-3),
                    CompletionDate = DateTime.Now.AddDays(-2),
                    CreationDate = DateTime.Now.AddDays(-4),
                    OrderStatus = OrderStatus.Created,
                    LineItems = new(BaseProduct, int)[2] { (iphone, 2), (samsung, 4) }
                };
                //            5.IClonable
                //Реализовать IClonable на классах из задания 4.Рассмотреть варианты deep copy, shallow copy собственной релизации, shallow copy через this.MemberwiseClone использовал для класса Vendor
                Vendor vendor1 = vendor;

                //                6.Dynamic
                //Записать в переменную типа Dynamic объект типа BaseProduct из задания 4.Вызвать ToSting().Вызвать GetDesciption().
                //Записать в эту же переменную объект типа Address. Вызвать ToSting()
                //Записать в эту же переменну объект типа Vendor. Вызвать FileFinancialStatementsToTaxAuthority()
                dynamic dyn = samsung;
                Console.WriteLine(dyn); 
                Address address = new Address()
                {
                    AddressLine1 = "Deribasovskaya Street 22",
                    AddressLine2 = "Odessa region",
                    City = "Odessa",
                    Country = "Ukraine",
                    Province = "Central oblast",
                    PostalCode = 34
                };
                dyn = address;
                Console.WriteLine(dyn);

                dyn = vendor;
                Console.WriteLine(dyn);
                //                7.Dynamic & overflow
                //Исследовать явление arithmetic overflow  в контексте использования dynamic
                //Объявим переменную типа dynamic и запишем в нее long.maxvalue(dynamic dyn = long.MaxValue)
                //Объявить переменную типа int и через приведение типов присвоем ей значение прошлой переменной(int bigInt = (int)dyn)
                //Посмотреть значение одной и другой переменной.
                //Выполнить все это внутри блока checked и получить ошибку

                dynamic dyn7 = long.MaxValue;
                int bigInt = (int)dyn7;//-1

                checked
                {               
                    int bigInt1 = (int)dyn7;//
                }

                //                8.Cast operators
                //Создать explicit operator таким образом, чтоб можно было преобразовать Vendor в Customer и наоборот.ProductsInStock должны соответсвовать ProductsInUse, при этом будет терятся часть информации. В ProductsToSell Vendor будет null, в PurchasedProduct время покупки будет DateTime.Min

                vendor = (Vendor)customer;
                customer = (Customer)vendor;


            }
            catch(OverflowException st)
            {
                Console.WriteLine(st.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message+ex.StackTrace);
            }
         
        }
    }
}






