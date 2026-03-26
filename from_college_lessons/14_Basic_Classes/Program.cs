using System;

namespace _14_Basic_Classes
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Работу выполнил: Давыдов Богдан Максимович \nСтудент группы: 106-Д9-2ИСП \nДата: 26.03.2026 \nПрактическая работа №14 \nЗадача: Создание простейших классов\n");
        
            Survey survey = Survey();
            Console.Clear();
            survey.GetInfo();
        }

        static Survey Survey()
        {
            Console.Clear();

            Survey survey = new Survey()
            {
                Surname = ConsoleHelper.ReadString("Введите фамилию - "),
                Name = ConsoleHelper.ReadString("Введите имя - "),
                Patronymic = ConsoleHelper.ReadString("Введите отчество - "),
                Birthday = ConsoleHelper.ReadBirthday("Введите дату рождения (01.01.0001) - "),
                HomeAddress = ConsoleHelper.ReadAddress("Введите адрес проживания - "),
                PhoneNumber = ConsoleHelper.ReadPhoneNumber("Введите телефон (+7 (777) 777-77-77) - "),
            };

            return survey;
        }
    }
}
