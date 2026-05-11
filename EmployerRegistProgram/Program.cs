using Utils;

namespace EmployeeProject
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("\n0. - Выход");
                Console.WriteLine("1. - Офисный сотрудник");
                Console.WriteLine("2. - Менеджер\n");

                Console.Write("Выберите тип: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Helper.Error("Выбран неверный тип!");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        var obj1 = Create(1, "количество отработанных часов", 
                            "оплату в час", null);
                        ChooseRule(obj1);
                        break;
                    case 2:
                        var obj2 = Create(2, null, "объём продаж", "процент бонуса");
                        ChooseRule(obj2);
                        break;
                    default:
                        Helper.Error("Выбран неверный тип!");
                        continue;
                }
            }
        }

        public static object Create(int num, string? first = null, string? second = null, string? third = null)
        {
            Console.Clear();

            string name = Helper.ReadString("Введите имя: ");

            int age = Helper.ReadInt("Введите возраст: ", 18, 65);

            int baseSalary = Helper.ReadInt("Введите базовую зарплату: ", 0, 300000);

            if (num == 1) // OfficeKlerk
            {
                int workHours = Helper.ReadInt($"Введите {first}: ", 1, 12);
                int moneyPerHour = Helper.ReadInt($"Введите {second}: ", 100, 5000);

                return new OfficeKlerk(name, age, baseSalary, workHours, moneyPerHour, "Офисный сотрудник");
            }
            else if (num == 2) // Manager
            {
                int productCount = Helper.ReadInt($"Введите {second}: ", 0, 1000);
                int bonusPercent = Helper.ReadInt($"Введите {third}: ", 0, 100);

                return new Manager(name, age, baseSalary, productCount, bonusPercent, "Менеджер");
            }

            return null;
        }

        public static void Read(object obj)
        {
            if (obj is OfficeKlerk klerk)
            {
                klerk.PrintInfo();
            }
            else if (obj is Manager manager)
            {
                manager.PrintInfo();
            }
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }

        public static void Edit(object obj)
        {
            bool exit = false;
            bool isManager = obj is Manager;
            bool isOfficeKlerk = obj is OfficeKlerk;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("\n0. - Выход");
                Console.WriteLine("1. - Имя");
                Console.WriteLine("2. - Возраст");
                Console.WriteLine("3. - Базовая ЗП");
                Console.WriteLine("4. - Статус");

                if (isManager)
                {
                    Console.WriteLine("5. - Объем продаж");
                    Console.WriteLine("6. - Процент бонуса");
                }
                else if (isOfficeKlerk)
                {
                    Console.WriteLine("5. - Кол-во отработанных часов");
                    Console.WriteLine("6. - Оплата в час");
                }
                Console.WriteLine();

                Console.Write("Выберите пункт - ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Helper.Error("Выбран неверный пункт!");
                    continue;
                }

                Console.Clear();

                if (choice == 0)
                {
                    exit = true;
                    continue;
                }

                if (isManager)
                {
                    var manager = (Manager)obj;
                    switch (choice)
                    {
                        case 1:
                            manager.Name = Helper.ReadString("Укажите новое имя:");
                            break;
                        case 2:
                            manager.Age = Helper.ReadInt("Укажите новый возраст:", 18, 65);
                            break;
                        case 3:
                            manager.BaseSalary = Helper.ReadInt("Укажите новую ЗП:", 0, 300000);
                            break;
                        case 4:
                            manager.Status = Helper.ReadString("Укажите новый статус:");
                            break;
                        case 5:
                            manager.ProductCount = Helper.ReadInt("Укажите новый объем продаж:", 0, 1000);
                            break;
                        case 6:
                            manager.BonusPercent = Helper.ReadInt("Укажите новый процент бонуса:", 0, 100);
                            break;
                        default:
                            Helper.Error("Неверный пункт!");
                            break;
                    }
                }
                else if (isOfficeKlerk)
                {
                    var officeKlerk = (OfficeKlerk)obj;
                    switch (choice)
                    {
                        case 1:
                            officeKlerk.Name = Helper.ReadString("Укажите новое имя:");
                            break;
                        case 2:
                            officeKlerk.Age = Helper.ReadInt("Укажите новый возраст:", 18, 65);
                            break;
                        case 3:
                            officeKlerk.BaseSalary = Helper.ReadInt("Укажите новую ЗП:", 0, 300000);
                            break;
                        case 4:
                            officeKlerk.Status = Helper.ReadString("Укажите новый статус:");
                            break;
                        case 5:
                            officeKlerk.WorkHours = Helper.ReadInt("Укажите новое кол-во отработанных часов:", 1, 12);
                            break;
                        case 6:
                            officeKlerk.MoneyPerHour = Helper.ReadInt("Укажите новую оплату в час:", 100, 5000);
                            break;
                        default:
                            Helper.Error("Неверный пункт!");
                            break;
                    }
                }

                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
                Console.ReadKey();
            }
        }

        public static void ClaculateSalary(object obj)
        {
            if (obj is OfficeKlerk officeKlerk)
            {
                int salaryFromHours = officeKlerk.WorkHours * officeKlerk.MoneyPerHour;
                int totalSalary = officeKlerk.BaseSalary + salaryFromHours;

                Console.WriteLine($"Зарплата за часы: " +
                    $"{officeKlerk.WorkHours} × {officeKlerk.MoneyPerHour} " +
                    $"= {salaryFromHours} руб");
                Console.WriteLine($"Базовая зарплата: {officeKlerk.BaseSalary} руб");
                Console.WriteLine($"\nИтого: {totalSalary} руб");
            }
            else if (obj is Manager manager)
            {
                int bonusAmount = (manager.ProductCount*1000) * manager.BonusPercent / 100;
                int totalSalary = manager.BaseSalary + bonusAmount;

                Console.WriteLine($"Бонус: {manager.BonusPercent}% от {manager.ProductCount}к (1к = 1000шт) " +
                    $"= {bonusAmount} руб");
                Console.WriteLine($"Базовая зарплата: {manager.BaseSalary} руб");
                Console.WriteLine($"\nИтого: {totalSalary} руб");
            }
            Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
        }

        public static void ChooseRule(object obj)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();

                Console.WriteLine("\n0. - Выход");
                Console.WriteLine("1. - Прочитать данные");
                Console.WriteLine("2. - Редактировать данные");
                Console.WriteLine("3. - Выполнить расчёт\n");

                Console.Write("Выберите опцию - ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Helper.Error("Выбранная неверная опция!");
                    continue;
                }

                Console.Clear();
                switch (choice)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        Read(obj);
                        break;
                    case 2:
                        Edit(obj);
                        break;
                    case 3:
                        ClaculateSalary(obj);
                        break;
                    default:
                        Helper.Error("Неверная опция!");
                        break;
                }
            }
        }
    }
}