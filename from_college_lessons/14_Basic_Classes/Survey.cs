using System;

namespace _14_Basic_Classes
{
    internal class Survey
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal string Patronymic { get; set; }
        internal DateTime Birthday { get; set; }
        internal int Age { get; set; }
        internal string HomeAddress { get; set; }
        internal string PhoneNumber { get; set; }

        public void GetInfo()
        {
            Console.WriteLine(
                $"ФИО | {Surname} {Name} {Patronymic} \n" +
                $"Дата рождения | {Birthday:dd.MM.yyyy} \n " +
                $"Возраст | {GetAge()} \n" +
                $"Адрес | {HomeAddress}\n" +
                $"Телефон | {PhoneNumber}"
            );
        }

        public int GetAge()
        {
            DateTime today = DateTime.Now;

            int age = today.Year - Birthday.Year;

            if (today < Birthday.AddYears(age))
            {
                age--;
            }

            Age = age;

            return Age;
        }
    }
}
