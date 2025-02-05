using System.Diagnostics;

namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long number;
            Console.Write("Enter Number: ");
            number = long.Parse(Console.ReadLine());    

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            long count = GetNumberOfOnes(number);
            Console.WriteLine($"number of 1: {count}");
            stopwatch.Stop();
            Console.WriteLine($"Time {stopwatch.ElapsedMilliseconds}");

            
            stopwatch.Start();
            count = GetNumberOfOnes2(number);
            Console.WriteLine($"number of 1: {count}");
            stopwatch.Stop();
            Console.WriteLine($"Time {stopwatch.ElapsedMilliseconds}");

        }


        static long GetNumberOfOnes(long number)
        {
            long count = 0;
            for (int i = 0; i < number; i++)
            {
                string numberInString = i.ToString(); 
                for (int j = 0; j < numberInString.Length; j++)
                    if (numberInString[j] == '1')
                        count++;
            }
            return count;
        }

        static long GetNumberOfOnes2(long number)
        {
            long count = 0;

            for (int i = 0; i < number; i++)
            {
                int step = i;
                while (step > 0)
                {
                    if (step % 10 == 1)
                    {
                        count++;
                    }
                    step /= 10;
                }
            }
            return count;
        }

    }
}
