namespace MyLib
{
    public class NewReport
    {
        public delegate bool MyDel(Employee employee); 
    
        public void PrintReport(List<Employee> employees, MyDel d)
        {
            foreach(Employee employee in employees)
            {
                if (d(employee))
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}
