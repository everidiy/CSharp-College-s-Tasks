namespace EmployeeProject
{
    public class Employer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int BaseSalary { get; set; }

        public Employer(string name, int age, int baseSalary)
        {
            Name = name;
            Age = age;
            BaseSalary = baseSalary;
        }
    }
}