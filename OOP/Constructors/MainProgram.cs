using System;
using System.Threading;

namespace Constructor
{
    internal class MainProgram
    {

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                ConsoleHelper.PrintCentered("Только Имя и Фамилия - (1)");
                ConsoleHelper.PrintCentered("Полная информация о ученике - (2)");
                ConsoleHelper.PrintCentered("Выход из программы - (3)\n");
                ConsoleHelper.PrintCentered("Выберите способ создания ученика");

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
                ConsoleHelper.PrintCentered("Вернуться назад, не сохраняя - (5)\n");
                ConsoleHelper.PrintCentered("Выберите способ взаимодействия с учеником");

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

                ConsoleHelper.PrintCentered("Имя ученика - (1)");
                ConsoleHelper.PrintCentered("Фамилия ученика - (2)");
                ConsoleHelper.PrintCentered("Класс ученика - (3)");
                ConsoleHelper.PrintCentered("Средний балл ученика - (4)");
                ConsoleHelper.PrintCentered("Пропуски ученика - (5)");
                ConsoleHelper.PrintCentered("Назад - (6)\n");
                ConsoleHelper.PrintCentered("Выберите то, что вы хотите изменить");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        ChangeDataHelper(pupil, 1);
                        continue;
                    case ConsoleKey.D2:
                        ChangeDataHelper(pupil, 2);
                        continue;
                    case ConsoleKey.D3:
                        ChangeDataHelper(pupil, 3);
                        break;
                    case ConsoleKey.D4:
                        ChangeDataHelper(pupil, 4);
                        continue;
                    case ConsoleKey.D5:
                        ChangeDataHelper(pupil, 5);
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

        static void ChangeDataHelper(Pupil pupil, int num)
        {
            Console.Clear();

            ConsoleHelper.PrintCentered("Изменить данные?");
            ConsoleHelper.PrintCentered("( да - 1 | нет - 2 )");

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.D1)
            {
                switch (num)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Введите новое имя - ");
                        string name = Console.ReadLine();
                        pupil.Name = name;
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Введите новую фамилию - ");
                        string surname = Console.ReadLine();
                        pupil.Surname = surname;
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Введите новый класс - ");
                        int grade = int.Parse(Console.ReadLine());
                        pupil.Grade = grade;
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Введите новое имя - ");
                        double average = double.Parse(Console.ReadLine());
                        pupil.Average = average;
                        break;
                    case 5:
                        Console.Clear();
                        Console.Write("Введите новое имя - ");
                        int passes = int.Parse(Console.ReadLine());
                        pupil.Passes = passes;
                        break;
                }

                Console.Clear();
                ConsoleHelper.PrintCentered("Данные сохранены!");
                Thread.Sleep(1500);
            } else
            {
                ConsoleHelper.PrintCentered("Данные сохранены!");
                Thread.Sleep(1500);
            }
        }
    }
}
