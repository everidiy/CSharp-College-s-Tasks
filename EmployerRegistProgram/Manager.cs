using Utils;

namespace EmployeeProject
{
    public class Manager : Employer
    {
        public int ProductCount { get; set; }
        public int BonusPercent { get; set; }
        public string Status { get; set; }

        public Manager(string name, int age, int baseSalary,
                       int productCount, int bonusPercent, string status)
            : base(name, age, baseSalary)
        {
            ProductCount = productCount;
            BonusPercent = bonusPercent;
            Status = status;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя - {Name}");
            Console.WriteLine($"Возраст - {Age} {Helper.GetAgeWord(Age)}");
            Console.WriteLine($"Базовая ЗП - {BaseSalary} руб");
            Console.WriteLine($"Статус - {Status}");
            Console.WriteLine($"Объем продаж - {ProductCount}к (1к = 1000шт)");
            Console.WriteLine($"Процент бонуса - {BonusPercent}%");
        }
    }
}