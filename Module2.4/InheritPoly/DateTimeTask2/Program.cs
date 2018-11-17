using System;
using System.Globalization;

namespace DateTimeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            2.Работа со временем
            // Получить текущее локальное время
            DateTime dateLocal = DateTime.Now;
            //Получить текущее локально время с указанием временного пояса
            DateTimeOffset localTime = DateTimeOffset.Now;
            Console.WriteLine("Local time: {0}", localTime);
            //Получить текущее время UTC
            DateTime dateUtc = DateTime.UtcNow;
            //Вычесть из текущего времени 3 дня
            DateTime date = DateTime.Now.AddDays(-3);
            //Получить период времени между текущим и временем 3 дня назад через а) оператор - б) метод Substract
            TimeSpan time = dateLocal - date;
            Console.WriteLine($"operator - {time}");

            TimeSpan time1 = dateLocal.Subtract(DateTime.Now.AddDays(-3));
            Console.WriteLine($"method Substract - {time1}");
            //Привести текущее время к строке в различных форматах(longdate, longtime, shortdate, shorttime)
            Console.WriteLine(dateLocal.ToLongDateString());
            Console.WriteLine(dateLocal.ToLongTimeString());
            Console.WriteLine(dateLocal.ToShortDateString());
            Console.WriteLine(dateLocal.ToShortTimeString());
            //Создать объекты CultureInfo в таких культурах: ar - Bh, en - US, ru - RU, zh - HANS
             //Привести текущее время к строке в различных форматах для каждой из культурах
            CultureInfo cultureInfo = new CultureInfo("ru-RU");
            string srtRu = dateLocal.ToString(cultureInfo.DateTimeFormat.ShortDatePattern);
            Console.WriteLine(srtRu);

            CultureInfo usFormat = new CultureInfo("en-US");
            string srtUs = dateLocal.ToString(usFormat.DateTimeFormat.ShortTimePattern);
            Console.WriteLine(srtUs);

            CultureInfo arFormat = new CultureInfo("ar-Bh");
            string strAr = dateLocal.ToString(arFormat.DateTimeFormat.LongDatePattern);
            Console.WriteLine(strAr);

            CultureInfo zhFormat = new CultureInfo("zh-HANS");
            string strZh = dateLocal.ToString(zhFormat.DateTimeFormat.LongDatePattern);
            Console.WriteLine(strZh);

            //Распарсить эти строки обратно в DateTime
            DateTime dt1 = DateTime.Parse(srtRu);
            DateTime dt2 = DateTime.Parse(srtUs);
            DateTime dt3 = DateTime.Parse(strAr);
            DateTime dt4 = DateTime.Parse(strZh);
        }
    }
}
