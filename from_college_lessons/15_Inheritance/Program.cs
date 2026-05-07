using System;
using System.Threading;

namespace _15_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                int min;
                Console.Write($"Впишите кол-во минут - ");
                if (!int.TryParse(Console.ReadLine(), out min) || min < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }

                int sec;
                Console.Write($"Впишите доп. кол-во секунд - ");
                if (!int.TryParse(Console.ReadLine(), out sec) || sec < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }

                Time time = new Time(min, sec);

                Console.WriteLine();

                Console.WriteLine($"Ваше кол-во в секундах - {time.TotalSec()} сек.");
                Console.WriteLine();

                double speed;
                Console.Write($"Впишите скорость движения объекта наблюдения - ");
                if (!double.TryParse(Console.ReadLine(), out speed) || speed < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }

                MovingObject movingObject = new MovingObject(speed, min, sec);

                Console.WriteLine();

                Console.WriteLine($"Ваша скорость - {movingObject.Speed} м/с");
                Console.WriteLine($"Ваше время - {movingObject.TotalSec()} сек.");
                Console.WriteLine();

                Console.WriteLine($"Ваше расстояние, пройденное объектом наблюдения - " +
                    $"{movingObject.GetDistance()} м");

                Console.ReadLine();
            }
        }
    }
}
