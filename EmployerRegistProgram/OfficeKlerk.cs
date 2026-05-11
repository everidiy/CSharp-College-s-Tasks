using Utils;

namespace EmployeeProject
{
    public class OfficeKlerk : Employer
    {
        public int WorkHours { get; set; }
        public int MoneyPerHour { get; set; }
        public string Status { get; set; }

        public OfficeKlerk(string name, int age, int baseSalary,
                           int workHours, int moneyPerHour, string status)
            : base(name, age, baseSalary)
        {
            WorkHours = workHours;
            MoneyPerHour = moneyPerHour;
            Status = status;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя - {Name}");
            Console.WriteLine($"Возраст - {Age} {Helper.GetAgeWord(Age)}");
            Console.WriteLine($"Базовая ЗП - {BaseSalary} руб");
            Console.WriteLine($"Статус - {Status}");
            Console.WriteLine($"Кол-во отработанных часов - {WorkHours} ч");
            Console.WriteLine($"Оплата в час - {MoneyPerHour} руб/ч");
        }
    }
}