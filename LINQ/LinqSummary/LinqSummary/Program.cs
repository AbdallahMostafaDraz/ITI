using LinqSummary.Models;
using LinqSummary.Repositries;
using System.Collections;

namespace LinqSummary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] Wirte Linq Statemnets 
            /*
            {
                int[] numbers = [10, 20, 30, 40, 50, 60, 70, 80, 90, 100];

                // Write Linq With Method Syntax
                var result = numbers.Where(x => x > 50);
                Console.WriteLine("Numbers Greater Than 50 Using Method Syntax");
                Print(result);

                // Write Linq With Method Syntax (Enumerable Method)
                var result2 = Enumerable.Where(numbers, x => x > 50);
                Console.WriteLine("Numbers Greater Than 50 Using Method Syntax (Enumerable Method)");
                Print(result2);

                // Write Linq With Query Syntax
                var resutl3 = from n in numbers
                              where n > 50
                              select n;
                Console.WriteLine("Numbers Greater Than 50 Using Query Syntax");
                Print(resutl3);
            }
            */

            // [2] Where(), OfType<>
            /*
            {
                var employees = EmployeesRepositry.LoadEmployees();
                var list1 = employees.Where(x => x.Salary > 5000);
                Console.WriteLine("Employees With Salary Greater Than 5000");
                Print(list1);

                ArrayList list2 = new ArrayList() { 1, "Abdallah", 3.5, true, "Mohammed", 5, new Employee { Id = 1, Name = "Ahmed", Salary = 8000m } };
                
                var employeesInList = list2.OfType<Employee>();
                Console.WriteLine("Employees In List");
                Print(employeesInList);

                var stringsInList = list2.OfType<string>();
                Console.WriteLine("Strings In List");
                Print(stringsInList);
            }
            */

            // [3] Select a Specific Element
            {
                var employees = EmployeesRepositry.LoadEmployees();
                
                var firstEmployee = employees.FirstOrDefault();
                var firstEmployeeHasSalaryGreaterThan5000 = employees.FirstOrDefault(e => e.Salary > 5000);
                
                var lastEmployee = employees.LastOrDefault();
                var lastEmployeeHasSalaryGreaterThan5000 = employees.LastOrDefault(e => e.Salary > 5000);

                Console.WriteLine(firstEmployee);
                Console.WriteLine(firstEmployeeHasSalaryGreaterThan5000);

                Console.WriteLine(lastEmployee);
                Console.WriteLine(lastEmployeeHasSalaryGreaterThan5000);

                
                var employeeHasSalary5000 = employees.SingleOrDefault(e => e.Salary == 5000);
                Console.WriteLine(employeeHasSalary5000);

                

                var thirdEmployee = employees.ElementAtOrDefault(2);
                Console.WriteLine(thirdEmployee);

                // Different Between First() and FirstOrDefault(), Last() and LastOrDefault(), ElementAt() and ElementAtOrDefault()
                    // First, Last, ElementAt if not found element will throw exception
                    // FirstOrDefault, LastOrDefault, ElementAtOrDefault if not found element will return default value (in this case null)

                // Single =>  if there no elements or return more than one element, will throw an exception
                // SingleOrDefault => if there no elements retunr default value. and if return more than one element, will thorw an exception also.
            
            }


        }

        static void Print<T>(IEnumerable<T> result)
        {
            foreach (var item in result)
                Console.Write($"{item}\n");
            Console.WriteLine();
        }
    }
}
