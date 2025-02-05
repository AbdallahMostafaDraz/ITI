using Demo3;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeList employees = new EmployeeList();
            employees.Add(new Employee(1, "Abdullah", 50000m));
            employees.Add(new Employee(2, "Mostafa", 15000m));
            employees.Add(new Employee(3, "Mahmoud", 35000m));


        }
    }
    public class EmployeeList : List<Employee>
    {

        public new void Add(Employee emp)
        {
            base.Add(emp);
            string path = "C:\\Users\\User\\Desktop\\Employees.txt";
            using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(emp.ToString());
                }
            }
        }
    }
}
