using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RectangleApp
{
    class Program
    {
        static List<Rectangle> collection = new List<Rectangle>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Разработал: Давыдов Богдан Максимович \nСтудент группы: 106-Д9-2ИСП \nДата (22.05.2026) \nПрактическая работа №17");
                Console.WriteLine("Работа с коллекциями\n");

                Console.WriteLine("1. Добавить прямоугольник (Родитель)");
                Console.WriteLine("2. Добавить прямоугольник с кругом (Потомок)");
                Console.WriteLine("3. Удалить объект по индексу");
                Console.WriteLine("4. Показать отсортированную коллекцию (по площади)");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1": AddRectangle(); break;
                        case "2": AddRectangleWithCircle(); break;
                        case "3": RemoveItem(); break;
                        case "4": ShowSorted(); break;
                        case "0": return;
                        default: Console.WriteLine("Неверный ввод."); break;
                    }
                }
                catch (Exception ex) { Console.WriteLine($"Ошибка: {ex.Message}"); }
                Thread.Sleep(1000);
            }
        }

        static void AddRectangle()
        {
            Console.Write("Введите x1, y1, x2, y2 через пробел: ");
            var p = Console.ReadLine().Split().Select(double.Parse).ToArray();
            collection.Add(new Rectangle(p[0], p[1], p[2], p[3]));
            Console.WriteLine("Объект добавлен.");
            Thread.Sleep(1000);
        }

        static void AddRectangleWithCircle()
        {
            Console.Write("Введите x1, y1, x2, y2 и Радиус R через пробел: ");
            var p = Console.ReadLine().Split().Select(double.Parse).ToArray();
            collection.Add(new RectangleWithCircle(p[0], p[1], p[2], p[3], p[4]));
            Console.WriteLine("Объект добавлен.");
            Thread.Sleep(1000);
        }

        static void RemoveItem()
        {
            ShowSorted();
            Console.Write("Введите индекс для удаления: ");
            int index = int.Parse(Console.ReadLine());
            collection.RemoveAt(index);
            Console.WriteLine("Удалено.");
            Thread.Sleep(1000);
        }

        static void ShowSorted()
        {
            if (collection.Count == 0) { Console.WriteLine("Коллекция пуста."); return; }

            var sorted = collection.OrderBy(x => x.GetArea()).ToList();
            Console.WriteLine("\nСписок объектов (отсортирован по S):");
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine($"[{i}] {sorted[i]}");
            }
            Console.ReadLine();
        }
    }
}
