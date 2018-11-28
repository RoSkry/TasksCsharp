using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqQueries
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Получить число мужчин в коллекции; число женщин

            Person[] people = DataSet.People;
            
            int menCount = people.Where(p => p.Gender == Gender.Man).Count();
            int womenCount = people.Where(p => p.Gender == Gender.Woman).Count();
            Console.WriteLine($"Men:{menCount}\nWomen: {womenCount}");
            //2) Отсортировать персонажей по фамилии потом по имени, выбрать их описание в формате $"{Name} {SurName}, age {Age} lives in {City}, {Country}. He (или she, решить тернарным опертором) is {Occupation} and makes {AnnualIncome} a year. {Family status to string}, speaks {Languages Count} languages
            var sort = people.OrderBy(p=>p.SurName).ThenBy(p=>p.Name).Select(p => $"{p.Name} {p.SurName}, age {p.Age} lives in {p.HomeAddress.City}, {p.HomeAddress.City.Country}. {((p.Gender==Gender.Man)?"He":"She")} is {p.Occupation} and makes {p.AnnualIncome} a year. {p.FamilyStatus}, speaks {p.Languages.Count()} languages");
            //3)Найти тех, кто живет в странах с  насилением больше 80 миллионов
            var inBigCities = people.Where(t => t.HomeAddress.City.Country.Population > 80000000).Select(p => $"{p.Name} {p.SurName} lives in {p.HomeAddress.City.Country.Name} with population {p.HomeAddress.City.Country.Population}");
            //4) Найти средний доход в группе персонажей(return decimal Average()) с высшим образованием(выше HECert - аналого нашего двухгодичного "младшего специалиста")
            var a = people.Where(p => p.EducationLevel > EducationLevel.HECert).Select(p=>p.AnnualIncome).Average();
            //5) Найти тех, чей годовой доход превышает годовой доход в их стране
            var b = people.Where(p => p.AnnualIncome > p.HomeAddress.City.Country.AvgIncome).Select(p => $"{p.Name} {p.SurName}, annual income  {p.AnnualIncome} avg in the country {p.HomeAddress.City.Country.AvgIncome}");
            //6) Найти максимальное число языков, которым владеет персонаж(return int Max()
            var c = people.Select(p => p.Languages.Count()).Max();                 
            //7) Найти виртуозного полиглота(для которого число языков равняется числу из п.6)
            var naxLan = people.Where(p => p.Languages.Count() == c).Select(p => $"{p.Name} {p.SurName}");
            //8) Найти персонажа, который не владеет языком страны, в которой он проживает.Если такого нет - вернуть null
            var n = people.FirstOrDefault(p => !p.Languages.Select(l=>l.Id).Contains(p.HomeAddress.City.Country.Language.Id));
            //9) Найти людей, проживающих в Германии, упорядочить по возрасту от большего до меньшего, выбрать в формате $"{Name} {Surname} {Age} {City}"
            var k = people.OrderByDescending(f => f.Age).Where(p => p.HomeAddress.City.Country.Name == "Germany").Select(r=>$"{r.Name} {r.SurName} {r.Age} {r.HomeAddress.City}");
            //10)Найти процентную долю тех, кто состоит в браке от общего числа персонажей
            int marriedPersons = people.Count(p=>p.FamilyStatus== FamilyStatus.Married);
            int totalAmount = people.Count();
            double procent = ((double)marriedPersons / totalAmount) * 100;
            //11) Найти тех, кто владеет двумя и более языками но получает зарплату ниже средней по их стране
            var c1 = people.Where(p => p.Languages.Count() >= 2 && p.AnnualIncome < p.HomeAddress.City.Country.AvgIncome);
            //12) Найти единственного кандидата наук, если такого нет либо если выборка больше 1 - вернуть ошибку
            var singlePerson = people.Single(p => p.EducationLevel == EducationLevel.PhD);
            //13) Найти людей из испаноговорящих стран, вернуть в формате $"{Name} {Occupation} {City} {Country}"
            var spainPeople = people.Where(p => p.HomeAddress.City.Country.Language.Name == "Spanish").Select(p=>$"{p.Name} {p.Occupation} {p.HomeAddress.City.Name} {p.HomeAddress.City.Country.Name}");
            //14) Найти персонажа, который живет в городе с наименьшим населением(относительно места проживания других персонажей)
            var MinCity = people.FirstOrDefault(p => p.HomeAddress.City.Population == people.Select(r => r.HomeAddress.City.Population).Min());
            //15) Найти персонажа, который живет в городе с наименьшим абсолютным населением(город с наименьшим населением в списке городов), если такого нет - вернуть налл
            var smallestCity = DataSet.Cities.Min(p=>p.Value.Population);
            var s2= people.FirstOrDefault(p => p.HomeAddress.City.Population == smallestCity);
            //17) Определить, какая доля людей, владеющих английским, проживает не в англоговорящих странах по отношению ко всем людям из списка, которые владеют английским
           
           
            //var TotalEnglishAmount = people.Select(l=>l.Languages.FirstOrDefault(r=>r.Name=="English")).Where(p => p != null).Count();

            var rt = people.Where(p => p.Languages.Any(r => r.Name == "English")).Count();
            var rt1 = people.Where(p => p.Languages.Any(r => r.Name == "English")&&p.HomeAddress.City.Country.Language.Name!= "English").Count();

            var procent1 = (double)rt1 / rt * 100;
            //18) Найти самого богатого персонажа
            var richest = people.FirstOrDefault(p => p.AnnualIncome == people.Max(r => r.AnnualIncome));
            //19) Найти персонажа с наименьшим доходом в Британии
           // var porestSalaryinBritain = people.Where(p => p.HomeAddress.City.Country.Name == "United Kingdon").Min(r=>r.AnnualIncome);

            var poorestMan = people.FirstOrDefault(f=>f.AnnualIncome== people.Where(p => p.HomeAddress.City.Country.Name == "United Kingdon").Min(r => r.AnnualIncome));
            //20) Отсортировать персонажей по доходу по нисходящей, потом по имени и по фамилии по восходящей
            var sorted = people.OrderByDescending(p => p.AnnualIncome).ThenBy(p=>p.Name).ThenBy(r=>r.SurName).Select(r => $"{r.AnnualIncome}    {r.Name} {r.SurName} ");

        }
    }
}
