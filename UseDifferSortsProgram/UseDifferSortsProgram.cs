using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSorts
{
    internal class Program
    {
        private static Random rnd = new Random();
        internal static int[] arrMain = null;
        internal static string arrayLine = "";

        static bool[] usedSorts = new bool[8];

        static string GetSortName(int i)
        {
            switch (i)
            {
                case 1:
                    return "BubbleSort";
                case 2:
                    return "ShakeSort";
                case 3:
                    return "CombSort";
                case 4:
                    return "InsertionSort";
                case 5:
                    return "SelectionSort";
                case 6:
                    return "QuickSort";
                case 7:
                    return "MergeSort";
                default:
                    return "";
            }
        }

        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                PrintCentered($"Your arr is: {arrayLine}\n");

                for (int i = 1; i <= 7; i++)
                {
                    if (usedSorts[i])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        PrintCentered($"{GetSortName(i)} - ({i}) [USED]");
                        Console.ResetColor();
                    } else
                    {
                        PrintCentered($"{GetSortName(i)} - ({i})");
                    }
                }

                Console.WriteLine();
                PrintCentered("Delete your data - (0)\n");

                PrintCentered("Choose the sort you are interested in by your keyboard's buttons ");
                int step = 0;
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                switch (keyInfo.Key)
                {
                    case ConsoleKey.D0:
                        step = 0;
                        break;
                    case ConsoleKey.D1:
                        step = 1;
                        break;
                    case ConsoleKey.D2:
                        step = 2;
                        break;
                    case ConsoleKey.D3:
                        step = 3;
                        break;
                    case ConsoleKey.D4:
                        step = 4;
                        break;
                    case ConsoleKey.D5:
                        step = 5;
                        break;
                    case ConsoleKey.D6:
                        step = 6;
                        break;
                    case ConsoleKey.D7:
                        step = 7;
                        break;
                    default:
                        Console.WriteLine();
                        PrintCentered("Invalid input");
                        Console.ReadKey();
                        continue;
                }

                if (step == 0)
                {
                    if (arrMain != null)
                    {
                        arrMain = null;
                        arrayLine = "";
                        usedSorts = new bool[8];

                        Console.WriteLine();
                        PrintCentered("Data has been reset!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                        PrintCentered("Data has already been reset!");
                        Console.ReadKey();
                    }

                    continue;
                }

                if (arrMain == null || arrayLine == "")
                {
                    GenerateArrMenu();
                }

                if (step >= 1 && step <= 7 && usedSorts[step])
                {
                    Console.WriteLine();
                    PrintCentered("This sort has already been used!");
                    Console.ReadKey();
                    continue;
                }

                switch (step)
                {
                    case 1:
                        ShowSort(BubbleSort);
                        usedSorts[step] = true;
                        break;
                    case 2:
                        ShowSort(ShakeSort);
                        usedSorts[step] = true;
                        break;
                    case 3:
                        ShowSort(CombSort);
                        usedSorts[step] = true;
                        break;
                    case 4:
                        ShowSort(InsertionSort);
                        usedSorts[step] = true;
                        break;
                    case 5:
                        ShowSort(SelectionSort);
                        usedSorts[step] = true;
                        break;
                    case 6:
                        ShowSort(QuickSort);
                        usedSorts[step] = true;
                        break;
                    case 7:
                        ShowSort(MergeSort);
                        usedSorts[step] = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong answer");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowSort(Func<int[], string> sortFunc)
        {
            Console.Clear();

            int[] temp = (int[])arrMain.Clone();
            string newArr = sortFunc(temp);

            PrintCentered("Old array:");
            PrintCentered($"{arrayLine}\n");

            PrintCentered("New array:");
            PrintCentered($"{newArr}");

            Console.ReadKey();
        }

        static void PrintCentered(string text) // Размещение текста по центру
        {
            int leftPadding = (Console.WindowWidth - text.Length) / 2;

            if (leftPadding < 0)
                leftPadding = 0;

            Console.WriteLine(new string(' ', leftPadding) + text);
        }

        static void GenerateArrMenu() //Меню генерация массивов
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();

                PrintCentered("GenerateArr - (1)");
                PrintCentered("Use ready-made - (2)\n");

                Console.Write("Generate an array or use ready-made ones - ");
                int.TryParse(Console.ReadLine(), out var step);

                switch (step)
                {
                    case 1:
                        GenerateArr();
                        exit = true;
                        break;
                    case 2:
                        UseReadyMadeArrs();
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong answer");
                        Console.ReadKey();
                        break;

                }
            }
        }

        static void GenerateArr() //Генерация массивов
        {
            Console.Clear();

            arrMain = new int[20];
            arrayLine = "";

            PrintCentered("The array has been generated:");
            Console.WriteLine();

            for (int i = 0; i < arrMain.Length; i++)
            {
                arrMain[i] = rnd.Next(-50, 50);
                arrayLine += $"{arrMain[i]} ";
            }

            PrintCentered(arrayLine);
            Console.ReadKey();
        }

        static void UseReadyMadeArrs()
        {
            bool exit = false;
            if (arrayLine != "")
                exit = true;

            string firstLine = "";
            string secondLine = "";
            string thirdLine = "";

            int[] arr1 = new int[20];
            int[] arr2 = new int[20];
            int[] arr3 = new int[20];

            firstLine = BuildArr(arr1);
            secondLine = BuildArr(arr2);
            thirdLine = BuildArr(arr3);

            while (!exit)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Green;
                string str = "If you already have an array created and you select this group again, it will use the previously created array!";
                PrintCentered($"{str.ToUpper()}\n");
                Console.ResetColor();

                PrintCentered("Choose your favoutite\n");
                PrintCentered($"(1) - {firstLine}");
                PrintCentered($"(2) - {secondLine}");
                PrintCentered($"(3) - {thirdLine}\n");

                int.TryParse(Console.ReadLine(), out var step);

                switch (step)
                {
                    case 1:
                        arrayLine = firstLine;
                        arrMain = arr1;
                        exit = true;
                        break;
                    case 2:
                        arrayLine = secondLine;
                        arrMain = arr2;
                        exit = true;
                        break;
                    case 3:
                        arrayLine = thirdLine;
                        arrMain = arr3;
                        exit = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong answer");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static string BuildArr(int[] arr)
        {
            string str = "";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 50);
                str += $"{arr[i]} ";
            }

            return str;
        }

        static string BubbleSort(int[] arr) //Сортировка пузырьком
        {
            int temp; 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j  < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return string.Join(" ", arr);
        }

        static string ShakeSort(int[] arr) //Сортировка перемешиванием
        {
            int left = 0;
            int right = arr.Length - 1;
            int temp;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                    }
                } 
                left++;
            }

            return string.Join(" ", arr);
        }

        static string CombSort(int[] arr) //Сортировка расческой
        {
            const double factor = 1.247;
            double step = arr.Length - 1;

            while (step >= 1)
            {
                for (int i = 0; i + step < arr.Length; i++)
                {
                    if (arr[i] > arr[i + (int)step])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + (int)step];
                        arr[i + (int)step] = temp;
                    }
                }
                step /= factor;
                for (int i = 0; i + 1 < arr.Length; i++)
                {
                    for (int j = 0; j + 1 < arr.Length - i; j++)
                    {
                        if (arr[j + 1] < arr[j])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            
            return string.Join(" ", arr);
        }

        static string InsertionSort(int[] arr) //Сортировка вставками
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int x = arr[i];
                int j = i;

                while (j > 0 && arr[j - 1] > x)
                {
                    arr[j] = arr[j - 1];
                    j--; 
                }
                arr[j] = x;
            }

            return string.Join(" ", arr);
        }

        static string SelectionSort(int[] arr) //Сортировка выбором
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }

            return string.Join(" ", arr);
        }

        static void QuickSortIMPI(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int q = Partition(arr, l, r);
                QuickSortIMPI(arr, l, q - 1);
                QuickSortIMPI(arr, q + 1, r);
            }
        }

        static string QuickSort(int[] arr) //Быстрая сортировка
        {
            if (arr != null && arr.Length > 0)
            {
                QuickSortIMPI(arr, 0, arr.Length - 1);
            }

            return string.Join(" ", arr);
        }

        static int Partition(int[] arr, int l, int r)
        {
            int x = arr[r];
            int less = l;

            for (int i = l; i < r; i++)
            {
                if (arr[i] <= x)
                {
                    int temp = arr[i];
                    arr[i] = arr[less];
                    arr[less] = temp;
                    less++;
                }
            }

            int temp2 = arr[less];
            arr[less] = arr[r];
            arr[r] = temp2;

            return less;
        }

        static string MergeSort(int[] arr) //Сортировка слиянием
        {
            if (arr != null && arr.Length > 0)
            {
                int[] buffer = new int[arr.Length];
                MergeSortIMPI(arr, buffer, 0, arr.Length - 1);
            }

            return string.Join(" ", arr);
        }

        static void MergeSortIMPI(int[] arr, int[] buffer, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSortIMPI(arr, buffer, l, m);
                MergeSortIMPI(arr, buffer, m + 1, r);
                int k = l;
                for (int i = l, j = m + 1; i <= m || j <= r;)
                {
                    if (j > r || (i <= m && arr[i] < arr[j]))
                    {
                        buffer[k] = arr[i];
                        i++;
                    }
                    else
                    {
                        buffer[k] = arr[j];
                        j++;
                    }
                    k++;
                }
                for (int i = l; i <= r; i++)
                {
                    arr[i] = buffer[i];
                }
            }
        }
    }
}
