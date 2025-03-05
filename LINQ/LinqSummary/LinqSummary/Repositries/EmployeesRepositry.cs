using LinqSummary.Models;


namespace LinqSummary.Repositries
{
    public class EmployeesRepositry
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 1, Name = "Abdallah", Salary = 5000m },
                new Employee { Id = 2, Name = "Ahmed", Salary = 6000m },
                new Employee { Id = 3, Name = "Sara",  Salary = 4000m },
                new Employee { Id = 4, Name = "Ibrahim", Salary = 7000m },
                new Employee { Id = 5, Name = "Ali", Salary = 8000m },
                new Employee { Id = 6, Name = "Nader", Salary = 7500m },
                new Employee { Id = 7, Name = "Yomna", Salary = 6500m },
                new Employee { Id = 8, Name = "Shimaa", Salary = 5500m },
                new Employee { Id = 9, Name = "Zeyad",  Salary = 7000m },
                new Employee { Id = 10, Name = "Khaled" , Salary = 4500m }
            };
        }
        
    }
}
