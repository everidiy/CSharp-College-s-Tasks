using System;
using System.Net.NetworkInformation;
using System.Threading;

namespace TaskOne
{
    internal class MainProgram
    {
        static Delivery delivery = new Delivery
        {
            isAccepted = false,
        };

        static void Main()
        {
            Console.Clear();

            Console.WriteLine("\nПриветствую вас на платформе!\n");
            Console.WriteLine("Какая доставка вас интересует?\n");
            Console.WriteLine("Обычная доставка - (1)");
            Console.WriteLine("Экспресс доставка - (2)\n");

            Console.Write("Ваш ответ => ");
            int step = Convert.ToInt32(Console.ReadLine());

            switch (step)
            {
                case 1:
                    Delivery(100, "Обычная");
                    break;
                case 2:
                    Delivery(250, "Экспресс");
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void Delivery(int price, string name)
        {
            delivery.cost = price;
            delivery.type = name;

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Что вас интересует? \n");

                Console.WriteLine("Сделать / отменить доставку - (1) ");
                Console.WriteLine("Узнать статус доставки - (2) ");
                Console.WriteLine("Узнать стоимость доставки - (3) ");
                Console.WriteLine("Назад - (4)\n");

                int step = Convert.ToInt32(Console.ReadLine());

                switch (step)
                {
                    case 1:
                        delivery.GetDelivery();
                        Thread.Sleep(500);
                        Console.WriteLine("\nЖдите\n");
                        Thread.Sleep(2000);
                        Delivery(delivery.cost, delivery.type);
                        break;
                    case 2:
                        delivery.GetInfo();
                        Thread.Sleep(500);
                        Console.WriteLine("\nЖдите\n");
                        Thread.Sleep(2000);
                        Delivery(delivery.cost, delivery.type);
                        break;
                    case 3:
                        delivery.CountCost(delivery.cost);
                        Thread.Sleep(500);
                        Console.WriteLine("\nЖдите\n");
                        Thread.Sleep(2000);
                        Delivery(delivery.cost, delivery.type);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }
    }
}
