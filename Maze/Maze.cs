using System;

namespace Maze
{
    internal class Program
    {
        static void Main()
        {
            Console.Clear();

            Console.WriteLine("Выберите вариант генерации лабиринта: \n");
            Console.WriteLine("(1) - Стандартный");
            Console.WriteLine("(2) - Рандомный\n");

            int step = Convert.ToInt32(Console.ReadLine());

            switch (step)
            {
                case 1:
                    StandartMaze();
                    break;
                case 2:
                    RandomMaze();
                    break;
                default:
                    Main();
                    break;
            }
        }

        static void StandartMaze()
        {
            Console.Clear();

            char[,] maze = 
            {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ' },
                { '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#' },
                { '#', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#' },
                { '#', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', ' ', '#', ' ', ' ', ' ', '#', '#', '#', '#' },
                { '#', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', '#', ' ', '#', '#', '#', ' ', '#', '#' },
                { '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', '#', '#', '#', '#', ' ', '#', '#' }
            };

            Console.WriteLine("Ваш лабиринт: \n");
            PrintMaze(maze);

            int x = 10;
            int y = 1;
            int targetX = 8;
            int targetY = 10;

            Go(maze, x, y, targetX, targetY);
        }

        static void RandomMaze()
        {
            Console.Clear();

            int width = 11;
            int height = 11;

            Random rnd = new Random();
            char[,] maze = new char[height, width];

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    maze[i, j] = '#';

            Cut(maze, 1, 1, height, width, rnd);

            int y = 1;
            int x = 0;
            maze[y, x] = ' ';

            int targetY = height - 2;
            int targetX = width - 1;
            maze[targetY, targetX] = ' ';

            Console.WriteLine("Ваш лабиринт: \n");
            PrintMaze(maze);

            Go(maze, x, y, targetX, targetY);
        }

        static void Cut(char[,] maze, int y, int x, int height, int width, Random rnd)
        {
            maze[y, x] = ' ';

            var directions = new (int dy, int dx)[]
            {
            (0, 2), (0, -2), (2, 0), (-2, 0)
            };

            for (int i = directions.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (directions[i], directions[j]) = (directions[j], directions[i]);
            }

            foreach (var (dy, dx) in directions)
            {
                int ny = y + dy;
                int nx = x + dx;

                if (ny > 0 && ny < height - 1 &&
                    nx > 0 && nx < width - 1 &&
                    maze[ny, nx] == '#')
                {
                    maze[y + dy / 2, x + dx / 2] = ' ';
                    Cut(maze, ny, nx, height, width, rnd);
                }
            }
        }

        static void Go(char[,] maze, int x, int y, int targetX, int targetY)
        {
            if (x < 0 || y >= 11 || y < 0 || x >= 11) return;

            if (maze[y, x] == ' ')
            {
                maze[y, x] = '.';

                if (x == targetX && y == targetY)
                {
                    Console.WriteLine("Найден путь: \n");
                    PrintMaze(maze);
                    return;
                }

                Go(maze, x + 1, y, targetX, targetY); // вправо
                Go(maze, x - 1, y, targetX, targetY); // влево
                Go(maze, x, y + 1, targetX, targetY); // вниз
                Go(maze, x, y - 1, targetX, targetY); // вверх
            }
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
            ;
        }
    }
}

