using _20_File_Access_XML.Classes;
using System;

namespace _20_File_Access_XML
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("\n1. Просмотреть список");
                Console.WriteLine("2. Стереть список");
                Console.WriteLine("3. Создать список");
                Console.WriteLine("0. Выход\n");

                Console.Write("Ваш выбор - ");

                if(!int.TryParse(Console.ReadLine(), out int num))
                {
                    SendError("Неверный ввод!");
                    continue;
                }

                switch (num)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        ListUtils.ViewList();
                        continue;
                    case 2:
                        ListUtils.DeleteList();
                        continue;
                    case 3:
                        ListUtils.CreateList();
                        continue;
                    default:
                        SendError("Неверный выбор!");
                        continue;
                }
            }
        }

        private static void SendError(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
            Console.ReadKey();
        }
    }
}
