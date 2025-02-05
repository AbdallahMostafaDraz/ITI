using System.Diagnostics;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0; 
            for (int i = 1; i < 1000000; i++)
            {
                string number = i.ToString(); // "1231"
                for (int j = 0; j < number.Length; j++)
                    if (number[j] == '1')
                        count++;
            }
            Console.WriteLine($"number of 1: {count}");
            stopwatch.Stop();
            Console.WriteLine($"Time {stopwatch.ElapsedMilliseconds}");

            /*
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int count = 0;

            for (int i = 1; i < 1000000; i++)
            {
                int number = i;
                while (number > 0)
                {
                    if (number % 10 == 1) 
                    {
                        count++;
                    }
                    number /= 10;     
                }
            }
            Console.WriteLine($"number of 1: {count}");
            stopwatch.Stop();
            Console.WriteLine($"Time {stopwatch.ElapsedMilliseconds}");

            */

        }
    }
}
