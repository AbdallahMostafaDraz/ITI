namespace Demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "Even" : "Odd");
        }
    }
}
