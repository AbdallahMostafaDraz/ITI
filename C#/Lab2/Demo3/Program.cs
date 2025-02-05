namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Ennter Your Name: ");
            name = Console.ReadLine();


            string[] nameRevesed = name.Split(' ');
            for (int i = nameRevesed.Length - 1; i >= 0; i--)
                Console.Write($"{nameRevesed[i]}\t");
            
        }

    }
}
