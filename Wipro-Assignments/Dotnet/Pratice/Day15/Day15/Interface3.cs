

namespace TestAssembly
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public int _id;
        public string _name;

        public Employee()
        {
            Id = 1;
            Name = "John Doe";
            Position = "Software Developer";
            Salary = 60000m;

            _id = 1;
            _name = "John Doe";
        }

        public decimal CalculateBonus(decimal percentage)
        {
            return Salary * percentage / 100;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee: {Name}, Position: {Position}, Salary: {Salary}");
        }
    }
}