using System;
using System.Linq;
using System.Threading;

namespace EvenNumbersFirst_ZerosLast_bySort
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                ConsoleHelper.PrintCentered("Четные вперед - (1)");
                ConsoleHelper.PrintCentered("Нули в конец - (2)");
                ConsoleHelper.PrintCentered("Выход - (3)\n");
                ConsoleHelper.PrintCentered("Выберите то, что вам нужно");

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D1:
                        TakeEvenNumsToStartInArr();
                        break;
                    case ConsoleKey.D2:
                        TakeZeroToLastInArr();
                        break;
                    case ConsoleKey.D3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        ConsoleHelper.PrintCentered("Неверный выбор!");
                        Thread.Sleep(1000);
                        Console.Clear();
                        continue;
                }
            }
        }

        static void TakeEvenNumsToStartInArr()
        {
            Console.Clear();

            int[] arr = GenerateArr(10, 1, 10);

            ConsoleHelper.PrintCentered($"Ваш массив | {PrintArr(arr)}");

            int[] evens = new int[arr.Length];
            int[] odds = new int[arr.Length];

            int e = 0, o = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evens[e++] = arr[i];
                } else
                {
                    odds[o++] = arr[i];
                }
            }

            Array.Sort(evens, 0, e);
            Array.Reverse(evens, 0, e);

            Array.Sort(odds, 0, o);

            int[] result = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < e; i++)
                result[index++] = evens[i];

            for (int i = 0; i < o; i++)
                result[index++] = odds[i];

            ConsoleHelper.PrintCentered($"Измененный массив | {PrintArr(result)}\n");

            ConsoleHelper.PrintCentered("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
        }

        static void TakeZeroToLastInArr()
        {
            Console.Clear();

            int[] arr = GenerateArr(10, 0, 10);

            ConsoleHelper.PrintCentered($"Ваш массив | {PrintArr(arr)}");

            int[] zeros = new int[arr.Length];
            int[] newArr = new int[arr.Length];

            int z = 0, n = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zeros[z++] = arr[i];
                } else
                {
                    newArr[n++] = arr[i];
                }
            }

            Array.Sort(newArr, 0, n);

            int[] result = new int[arr.Length];
            int index = 0;

            for (int i = 0; i < n; i++)
                result[index++] = newArr[i];

            for (int i = 0; i < z; i++)
                result[index++] = zeros[i];

            ConsoleHelper.PrintCentered($"Измененный массив | {PrintArr(result)}\n");

            ConsoleHelper.PrintCentered("Нажмите любую клавишу, чтобы продолжить");
            Console.ReadKey();
        }

        static int[] GenerateArr(int quantity, int from, int to)
        {
            int[] arr = new int[quantity];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(from, to);
            }

            return arr;
        }

        static string PrintArr(int[] arr)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                str += $"{arr[i]} ";
            }

            return str;
        }
    }
}
