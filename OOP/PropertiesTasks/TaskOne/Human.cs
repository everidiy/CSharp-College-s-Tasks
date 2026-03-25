using System;

namespace TaskOneProperties
{
    internal class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void GetHumanInfo()
        {
            Console.WriteLine($"Имя: {Name} Возраст: {Age}");
        }

        public override string ToString()
        {
            return $"Имя: {Name} Возраст: {Age}";
        }
    }
}
