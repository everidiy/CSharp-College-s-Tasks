using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TaskThree
{
    internal class Reservation
    {
        private static readonly Random rnd = new Random();

        internal string name;
        internal bool status;
        internal string type;
        internal string date;

        public void GetCancelBooking()
        {
            Console.Clear();

            if (status)
            {
                status = false;
                Console.WriteLine("Ваша бронь была отклонена! ");
            } else
            {
                Console.WriteLine("Выберите интересующую вас дату: \n");

                string firstDate = GetDate();
                string secondDate = GetDate();
                string thirdDate = GetDate();

                Console.WriteLine($"{firstDate} - (1) ");
                Console.WriteLine($"{secondDate} - (2) ");
                Console.WriteLine($"{thirdDate} - (3) \n");

                Console.Write("Ваш ответ => ");
                int.TryParse(Console.ReadLine(), out int step);
                
                switch (step)
                {
                    case 1:
                        status = true;
                        date = firstDate;
                        Console.WriteLine("\nВаша бронь была выполнена! ");
                        break;
                    case 2:
                        status = true;
                        date = secondDate;
                        Console.WriteLine("\nВаша бронь была выполнена! ");
                        break;
                    case 3:
                        status = true;
                        date = thirdDate;
                        Console.WriteLine("\nВаша бронь была выполнена! ");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        public string GetDate()
        {

            int month = rnd.Next(1, 13);
            int day = 0;

            if (month == 2)
            {
                day = rnd.Next(1, 29);
            }
            else
            {
                day = rnd.Next(1, 32);
            }

            int year = 2026;

            string fullDate = $"{day:D2}.{month:D2}.{year}";

            return fullDate;
        }

        public void GetInfo()
        {
            string isActive = status ? "Забронировано" : "Не забронировано";
            string isHotel = type.ToString().ToLower() == "отель" ? "отеля" : "рейса";

            Console.Clear();

            Console.WriteLine($"\nВаше бронирование - {type}: {name}");
            Console.WriteLine($"Название {isHotel} - {name}");
            Console.WriteLine($"Тип брони - {type}");
            Console.WriteLine($"Статус бронирования - {isActive}");
            Console.WriteLine($"Запланировано на - {date}\n");
        }
    }
}
