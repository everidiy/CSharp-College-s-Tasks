using System;

namespace _19_Files
{
    internal class Program
    {

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("===| СЕЙЧАС НА СКЛАДЕ |===\n");

                FilesWork.CheckAndPrintFile();

                Console.WriteLine("Желаете ли вы загрузить новые товары? (1 - да / 0 - нет / 2 - проверить остаток)");
                int.TryParse(Console.ReadLine(), out int answer);

                switch (answer)
                {
                    case 1:
                        FilesWork.AddNewGoods();
                        continue;
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 2:
                        FilesWork.CheckSmallAmount();
                        break;
                    default:
                        Console.WriteLine("Ошибочный вариант!");
                        continue;
                }
            }

        }
    }
}
