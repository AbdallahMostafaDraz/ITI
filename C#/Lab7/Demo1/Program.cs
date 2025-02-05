namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Abdullah", 35, 50000);
            employee.Print();

            Student student = new Student(2, "Anas", 7, 2);
            student.Print();

            Console.WriteLine($"Person: {Person.GetCounter()}, Employees: {Employee.GetCounter()}, " +
                $"Students: {Student.GetCounter()}");

        }
    }
}
