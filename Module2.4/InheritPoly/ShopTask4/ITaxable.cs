using System;
using System.Collections.Generic;
using System.Text;

namespace ShopTask4
{
    //Интерфейс ITaxable: включает свойство TaxIdentificationNumber типа string и метод GetTaxInfo(); FileFinancialStatementsToTaxAuthority();
    interface ITaxable
    {
        string TaxIdentificationNumber { get; set; }
        void GetTaxInfo();
        bool FileFinancialStatementsToTaxAuthority();
    }
}
