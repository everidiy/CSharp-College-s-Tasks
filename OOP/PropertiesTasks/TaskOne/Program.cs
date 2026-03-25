using System;
using System.Collections.Generic;
using System.Threading;

namespace TaskOneProperties
{
    internal class Program
    {
        static List<Human> list = new List<Human>();    

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Хотите ли вы увидеть информацию о людях? (да/нет)");
                string answer = Console.ReadLine().ToLower();

                if (answer == "да")
                {
                    GetData();
                    break;
                }
                else if (answer == "нет")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неправильный выбор!");
                    Thread.Sleep(1000);
                }
            }
        }

        static void GetData()
        {
            Console.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {list[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Добавить нового человека - (1)");
            Console.WriteLine("Выход - (2)\n");

            Console.Write("Ваш выбор => ");
            int.TryParse(Console.ReadLine(), out int value);

            switch (value)
            {
                case 1:
                    AddNewPerson();
                    Console.Write("\nНажмите любую кнопку, чтобы вернуться обратно :) ");
                    Console.ReadKey();
                    GetData();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Неправильный выбор!");
                    Thread.Sleep(1000);
                    GetData();
                    break;
            }
        }
        
        static void AddNewPerson()
        {
            Console.Clear();

            string nameInput = ConsoleHelper.ReadString("Введите имя: ");
            Console.WriteLine();

            int ageInpit = ConsoleHelper.ReadInt("Введите возраст: ", 1, 100);
            Console.WriteLine();

            Human person = new Human
            {
                Name = nameInput,
                Age = ageInpit
            };

            list.Add(person);

            person.GetHumanInfo();
        }
    }
}
