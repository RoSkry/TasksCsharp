using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Класс LicenseBasedProduct наследуемый от BaseProduct.Добавляем свойтсва NumberOfLicenses и NumberOfDevices - сколько лицензий даем на продукт и на скольких устройствах можное его использовать.Перезаписать  ToSting() с учетом новых свойств
    class LicenseBasedProduct :BaseProduct
    {
        public int NumberOfLicenses { get; set; }
        public int NumberOfDevices { get; set; }
        protected override string ToString()
        {
            return base.ToString()+$"NumberOfLicenses: {NumberOfLicenses}/nNumberOfDevices: {NumberOfDevices}";
        }
    }
}
