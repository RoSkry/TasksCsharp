using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс UsageBaseProduct наследуемый от BaseProduct.Добавляем SubscriptionId типа гуид и ConsumptionLimit(максимльное количество товара которое можно потребить). Перезаписать ToSting() с учетом новых свойств
    class UsageBaseProduct :BaseProduct
    {
        public Guid SubscriptionId { get; set; }
        public int ConsumptionLimit { get; set; }
        protected override string ToString()
        {
            return base.ToString()+$"SubscriptionId: {SubscriptionId}\nConsumptionLimit: {ConsumptionLimit}\n";
        }
    }
}
