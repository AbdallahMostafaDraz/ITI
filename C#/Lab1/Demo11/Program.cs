namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char c;
            Console.Write("Enter a character: ");
            c = char.Parse(Console.ReadLine());
            if (c >= 97)
             Console.WriteLine((char)(c - 32));
            else
                Console.WriteLine((char)(c + 32));

        }
    }
}
