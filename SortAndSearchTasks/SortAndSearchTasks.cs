using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortAndSearchTasks
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine(" Выберите способ (1-3): ");
            Console.WriteLine(" (1) - Линейный поиск ключа");
            Console.WriteLine(" (2) - Бинарный поиск ключа");
            Console.WriteLine(" (3) - Бинарно-Рекурсивный поиск ключа\n");
            Console.WriteLine(" === Домашка ===\n");
            Console.WriteLine(" (4) - Подсчет числа в массиве");
            Console.WriteLine(" (5) - Модификация 2 способа с индексом\n");
            Console.Write(" Способ -> ");
            int step = Convert.ToInt32(Console.ReadLine());

            switch (step)
            {
                case 1:
                    LinearSearch();
                    break;
                case 2:
                    BinarySearch();
                    break;
                case 3:
                    BinarySearchRecursive();
                    break;
                case 4:
                    NumCounterLinear();
                    break;
                case 5:
                    ModifiedBinarySearch();
                    break;
                default:
                    Console.Clear();
                    Console.Write(" Неверный способ! Попробуйте ещё раз :)");
                    Thread.Sleep(1000);
                    Main();
                    break;
            }
        }

        static void LinearSearch()
        {
            Console.Clear();
            Console.Write(" Ваш ключ (1 - 10): ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 4, 6, 7, 2, 9, 10, 8, 3, 5, 1 };

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 9)
                {
                    Console.Clear();
                    Console.Write(" Ваш ключ найден :) -> ");
                    Console.WriteLine(array[i]);
                    break;
                } else
                {
                    Console.WriteLine(" Ваш ключ не найден :( ");
                }
            }
            Thread.Sleep(2000);
            Main();
        }

        static void BinarySearch()
        {
            Console.Clear();
            Console.Write(" Ваш ключ (0 - 20): ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 4, 6, 7, 12, 19, 10, 8, 3, 5, 1, 11, 9, 7, 15, 3, 2, 0, 20, 16 };

            Array.Sort(array);

            int left = 0;
            int right = array.Length - 1;
            bool found = false;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    Console.Clear();
                    Console.Write(" Ваш ключ найден :) -> ");
                    Console.WriteLine(mid);
                    found = true;
                    break;
                } else if (key < array[mid])
                {
                    right = mid - 1;
                } else
                {
                    left = mid + 1;
                }
            }

            if (!found)
            {
                Console.Clear();
                Console.Write(" Ваш ключ не найден :( ");
            }
            
            Thread.Sleep(2000);
            Main();
        }

        static void BinarySearchRecursive()
        {
            Console.Clear();
            Console.Write(" Ваш ключ (0 - 20): ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 4, 6, 7, 12, 19, 10, 8, 3, 5, 1, 11, 9, 7, 15, 3, 2, 0, 20, 16 };

            Array.Sort(array);

            BinarySearchRecursiveHelper(array, key, 0, array.Length - 1);

            Thread.Sleep(2000);
            Main();
        }

        static int BinarySearchRecursiveHelper(int[] array, int key, int left, int right)
        {
            if (left > right)
            {
                Console.WriteLine(" Ваш ключ не найден :( "); 
                return -1;
            }
                
            int mid = left + (right - left) / 2;

            if (array[mid] == key)
            {
                Console.Clear();
                Console.Write(" Ваш ключ найден :) -> ");
                Console.WriteLine(mid);
                return mid;
            }
            else if (key < array[mid])
            {
                return BinarySearchRecursiveHelper(array, key, left, mid - 1);
            }
            else
            {
                return BinarySearchRecursiveHelper(array, key, mid + 1, right);
            }
        }

        static void NumCounterLinear()
        {
            Console.Clear();
            Console.Write(" Ваш ключ (0 - 20): ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 4, 6, 7, 12, 19, 10, 8, 3, 5, 1, 11, 9, 7, 15, 3, 2, 0, 20, 16 };

            int counter = 0;
            string num = ""; 

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]  == key)
                {
                    num = $"{array[i]}";
                    counter++; 
                } 
            }
            Console.Clear();
            Console.WriteLine($" Число {num} встретилось {counter} раз :) ");

            Thread.Sleep(2000);
            Main();
        }

        static void ModifiedBinarySearch()
        {
            Console.Clear();
            Console.Write(" Ваш ключ (0 - 20): ");
            int key = Convert.ToInt32(Console.ReadLine());

            int[] array = { 4, 6, 7, 12, 19, 10, 8, 6, 3, 5, 1, 11, 9, 7, 15, 3, 2, 0, 20, 16, 5, 6, 7, 2 };

            Array.Sort(array);

            int left = 0;
            int right = array.Length - 1;
            bool found = false;
            int result = -1;
            int num = 0;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    num = array[mid];
                    result = mid;
                    right = mid - 1;
                    found = true;
                }
                else if (key < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            if (!found)
            {
                Console.Clear();
                Console.Write(" Ваш ключ не найден :( ");
            } else
            {
                Console.Clear();
                Console.WriteLine(" Отсортированный массив: " + string.Join(", ", array));
                Console.WriteLine();
                Console.Write(" Ваш ключ найден :) -> ");
                Console.WriteLine(num);
                Console.Write(" Его индекс -> ");
                Console.WriteLine(result);
                Console.WriteLine();
            }

                Thread.Sleep(10000);
            Main();
        }
    }
}
