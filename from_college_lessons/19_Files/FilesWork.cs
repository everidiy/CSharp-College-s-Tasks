using System;
using System.Collections.Generic;
using System.IO;

namespace _19_Files
{
    internal class FilesWork
    {
        public static void CheckAndPrintFile()
        {
            char separator = ';';
            int numerator = 0;
            var tempList = new List<(string Goods, string Quantity)>();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string goods = Path.Combine(baseDirectory, "Example", "goods.txt");

            if (File.Exists(goods))
            {
                try
                {
                    string[] lines = File.ReadAllLines(goods);

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(separator);
                        
                        if (values.Length >= 2)
                        {
                            string tempGoods = values[0].Trim();
                            string tempQuantity = values[1].Trim();

                            tempList.Add((tempGoods, tempQuantity));
                        }
                    }

                    foreach (var item in tempList)
                    {
                        Console.Write($"{numerator += 1}) {item.Goods}: {item.Quantity} шт.\n");
                    }
                    Console.WriteLine();
                }
                catch (IOException) { }
            }
            else
            {
                throw new Exception("Файл не найден!");
            }
        }

        public static void AddNewGoods()
        {
            char separator = ';';
            string line = "";

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string goods = Path.Combine(baseDirectory, "Example", "goods.txt");

                Console.WriteLine("\nСколько товаров сегодня примем? (от 1 до 10)");
                if (!int.TryParse(Console.ReadLine(), out int goodsQuantity) || goodsQuantity <= 0 || goodsQuantity >= 10)
                {
                    Console.WriteLine("Неверное значение! Введите число от 1 до 10");
                    Console.ReadKey();
                }

                if (goodsQuantity > 0 && goodsQuantity <= 10)
                {
                    for (int i = 0; i < goodsQuantity; i++)
                    {
                        string name = "";
                        while (string.IsNullOrWhiteSpace(name))
                        {
                            Console.Write("\nНазвание товара - ");
                            name = Console.ReadLine();
                        }
                        Console.Write("Количество товара - ");
                        string amount = Console.ReadLine();

                        string formattedName = char.ToUpper(name[0]) + name.Substring(1);

                        line = $"{formattedName}{separator}{amount}{Environment.NewLine}";

                        File.AppendAllText(goods, line);
                    }
                }
                else
                {
                    Console.WriteLine("Неверное значение!");
                    Console.ReadKey();
                }
        }

        public static void CheckSmallAmount()
        {
            char separator = ';';
            string lineStock = "";
            int numerator = 0;
            var tempList = new List<(string LowerGoods, string LowerQuantity)>();

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string goods = Path.Combine(baseDirectory, "Example", "goods.txt");
            string stock = Path.Combine(baseDirectory, "LowStock", "lowstock.txt");

            Console.Clear();
            Console.WriteLine("===| МИНИМУМ НА СКЛАДЕ |===\n");
            if (!File.Exists(stock))
            {
                try
                {
                    string[] lines = File.ReadAllLines(goods);

                    foreach (string line in lines)
                    {
                        string[] values = line.Split(separator);

                        if (values.Length >= 2)
                        {
                            string tempGoods = values[0].Trim();
                            string tempQuantity = values[1].Trim();
                            if (int.TryParse(tempQuantity, out int quantity) && quantity < 20)
                            {
                                tempList.Add((tempGoods, tempQuantity));
                            }
                        }
                    }

                    foreach (var item in tempList)
                    {
                        string formattedName = char.ToUpper(item.LowerGoods[0]) + item.LowerGoods.Substring(1);

                        lineStock = $"{formattedName}{separator}{item.LowerQuantity}{Environment.NewLine}";

                        File.AppendAllText(stock, lineStock);
                    }
                }
                catch (IOException) { }
            }
            else
            {
                string[] lines = File.ReadAllLines(stock);
                foreach (string line in lines)
                {
                    string[] values = line.Split(separator);

                    if (values.Length >= 2)
                    {
                        string tempGoods = values[0].Trim();
                        string tempQuantity = values[1].Trim();

                        tempList.Add((tempGoods, tempQuantity));
                    }
                }

                foreach (var item in tempList)
                {
                    Console.Write($"{numerator += 1}) {item.LowerGoods}: {item.LowerQuantity} шт.\n");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Нажмите клавишу, чтобы продолжить..");
            Console.ReadKey();
        }
    }
}
