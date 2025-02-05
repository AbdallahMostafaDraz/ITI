using MyLib;
namespace Lab10
{
    internal class Program
    {
        public delegate void myDel();
        static void Main(string[] args)
        {
            myDel d = Print1;
            d += Print2;
            d += Print3;
            d();
            Console.WriteLine("--------");

            Action action = Print1;
            action += Print2;
            action += Print3;
            action();
            Console.WriteLine("--------");

            Console.WriteLine(Days.Monday);
            foreach (int val in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine($"{val} | {(Days) val}") ;
            }
        }

        static void Print1()
        {
            Console.WriteLine("Print 1");
        }
        static void Print2()
        {
            Console.WriteLine("Print 2");
        }
        static void Print3()
        {
            Console.WriteLine("Print 3");
        }





        static void Main2(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Abdallah", Salary = 15000m},
                new Employee() { Id = 2, Name = "Ahmed", Salary = 11000m },
                new Employee() { Id = 3, Name = "Ali", Salary = 19000m },
                new Employee() { Id = 4, Name = "Mohamed", Salary = 20000m },
                new Employee() { Id = 5, Name = "Khaled", Salary = 22000m },
                new Employee() { Id = 6, Name = "Mostafa", Salary = 25000m },
                new Employee() { Id = 7, Name = "Ibrahim", Salary = 35000m } };

            NewReport newReport = new NewReport();
            Console.WriteLine("Employees Have Salary In Range 10000 : 20000");
            newReport.PrintReport(employees, e => e.Salary >= 10000 && e.Salary <= 20000);
            Console.WriteLine("Employees Have Salary In Range 20000 : 30000");
            newReport.PrintReport(employees, e => e.Salary > 20000 && e.Salary <= 30000);
            Console.WriteLine("Employees Have Salary More Than 30000");
            newReport.PrintReport(employees, e => e.Salary >= 30000);


            /*
            Report report = new Report();
            Console.WriteLine("Employees Have Salary In Range 10000 : 20000");
            report.ReportSalaryMore10000andLess20000(employees);
            Console.WriteLine("Employees Have Salary In Range 20000 : 30000");
            report.ReportSalaryMore20000andLess30000(employees);
            Console.WriteLine("Employees Have Salary More Than 30000 ");
            report.ReportSalaryMore30000(employees);
            */
        }
    }
}
