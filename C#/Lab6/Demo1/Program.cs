namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(10, "Ahmed", 25);
            emp1.Print();
            emp1.SetSalary(12000);
            emp1.Print();
            emp1.SetSalary(500);
            emp1.Print();

            Student student = new Student(5, "Abdallah", 12, 7);
            student.Print();
            student.SetGrade(0);
            student.Print();
            Student student2 = new Student(6, "Mohammed", 22, 4);
            student2.Print();

            Console.WriteLine($"Number Of Person: {Person.GetPersonCounter()}");
            Console.WriteLine($"\nNumber Of Employees: {Employee.GetCounter()}");
            Console.WriteLine($"Number Of Students: {Student.GetCounter()}");


        }
    }
}
