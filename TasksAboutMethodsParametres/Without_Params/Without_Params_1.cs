using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int[,] grades = {
                {5, 4, 3, 5},
                {3, 4, 4, 4},
                {2, 3, 2, 5}
            };

            double[] averages = ProcessGradeMatrix(grades);

            for (int i = 0; i < averages.Length; i++)
            {
                Console.Write(averages[i] + " ");
            }
        }

        static double[] ProcessGradeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            double[] averages = new double[matrix.GetLength(0)];

            for (int i = 0; i < rows; i++)
            {
                double step = 0;
                for (int j = 0; j < cols; j++)
                {
                    step += matrix[i, j];
                }

                step /= cols;
                averages[i] = step;
            }

            return averages;
        }
    }
}
