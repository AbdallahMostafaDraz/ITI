using Dapper.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Text;

namespace Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pyhiscalMemory = Process.GetCurrentProcess().WorkingSet64;
            var virtualMemory = Process.GetCurrentProcess().VirtualMemorySize64;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            //AdventureWorksContext context = new();
            //var q1 = context.People.ToList();
            //Console.WriteLine(q1[0].FirstName);
               
            var connection = new SqlConnection("Server=.\\sqlexpress;Database=AdventureWorks2019; integrated security = sspi; Trust server certificate =True;");

            sw.Stop();
            Console.WriteLine($"Time: {sw.Elapsed}");

            pyhiscalMemory = (Process.GetCurrentProcess().WorkingSet64 - pyhiscalMemory) / 1000;
            virtualMemory = (Process.GetCurrentProcess().VirtualMemorySize64 - virtualMemory) / 1000;
            Console.WriteLine($"{pyhiscalMemory} -- {virtualMemory}");
        }
    }
}
