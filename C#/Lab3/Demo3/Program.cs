namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Enter Your Name: ");
            name = Console.ReadLine();

            Print(ReverseName(name));
        }

        static string[] ReverseName(string name)
        {
            string[] nameRevesed = name.Split(' ');
            return nameRevesed;
        }

        static void Print(string[] names)
        {
            for (int i = names.Length - 1; i >= 0; i--)
                Console.Write($"{names[i]} ");
        }
    }
}
