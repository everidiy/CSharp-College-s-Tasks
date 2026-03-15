
using System;
using TaskThree;

namespace TaskOne
{
    internal class MainProgram
    {
        static Reservation reservation = new Reservation
        {
            name = "",
            status = false,
            type = "",
        };

        static void Main()
        {
            Console.Clear();

            Console.WriteLine("\nПриветствую вас на платформе!\n");
            Console.WriteLine("Что вас интересует?\n");
            Console.WriteLine("Сделать бронь - (1)");
            Console.WriteLine("Выход - (2)\n");

            Console.Write("Ваш ответ => ");
            int.TryParse(Console.ReadLine(), out int step);

            switch (step)
            {
                case 1:
                    AddBooking(reservation);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void AddBooking(Reservation className)
        {
            Console.Clear();

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Что вы хотите забронировать? \n");

                Console.WriteLine("Рейс - (1) ");
                Console.WriteLine("Отель - (2) ");
                Console.WriteLine("Выход - (3)\n");

                Console.Write("Ваш ответ => ");
                int.TryParse(Console.ReadLine(), out int step);

                switch (step)
                {
                    case 1:
                        className.type = "Рейс";

                        Console.Clear();

                        Console.Write("Введите название рейса - ");
                        string ticket = Console.ReadLine();

                        className.name = ticket;

                        ReservationFunc(className);
                        break;
                    case 2:
                        className.type = "Отель";

                        Console.Clear();

                        Console.Write("Введите название отеля - ");
                        string hotel = Console.ReadLine();

                        className.name = hotel;

                        ReservationFunc(className);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void ReservationFunc(Reservation className)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Что вас интересует?\n");

                Console.WriteLine("Забронировать/Убрать бронь - (1)");
                Console.WriteLine("Просмотреть данные брони - (2)\n");

                Console.Write("Ваш ответ => ");
                int step = Convert.ToInt32(Console.ReadLine());

                switch (step)
                {
                    case 1:
                        className.GetCancelBooking();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы выйти");
                        Console.ReadKey();
                        break;
                    case 2:
                        className.GetInfo();
                        Console.WriteLine("\nНажмите любую клавишу, чтобы выйти");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}
