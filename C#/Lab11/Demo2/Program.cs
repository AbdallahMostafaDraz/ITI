namespace Demo2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Ezzat"),
                new Student(2, "Ahmed"),
                new Student(3, "Mostafa"),
                new Student(4, "Salma"),
                new Student(5, "Mahmoud"),
                new Student(6, "Khaled"),
                new Student(7, "Ali")
            };

            
            Department department1 = new Department(10, ".Net");
            department1.AddStudent(students[0]);
            department1.AddStudent(students[1]);
            department1.AddStudent(students[2]);
            Console.WriteLine("Before Student1 Absent");
            Console.WriteLine(department1);
            students[0].IncreaseAbsentDays();
            students[0].IncreaseAbsentDays();
            students[0].IncreaseAbsentDays();
            students[0].IncreaseAbsentDays();
            Console.WriteLine("\nAfter Student1 Absent More 3 Days");
            Console.WriteLine(department1);

            students[1].IncreaseFailSubjects();
            students[1].IncreaseFailSubjects();
            students[1].IncreaseFailSubjects();
            students[1].IncreaseFailSubjects();
            Console.WriteLine("\nAfter Student2 Fail in More 3 SUbjects");
            Console.WriteLine(department1);


        }
    }
}
