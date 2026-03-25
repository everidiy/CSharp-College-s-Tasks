using System;

namespace Constructor
{
    internal class Pupil
    {
        internal string Name { get; set; }
        internal string Surname { get; set; }
        internal int Grade { get; set; }
        internal double Average { get; set; }
        internal int Passes { get; set; }

        //несколько параметров
        public Pupil() : this("Неизвестно", "Неизвестно", 0, 0.0, 0) { }

        //несколько параметров
        public Pupil(string name, string surname) : this(name, surname, 0, 0.0, 0) { }

        //полный набор параметров
        public Pupil(string name, string surname, int grade, double average, int passes)
        {
            Name = name;
            Surname = surname;
            Grade = grade;
            Average = average;
            Passes = passes;
        }

        public void GetInfo()
        {
            ConsoleHelper.PrintCentered("Добавлен новый ученик!");
            ConsoleHelper.PrintCentered("(Подождите, программа продолжится сама!)");
        }

        public void GetFullInfo()
        {
            Console.Clear();

            ConsoleHelper.PrintCentered($"Имя - {Name}");
            ConsoleHelper.PrintCentered($"Фамилия - {Surname}");
            ConsoleHelper.PrintCentered($"Класс - {Grade}");
            ConsoleHelper.PrintCentered($"Средний балл - {Average}");
            ConsoleHelper.PrintCentered($"Пропуски - {Passes}\n");

            ConsoleHelper.PrintCentered($"Нажмите любую клавишу, чтобы вернуться назад");
            Console.ReadKey();
        }

        public void CheckPasses()
        {
            Console.Clear();

            if (Passes >= 15)
            {
                ConsoleHelper.PrintCentered($"Пропуски ученика - {Surname} {Name} - превышены!");
                ConsoleHelper.PrintCentered($"Кол-во пропусков - {Passes}\n");
            }
            else
            {
                ConsoleHelper.PrintCentered($"Пропуски ученика - {Surname} {Name} - не превышены!");
                ConsoleHelper.PrintCentered($"Кол-во пропусков - {Passes}\n");
            }
            ConsoleHelper.PrintCentered($"Нажмите любую клавишу, чтобы вернуться назад");
            Console.ReadKey();
        }

        public void CheckStatus()
        {
            Console.Clear();

            if (Average <= 3.49)
            {
                ConsoleHelper.PrintCentered($"Ученик имеет низкую успеваемость!");
                ConsoleHelper.PrintCentered($"Средний балл - {Average}\n");
            }
            else if (Average <= 4.49 && Average > 3.49)
            {
                ConsoleHelper.PrintCentered($"Ученик является хорошистом!");
                ConsoleHelper.PrintCentered($"Средний балл - {Average}\n");
            } else
            {
                ConsoleHelper.PrintCentered($"Ученик является отличником!");
                ConsoleHelper.PrintCentered($"Средний балл - {Average}\n");
            }
            ConsoleHelper.PrintCentered($"Нажмите любую клавишу, чтобы вернуться назад");
            Console.ReadKey();
        }
    }
}
