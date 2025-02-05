namespace Demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            while(sum < 100)
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
