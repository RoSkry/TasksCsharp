using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс Address со своствами AddressLine1, AddressLine2, City, PostalCode, Province, Country.Перезаписать метод ToString так чтоб нам возвращалась строка содержащая корректную запись адреса в полном форме (Украина, Харьковская обл. г.Харьков ул.Отакара Яроша 14)
    class Address
    {
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"{Country}, {Province}, {City}, {AddressLine1}, {PostalCode}";
        }
    }
}
