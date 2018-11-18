using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{ 
    //Интерфейс IBillingAddressable: включает свойство BillingAddresss типа Address и метод GetBillingInfo;

    interface IBillingAddressable
    {
        Address BillingAddress { get; set; }
         void GetBillingInfo();
    }
}
