using System;
using System.Collections.Generic;

namespace Maze
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Разработал: Давыдов Богдан Максимович \nСтудент группы: 106-Д9-2ИСП \nДата выполнения: 17.02.2026 \n");
            Console.WriteLine("Программа для решения задача - Лабиринт\n");

            Console.WriteLine("Выберите вариант генерации лабиринта: \n");
            Console.WriteLine("(1) - Стандартный");

            int step = Convert.ToInt32(Console.ReadLine());

            switch (step)
            {
                case 1:
                    GetStandartMaze();
                    GetOptimalWay();
                    break;
                case 2:
                    Main();
                    break;
                default:
                    Main();
                    break;
            }
        }

        static int StandartX = 1;
        static int StandartY = 10;
        static int StandartTargetX = 10;
        static int StandartTargetY = 8;

        static char[,] StandartMaze =
            {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ' },
                { '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#' },
                { '#', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#' },
                { '#', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#', '#' },
                { '#', '#', ' ', '#', '#', '#', '#', '#', ' ', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#' },
                { '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', '#', '#', '#', '#', ' ', '#', '#' }
            };

        static int counter = 0;
        static int steps = 0;
        static List<int> stepsArr = new List<int>();

        static void GetStandartMaze()
        {
            Console.Clear();

            Console.WriteLine(" Ваш лабиринт: \n");
            PrintMaze(StandartMaze);

            Go(StandartMaze, StandartX, StandartY, StandartTargetX, StandartTargetY);
        }

        static void Go(char[,] maze, int x, int y, int targetX, int targetY)
        {
            if (x < 0 || x >= 11 || y < 0 || y >= 11) return;

            if (maze[x, y] == ' ')
            {
                maze[x, y] = '.';

                if (x == targetX && y == targetY)
                {   
                    counter++;
                    steps = CountDotes(maze);
                    stepsArr.Add(steps);
                    Console.WriteLine($" Найден путь №{counter}");
                    Console.WriteLine($" Кол-во шагов: {steps}\n");
                    
                    char[,] copyMaze = (char[,])maze.Clone();
                    PrintMaze(copyMaze);
                    Console.WriteLine();
                } else
                {
                    char[,] copyMaze = (char[,])maze.Clone();
                    Go(copyMaze, x + 1, y, targetX, targetY); // вправо
                    Go(copyMaze, x - 1, y, targetX, targetY); // влево
                    Go(copyMaze, x, y + 1, targetX, targetY); // вниз
                    Go(copyMaze, x, y - 1, targetX, targetY); // вверх
                }

                maze[x, y] = ' ';
            }
        }

        static int CountDotes(char[,] maze)
        {
            int count = 0;
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    if (maze[i, j] == '.') count++;
                }
            }
            return count;
        }

        static void PrintMaze(char[,] maze)
        {
            
                for (int i = 0; i < maze.GetLength(0); i++)
                {
                    for (int j = 0; j < maze.GetLength(1); j++)
                    {
                        Console.Write($"{maze[i, j],3}");
                    }
                    Console.WriteLine("\n");
                }
            
        }

        static void GetOptimalWay()
        {
            Console.WriteLine(" Итог по шагам: \n");
            int countSteps = 0;
            for (int i = 0; i < stepsArr.Count;  i++)
            {
                countSteps += 1;
                Console.Write($" Путь {countSteps} - Кол-во шагов - {stepsArr[i]}\n");
            }

            stepsArr.Sort();

            countSteps = 0;
            for (int i = 0;i < stepsArr.Count; i++)
            {
                if (stepsArr[i] < stepsArr[stepsArr.Count - 1])
                {
                    countSteps += 1;
                    Console.WriteLine($"\n Путь {countSteps} самый оптимальный!\n");
                    break;
                }
            }
        }
    }
}
