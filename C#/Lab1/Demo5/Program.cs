namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter Number[{i+1}]: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
