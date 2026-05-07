using MatrixUtils;

namespace _18_Class_Library
{
    internal class Program
    {
        static void Main()
        {
            bool exit = false;
            int[,]? matrix = null;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("\n0. Выход");
                Console.WriteLine("1. Сформировать матрицу");
                Console.WriteLine("2. Просмотреть матрицу");
                Console.WriteLine("3. Удалить матрицу");

                Console.WriteLine("\n4. Вычислить произведение элементов матрицы в интервале [2;7]");
                Console.WriteLine("5. Получить одномерный массив (строка с максимальным элементом)");
                Console.WriteLine("6. Сформировать одномерный массив (столбец с минимумом на побочной диагонали)");
                Console.WriteLine("7. Вычислить сумму модулей отрицательных элементов над главной диагональю");
                Console.WriteLine("8. Сформировать одномерный массив из сумм отрицательных элементов строк");

                Console.Write("\nВыберите интересующую вас опцию: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nНеправильно выбранная опция!");
                    Thread.Sleep(1000);
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        matrix = MatrixHelper.CreateMatrix(5, 5);
                        Console.WriteLine("\nМатрица успешно создана!");
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        continue;
                    case 2:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.ReadMatrix(matrix);
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        continue;
                    case 3:
                        matrix = null;
                        Console.WriteLine("\nМатрица успешно удалена!");
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        continue;
                    case 4:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.CalculateProductByInterval(matrix);
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        continue;
                    case 5:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.GetRowWithMaxElement(matrix);
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        continue;
                    case 6:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.GetColumnWithMinOnSecondaryDiagonal(matrix);
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        continue;
                    case 7:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.GetAbsSumOfNegativesAboveMainDiagonal(matrix);
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        
                        continue;
                    case 8:
                        if (matrix != null)
                        {
                            Console.WriteLine();
                            MatrixHelper.GetNegativeSumsPerRow(matrix);
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nОшибка: матрица не создана! Выберите пункт 1!");
                            Console.WriteLine("Нажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                        continue;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ошибка: выберите число от 1 до 7. \nНажмите любую клавишу, чтобы продолжить.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
