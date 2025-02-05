namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            while(number > 1)
            {
                sum *= number;
                number--;
            }
            Console.WriteLine($"Factorial = {sum}");
        }
    }
}
