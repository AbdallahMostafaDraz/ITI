namespace MyLib
{
    public class Report
    {
        public void ReportSalaryMore10000andLess20000(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.Salary >= 10000m && employee.Salary <= 20000m)
                    Console.WriteLine(employee);
            }
        }

        public void ReportSalaryMore20000andLess30000(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.Salary > 20000m && employee.Salary <= 30000m)
                    Console.WriteLine(employee);
            }
        }

        public void ReportSalaryMore30000(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                if (employee.Salary > 30000m)
                    Console.WriteLine(employee);
            }
        }
    }
}
