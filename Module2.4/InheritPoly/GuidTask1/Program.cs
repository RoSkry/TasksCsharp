using System;

namespace GuidTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Работа с Guid
            //Сгенерировать пустой гуид
            Guid empty = Guid.Empty;
            //Сгенерировать новый гуид
            Guid guid = Guid.NewGuid();
            //Привести гуид к строке и записать в переменную типа стринг
            string guidString=Guid.NewGuid().ToString();
            Console.WriteLine(guidString);
            //Изменить строку по свою усмотрению(помнить о формате гуида - 32 символа 0 - F  с дефисами)
            guidString = "F9168C5E-CEB2-4faa-B6BF-329BF39FA1E4";
            //СОздать переменную типа гуид, распарсить строку полученную ранее и записать в созданную переменную.
            Guid parse = Guid.Parse(guidString);
            //Повторить предыдущий пункт через try parse, притом инициализировать переменную в аргументе метода try parse как out параметр, а сам метод Guid.TryParse поместить в if как условие.Если условие выполнено и строка распаршено успешно - вывести гуид на экран с сообщение Parsed successfully, если нет -вывести сообщение "String is not a valid guid"           
            if(Guid.TryParse(guidString,out Guid parse1))
            {
                Console.WriteLine("Parsed successfully");
            }
            else
            {
                Console.WriteLine("String is not a valid guid");
            }

        }
    }
}
