using System;
using System.Collections.Generic;

namespace doubleArr
{
    internal class Program
    {
        static int IndexIFirst = 0;
        static int IndexJFirst = 0;

        static int IndexIThird = 0;
        static int IndexJThird = 2;

        static void Main()
        {
            Random rand = new Random();

            int[,] matric = new int[4, 3];

            for (int i = 0; i < matric.GetLength(0); i++)
            {
                for (int j = 0; j < matric.GetLength(1); j++)
                {
                    matric[i, j] = rand.Next(-10, 10);
                }
            }

            Console.WriteLine(" Your matric: \n");
            PrintMatric(matric);

            int firstNum = GetMaxNum(matric, true);

            int thirdNum = GetMaxNum(matric, false);

            for (int i = 0; i < matric.GetLength(0); i++)
            {
                for (int j = 0; j < matric.GetLength(1); j++)
                {
                    if (matric[i, 0] == firstNum)
                    {
                        IndexIFirst = i;
                    } 

                    if (matric[i, 2] == thirdNum)
                    {
                        IndexIThird = i;
                    }
                }
            }

            Console.WriteLine();
            ChangedMatric(matric, firstNum, thirdNum);
        }

        static void PrintMatric(int[,] arr)
        {
            int counter = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (counter == 2)
                    {
                        counter = 0;
                        Console.WriteLine($" {arr[i, j]}");
                    }
                    else
                    {
                        counter += 1;
                        Console.Write($" {arr[i, j]}");
                    }
                }
            }
        }

        static int GetMaxNum(int[,] arr, bool isFirst)
        {
            if (isFirst)
            {
                List<int> firstList = new List<int>();
                isFirst = false;
                int maxNumFromFirstColumn = 0;

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    firstList.Add(arr[i, 0]);
                }

                Console.Write($"\n First Column: {Enumeration(firstList)} \n");

                firstList.Sort();

                maxNumFromFirstColumn = firstList[firstList.Count - 1];

                Console.WriteLine($" Max num from first column is {maxNumFromFirstColumn}");

                return maxNumFromFirstColumn;

            } else
            {
                List<int> thirdList = new List<int>();
                isFirst = true;
                int maxNumFromThirdColumn = 0;

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    thirdList.Add(arr[i, 2]);
                }

                Console.Write($"\n Third Column: {Enumeration(thirdList)} \n");

                thirdList.Sort();

                maxNumFromThirdColumn = thirdList[thirdList.Count - 1];

                Console.WriteLine($" Max num from third column is {maxNumFromThirdColumn}");

                return maxNumFromThirdColumn;
            }
        }

        static string Enumeration(List<int> list)
        {
            string str = "";

            for (int i = 0; i < list.Count; i++)
            {
                str += $" {list[i]} ";
            }

            return str;
        }

        static void ChangedMatric(int[,] arr, int first, int third)
        {
            int tempFirst = first;
            int tempThird = third;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (IndexIFirst == i && IndexJFirst == j)
                    {
                        arr[IndexIFirst, IndexJFirst] = tempThird;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (IndexIThird == i && IndexJThird == j)
                    {
                        arr[IndexIThird, IndexJThird] = tempFirst;
                    }
                }
            }

            Console.WriteLine(" Changed matric: \n");
            PrintMatric(arr);
        }
    }
}
