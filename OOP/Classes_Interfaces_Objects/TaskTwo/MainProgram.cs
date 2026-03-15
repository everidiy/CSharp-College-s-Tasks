
using System;
using System.Net.NetworkInformation;
using System.Threading;
using TaskTwo;

namespace TaskOne
{
    internal class MainProgram
    {
        static Device device = new Device
        {
            deviceName = "",
            status = false,
            type = "",
        };

        static void Main()
        {
            Console.Clear();

            Console.WriteLine("\nПриветствую вас на платформе!\n");
            Console.WriteLine("Что вас интересует?\n");
            Console.WriteLine("Подключить устройство - (1)");
            Console.WriteLine("Выход - (2)\n");

            Console.Write("Ваш ответ => ");
            int.TryParse(Console.ReadLine(), out int step);

            switch (step)
            {
                case 1:
                    AddDevice(device);
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void AddDevice(Device className)
        {
            Console.Clear();

            Console.Write("Введите название вашего устройства - ");
            string input = Console.ReadLine();
            Console.WriteLine();

            className.deviceName = input;

            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Какой тип устройства вас интересует? \n");

                Console.WriteLine("Телевизор - (1) ");
                Console.WriteLine("Холодильник - (2) ");
                Console.WriteLine("Наушники - (3) ");
                Console.WriteLine("Чайник - (4) ");
                Console.WriteLine("Колонка - (5) ");
                Console.WriteLine("Выход - (6)\n");

                Console.Write("Ваш ответ => ");
                int.TryParse(Console.ReadLine(), out int step);

                switch (step)
                {
                    case 1:
                        className.type = "TV";
                        DeviceFunc(className);
                        break;
                    case 2:
                        className.type = "Fridge";
                        DeviceFunc(className);
                        break;
                    case 3:
                        className.type = "Headphones";
                        DeviceFunc(className);
                        break;
                    case 4:
                        className.type = "Kettle";
                        DeviceFunc(className);
                        break;
                    case 5:
                        className.type = "Speakers";
                        DeviceFunc(className);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        static void DeviceFunc(Device className)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("Включить устройство?\n");

                Console.WriteLine("Включить/Выключить - (1)");
                Console.WriteLine("Просмотреть данные устройства - (2)\n");

                Console.Write("Ваш ответ => ");
                int step = Convert.ToInt32(Console.ReadLine());

                switch(step)
                {
                    case 1:
                        className.GetOnOff();
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
