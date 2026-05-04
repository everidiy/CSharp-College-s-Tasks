using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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

                Time time = new Time();
                MovingObject @object = new MovingObject();

                int min;
                Console.Write($"Впишите кол-во минут - ");
                if (!int.TryParse(Console.ReadLine(), out min) || time.Minutes < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }
                time.Minutes = min;

                int sec;
                Console.Write($"Впишите доп. кол-во секунд - ");
                if (!int.TryParse(Console.ReadLine(), out sec) || time.Seconds < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }
                time.Seconds = sec;
                Console.WriteLine();

                Console.WriteLine($"Ваше кол-во в секундах - {time.TotalSec()} сек.");
                Console.WriteLine();

                double speed;
                Console.Write($"Впишите скорость движения объекта наблюдения - ");
                if (!double.TryParse(Console.ReadLine(), out speed) || @object.Speed < 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                    Thread.Sleep(1000);
                    continue;
                }
                @object.Speed = speed;

                @object.Time = time.TotalSec();
                Console.WriteLine();

                Console.WriteLine($"Ваша скорость - {@object.Speed} м/с");
                Console.WriteLine($"Ваше время - {@object.Time} сек.");
                Console.WriteLine();

                Console.WriteLine($"Ваше расстояние, пройденное объектом наблюдения - " +
                    $"{@object.GetDistance()} м");

                Console.ReadLine();
            }
        }
    }
}
