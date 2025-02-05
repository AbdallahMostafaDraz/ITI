using System.Collections;

namespace EmployeeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
            {
                new Employee (1, "Abdallah", 24),
                new Employee(2, "Zeyad", 35),
                new Employee(3, "Mohamed", 30),
                new Employee(4, "Salma", 28)
            };

            Console.WriteLine("Soredt By Name: ");
            Array.Sort(employees);
            foreach (Employee employee in employees)
                Console.WriteLine(employee);

            Console.WriteLine("-------------------");
            Console.WriteLine("Soredt By Age: ");
            AgeComparer ageComparer = new AgeComparer();
            Array.Sort(employees, ageComparer);
            foreach (Employee employee in employees)
                Console.WriteLine(employee);



        }
    }

    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(int id, string name, int age) 
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"[{Id}]: {Name}, {Age} Years";
        }

        public int CompareTo(Employee? other)
        {
            return Name.CompareTo(other.Name);
        }
    }

    public class AgeComparer : IComparer<Employee>
    {

        public int Compare(Employee? emp1, Employee? emp2)
        {
            return emp1.Age.CompareTo(emp2.Age);
        }
    }
}
