using System;
using System.Collections.Generic;
using System.Threading;

namespace Constructor
{
    internal class MainProgram
    {
        static List<Pupil> list = new List<Pupil> ();

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                ConsoleHelper.PrintCentered("Вести только имя и фамилию ученика - (1)");
                ConsoleHelper.PrintCentered("Вести полную информацию об ученике - (2)");
                ConsoleHelper.PrintCentered("Выход из программы - (3)\n");
                ConsoleHelper.PrintCentered("Выберите способ создания ученика, нажав клавишу на клавиатуре!\n");

                if (list.Count != 0)
                {
                    Console.WriteLine();
                    ConsoleHelper.PrintCentered("Список учеников:\n");
                    ConsoleHelper.PrintCentered("Имя | Фамилия | Класс (1-11) | Средний балл (2-5) | Пропуски (0-15)\n");
                    
                    for (int i = 0; i < list.Count; i++)
                    {
                        ConsoleHelper.PrintCenteredColored(list[i].Name, list[i].Surname, list[i].Grade, list[i].Average, list[i].Passes);
                    }
                    Console.WriteLine();
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        TakeSomeData(MakePupilByNameNSurname());
                        break;
                    case ConsoleKey.D2:
                        TakeSomeData(MakePupil());
                        break;
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        ConsoleHelper.PrintCentered("Неверный способ!");
                        Thread.Sleep(1000);
                        continue;
                }
            }

        }

        static Pupil MakePupilByNameNSurname()
        {
            Console.Clear();
            Pupil pupil = new Pupil
            {
                Name = ConsoleHelper.ReadString("Введите имя: "),
                Surname = ConsoleHelper.ReadString("Введите фамилию: "),
            };

            Console.Clear();
            pupil.GetInfo();
            Thread.Sleep(3000);

            return pupil;
        }

        static Pupil MakePupil()
        {
            Console.Clear();
            Pupil pupil = new Pupil
            {
                Name = ConsoleHelper.ReadString("Введите имя: "),
                Surname = ConsoleHelper.ReadString("Введите фамилию: "),
                Grade = ConsoleHelper.ReadInt("Введите класс (1-11): ", 1, 11),
                Average = ConsoleHelper.ReadDouble("Введите средний балл (2-5): ", 2.0, 5.0),
                Passes = ConsoleHelper.ReadInt("Введите пропуски (>=0): ", 0, 50),
            };

            Console.Clear();
            pupil.GetInfo();
            Thread.Sleep(3000);

            return pupil;
        }

        static void TakeSomeData(Pupil pupil)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                ConsoleHelper.PrintCentered("Просмотреть информацию об ученике - (1)");
                ConsoleHelper.PrintCentered("Изменить данные - (2)");
                ConsoleHelper.PrintCentered("Выполнить обработку данных - (3)");
                ConsoleHelper.PrintCentered("Проверить порог по пропускам - (4)");
                ConsoleHelper.PrintCentered("Вернуться назад, НЕ сохраняя данные - (5)");
                ConsoleHelper.PrintCentered("Вернуться назад, СОХРАНЯЯ данные - (6)\n");
                ConsoleHelper.PrintCentered("Выберите способ взаимодействия с учеником, нажав клавишу на клавиатуре!");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        pupil.GetFullInfo();
                        continue;
                    case ConsoleKey.D2:
                        ChangeData(pupil);
                        continue;
                    case ConsoleKey.D3:
                        pupil.CheckStatus();
                        break;
                    case ConsoleKey.D4:
                        pupil.CheckPasses();
                        continue;
                    case ConsoleKey.D5:
                        exit = true;
                        break;
                    case ConsoleKey.D6:
                        list.Add(pupil);
                        exit = true;
                        break;
                    default:
                        Console.WriteLine();
                        ConsoleHelper.PrintCentered("Неверный способ!");
                        Thread.Sleep(1000);
                        continue;
                }
            }
        }

        static void ChangeData(Pupil pupil)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                ConsoleHelper.PrintCentered($"Имя - {pupil.Name}");
                ConsoleHelper.PrintCentered($"Фамилия - {pupil.Surname}");
                ConsoleHelper.PrintCentered($"Класс - {pupil.Grade}");
                ConsoleHelper.PrintCentered($"Средний балл - {pupil.Average}");
                ConsoleHelper.PrintCentered($"Пропуски - {pupil.Passes}\n");

                ConsoleHelper.PrintCentered("Имя ученика - (1)");
                ConsoleHelper.PrintCentered("Фамилия ученика - (2)");
                ConsoleHelper.PrintCentered("Класс ученика - (3)");
                ConsoleHelper.PrintCentered("Средний балл ученика - (4)");
                ConsoleHelper.PrintCentered("Пропуски ученика - (5)");
                ConsoleHelper.PrintCentered("Назад - (6)\n");
                ConsoleHelper.PrintCentered("Выберите то, что вы хотите изменить, нажав клавишу на клавиатуре!");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        ChangeDataHelper(pupil, 1, "Имя");
                        continue;
                    case ConsoleKey.D2:
                        ChangeDataHelper(pupil, 2, "Фамилия");
                        continue;
                    case ConsoleKey.D3:
                        ChangeDataHelper(pupil, 3, "Класс ученика");
                        break;
                    case ConsoleKey.D4:
                        ChangeDataHelper(pupil, 4, "Средний балл ученика");
                        continue;
                    case ConsoleKey.D5:
                        ChangeDataHelper(pupil, 5, "Пропуски ученика");
                        break;
                    case ConsoleKey.D6:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine();
                        ConsoleHelper.PrintCentered("Неверный способ!");
                        Thread.Sleep(1000);
                        continue;
                }
            }
        }

        static void ChangeDataHelper(Pupil pupil, int num, string nameData)
        {
            Console.Clear();

            ConsoleHelper.PrintCentered($"Изменить данные - {nameData}?");
            ConsoleHelper.PrintCentered("Нажмите | да - 1 | нет - 2");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.D1)
            {
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        pupil.Name = ConsoleHelper.ReadString("Введите новое имя: "); ;
                        break;
                    case 2:
                        Console.Clear();
                        pupil.Surname = ConsoleHelper.ReadString("Введите новую фамилию: ");
                        break;
                    case 3:
                        Console.Clear();
                        pupil.Grade = ConsoleHelper.ReadInt("Введите новый класс (1-11): ", 1, 11);
                        break;
                    case 4:
                        Console.Clear();
                        pupil.Average = ConsoleHelper.ReadDouble("Введите новый средний балл (2-5): ", 2.0, 5.0);
                        break;
                    case 5:
                        Console.Clear();
                        pupil.Passes = ConsoleHelper.ReadInt("Введите новое значение пропусков (>=0): ", 0, 50);
                        break;
                }

                Console.Clear();
                ConsoleHelper.PrintCentered("Данные сохранены! Подождите!");
                Thread.Sleep(1500);
            }
            else
            {
                Console.Clear();
                ConsoleHelper.PrintCentered("Данные не были тронуты! Подождите!");
                Thread.Sleep(1500);
            }
        }
    }
}
