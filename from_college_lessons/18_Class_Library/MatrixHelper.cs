namespace MatrixUtils
{
    public class MatrixHelper
    {
        public static int[,] CreateMatrix(int rows, int cols)
        {
            var matrix = new int[rows, cols];
            Random rnd = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 10);
                }
            }

            return matrix;
        }

        public static void ReadMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j], 4}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void CalculateProductByInterval(int[,] matrix, int from = 2, int to = 7)
        {
            long product = 1;
            bool hasElements = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] >= from && matrix[i, j] <= to)
                    {
                        product *= matrix[i, j];
                        hasElements = true;
                    }
                }
            }

            if (!hasElements)
            {
                Console.WriteLine($"В матрице нет элементов в интервале [{from};{to}]");
            }

            Console.WriteLine($"Произведение элементов в интервале [{from};{to}] = {product}");
        }

        public static void GetRowWithMaxElement(int[,] matrix)
        {
            int maxElement = matrix[0, 0];
            int maxRow = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                        maxRow = i;
                    }
                }
            }

            int[] result = new int[matrix.GetLength(1)];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[j] = matrix[maxRow, j];
            }

            Console.WriteLine($"Максимальный элемент {maxElement} находится в строке {maxRow + 1}");
            Console.WriteLine($"Строка: [{string.Join(", ", result)}]");
        }

        public static void GetColumnWithMinOnSecondaryDiagonal(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            int minOnSecondaryDiagonal = matrix[0, size - 1];
            int minColumn = size - 1;

            for (int i = 0; i < size; i++)
            {
                int j = size - 1 - i;
                if (matrix[i, j] < minOnSecondaryDiagonal)
                {
                    minOnSecondaryDiagonal = matrix[i, j];
                    minColumn = j;
                }
            }

            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = matrix[i, minColumn];
            }

            Console.WriteLine($"Минимальный элемент на побочной диагонали {minOnSecondaryDiagonal} находится в столбце {minColumn + 1}");
            Console.WriteLine($"Столбец: [{string.Join(", ", result)}]");
        }

        public static void GetAbsSumOfNegativesAboveMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            int count = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i + 1; j < matrix.GetLength(1); j++) 
                {
                    if (matrix[i, j] < 0)
                    {
                        sum += Math.Abs(matrix[i, j]);
                        count++;
                    }
                }
            }

            Console.WriteLine($"Найдено {count} отрицательных элементов над главной диагональю");
            Console.WriteLine($"Сумма модулей отрицательных элементов = {sum}");
        }

        public static void GetNegativeSumsPerRow(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] result = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int rowNegativeSum = 0;
                bool hasNegatives = false;

                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        rowNegativeSum += matrix[i, j];
                        hasNegatives = true;
                    }
                }

                result[i] = hasNegatives ? rowNegativeSum : 0;
            }

            Console.WriteLine("Суммы отрицательных элементов по строкам:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Строка {i + 1}: {result[i]}");
            }
            Console.WriteLine($"Массив: [{string.Join(", ", result)}]");
        }
    }
}
