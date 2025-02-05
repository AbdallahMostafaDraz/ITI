namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a Number: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"char of{n} => {(char)n}");
            Console.Write("/nEnter a Char: ");

            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"int of {c} => {(int)c}");

                    }
    }
}
