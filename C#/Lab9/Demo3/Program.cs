namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.AddRange(new int[] { 3, 4, 5});
            numbers.AddRange([6, 7, 8]);
            numbers.Remove(2);
            numbers.RemoveAt(3);
            foreach (int item in numbers)
            {
                Console.WriteLine(item);
            }
            */

            List<Employee> employees = new List<Employee>()
            {
                new Employee(1, "Abdullah", 50000m),
                new Employee(2, "Mohamed", 60000m),
                new Employee(3, "Ahmed", 45000m)
            };

            employees.Add(new Employee(4, "Salma", 30000m));
            employees.RemoveAt(2);

            foreach (Employee employee in employees) 
                Console.WriteLine(employee);

        }
    }
}
