using System;
using System.Threading;

namespace TaskTwoProperties
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Задайте радиус вашему кругу: ");
            double.TryParse(Console.ReadLine(), out double rds);

            Circle circle = new Circle(rds);

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Площадь круга - (1)");
                Console.WriteLine("Длина окружности - (2)");
                Console.WriteLine("Выход - (3)\n");

                Console.WriteLine("Какая функция вас интересует?");
                int.TryParse(Console.ReadLine(), out int func);

                switch (func)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"Площадь вашего круга с радиусом - {circle.Radius} = {circle.Area}");
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню..");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"Длина окружности вашего круга с радиусом - {circle.Radius} = {circle.CircleLength}");
                        Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в меню..");
                        Console.ReadKey();
                        break;
                    case 3:
                        exit = true; 
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор!");
                        Thread.Sleep(1000);
                        break;
                }
            }
        }
    }
}
