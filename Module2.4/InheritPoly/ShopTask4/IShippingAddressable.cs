using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Интерфейс IShippingAddressable: включает свойство ShippingAddress типа Address и метод GetShippingInfo;

    interface IShippingAddressable
    {
        Address ShippingAddress { get; set; }
        void GetShippingInfo();
    }
}
