namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Grade: ");
            int degree = int.Parse(Console.ReadLine());

            if (degree >= 85)
                Console.WriteLine("Grade: Excellent");
            else if (degree >= 75)
                Console.WriteLine("Grade: Very Good");
            else if (degree >= 65)
                Console.WriteLine("Grade: Good");
            else if (degree >= 50)
                Console.WriteLine("Gradee: Pass");
            else
                Console.WriteLine("Grade: Fail");
        }
    }
}
