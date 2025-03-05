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
            /*
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
            */

            // [4] Defferd Execution VS Immediate Execution
            /*
            {
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var evenNumbers = numbers.Where(x => x % 2 == 0);  // Defferd Execution
                numbers.Add(12);
                numbers.Add(14);
                numbers.Add(16);
                numbers.Remove(6);
                Print(evenNumbers);   // 2, 4, 8, 10, 12, 14, 16


                var numbers2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                var evenNumbers2 = numbers2.Where(x => x % 2 == 0).ToList();  // Immedate Execution
                numbers2.Add(12);
                numbers2.Add(14);
                numbers2.Add(16);
                numbers2.Remove(6);
                Print(evenNumbers2);  // 2, 4, 6, 8, 10
            }
            */

            // [5] Projection Operation (Select, SelectMany, Zip)
            {
                // Select
                List<string> words = new() { "my", "name", "is", "abdallah", "mostafa" };
                var upperCaseWords = words.Select(w => w.ToUpper());
                Print(upperCaseWords);
            
                var numbers = new[] { 1, 2, 3, 4, 5 };
                var squares = numbers.Select(n => n * n);
                Print(squares);

                var squares2 = from n in numbers
                               select n * n;
                Print(squares2);

                var employees = EmployeesRepositry.LoadEmployees();
                var employees2 = employees.Select(e => new EmployeeV2 { Name = e.Name });
                Print(employees2);

                // Select Many
                var statments = new[] { "My Name Is Abdallah", "My Age Is 24 Years", "I Love Programming" };
                var wordsInStatments = statments.SelectMany(e => e.Split(' '));
                Print(wordsInStatments);

                var wordsInStatments2 = from s in statments
                                        from w in s.Split(' ')
                                        select w;

                var wordsInStatments3 = statments.SelectMany(w => w.Split(' ')).Distinct();
                Print(wordsInStatments3);


                // Zip
                string[] colorsNames = ["Red", "Green", "Blue"];
                string[] colorsHexa = ["FF0000", "00FF00", "0000FF"];
                var colors = colorsNames.Zip(colorsHexa, (name, hexa) => new { Name = name, Hexa = hexa });
                Print(colors);

                var colors2 = from name in colorsNames.Zip(colorsHexa)
                              select $"{name.First} => {name.Second}";
                Print(colors2);
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
