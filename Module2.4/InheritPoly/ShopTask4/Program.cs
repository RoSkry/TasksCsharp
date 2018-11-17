using System;

namespace ShopTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Написать модель данных B2B магазина

        }
    }
}


//Класс UsageBaseProduct наследуемый от BaseProduct.Добавляем SubscriptionId типа гуид и ConsumptionLimit(максимльное количество товара которое можно потребить). Перезаписать ToSting() с учетом новых свойств

//Класс LicenseBasedProduct наследуемый от BaseProduct.Добавляем свойтсва NumberOfLicenses и NumberOfDevices - сколько лицензий даем на продукт и на скольких устройствах можное его использовать.Перезаписать  ToSting() с учетом новых свойств


//Класс Address со своствами AddressLine1, AddressLine2, City, PostalCode, Province, Country.Перезаписать метод ToString так чтоб нам возвращалась строка содержащая корректную запись адреса в полном форме (Украина, Харьковская обл. г.Харьков ул.Отакара Яроша 14)

//Абстрактный класс Person: Id(типа int), FirstName, LastName, Email.В сеттерах свойст сделать проверку чтоб строка не была пустой(!string.IsNullOrEmpty) и чтоб имейл содержал в себе знак @ и знак точки.

//Энумка Position: BusinessOwner, SalesManager, Accountant

//Класс Contact наследуемы от Person.Добавлены свойства PhoneNumber, Position.Добавлен метод SendEmail принимающий текст.На консольку выводим $"Email with {text} has been successfully send to address  {Email}". Используем интерполяцию строк через знак доллара в начале строки. { Email}
//в данном случае имейл контакта

//Класс User наслеуемы от Person.Добавлены свойства DisplayName, Password, добавлен метод Login, Logout.В сеттерах свойст сделать проверку чтоб строка не была пустой (!string.IsNullOrEmpty). В логин передаем email и пассворд, выдаем сообщение если данные совпадают с данными объекта, если нет - сообщения(password is wrong, email not found)

//Интерфейс IBillingAddressable: включает свойство BillingAddresss типа Address и метод GetBillingInfo;

//Интерфейс IShippingAddressable: включает свойство ShippingAddress типа Address и метод GetShippingInfo;

//Интерфейс ITaxable: включает свойство TaxIdentificationNumber типа string и метод GetTaxInfo(); FileFinancialStatementsToTaxAuthority();

//Абстрактный класс Company.Id(типа int). Реализует интерфейсы выше.GetBillingInfo и GetShippingInfo реализуются через перегрузку ToString() на адресах.
//Также нужны свойства BusinessOwner, SalesContact и FinanceContact типа Contact; FileFinancialStatementsToTaxAuthority() должен содержать проверку на то, что FinanceContact задан.Добавить абстрактный метод ListProducts, который возвращает массив BaseProduct.Также имеет свойтво с именем Orders типа Order[] и метод ListOrders.

//Класс Customer наследумый от Company.Имеет вложенный класс PurchasedProduct со свойствами Product типа ProductBase, Qty(количество), время покупки.Имеет свойство ProductsInUse типа массив PurchasedProduct.реализация ListProducts выводит на экран списко продкуктов из массива PurchasedProduct.  Имеет метод CreateOrder принимающий массив кортежей (таплов) под названием LineItems типа (BaseProduct, Qty) и возращающий объект типа Order с CreationDate = текущее время.Метод ApproveOrder проставляет ApprovalDate заказу и меняет статус


//Класс Vendor наследумый от Company.Имеет вложенный класс ProductsToSell со свойствами Product типа ProductBase, Qty (количество), Supplier (типа Vendor).  Имеет свойство ProductsInStock типа массив ProductsToSell. реализация ListProducts выводит на экран списко продкуктов из массива ProductsToSell. 
//Имеет свойство CompleteOrder примающее аргуметом объект типа Order и проставлящее объекту CompletionDate = текущее время и меняет статус. Должна быть проверка чтоб в заказе были только товары, которые есть у вендора в количетсве не большем, чем есть на складе, иначе - сообщение о том, что невозможно закрыть заказ и ставить заказу статус UnableToComplete

//Класс Order.Свойства CreationDate, ApprovalDate, CompletionDate типа DateTime, массив кортежей (таплов) под названием LineItems типа (BaseProduct, Qty), свойство типа OrderStatus.
//Перезаписать ToSting() для вывода информации о заказе


//Enum OrderStatus: Created, Approved, Completed, UnableToComplete

//####
//В Program.Main создать несколько продуктов, кастомера, вендора, создать заказ, выполнить заказ.
