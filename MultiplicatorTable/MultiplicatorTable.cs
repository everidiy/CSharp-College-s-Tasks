using System;

class Multiplicator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите номер операции: ");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 0:
                    Console.WriteLine("Завершение процесса");
                    break;
                case 1:
                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.WriteLine($"{i} * {j} = {i * j}\n");
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Введите первое значение: ");
                    int first = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе значение: ");
                    int second = Convert.ToInt32(Console.ReadLine());

                    if (first > 0 && first <= 10 && second > 0 && second <= 10)
                    {
                        Console.WriteLine($"{first} * {second} = {first * second}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите цифру: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} * {i} = {num * i}");
                    }
                    break;
                default:
                    goto case 0;
            }

            Console.ReadKey();
        }
    }
}