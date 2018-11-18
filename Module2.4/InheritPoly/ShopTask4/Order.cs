using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс Order.Свойства CreationDate, ApprovalDate, CompletionDate типа DateTime, массив кортежей (таплов) под названием LineItems типа (BaseProduct, Qty), свойство типа OrderStatus.
    //Перезаписать ToSting() для вывода информации о заказе
     class Order
    {
        public DateTime CreationDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime CompletionDate { get; set; }
        public (BaseProduct BaseProfuct, int Qty)[] LineItems { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public override string ToString()
        {
            return $"CreationDate: {CreationDate}/nApprovalDate: {ApprovalDate}/nCompletionDate: {CompletionDate}/nLineItems{LineItems}/nOrderStatus{OrderStatus}";
        }
    }
       
}
