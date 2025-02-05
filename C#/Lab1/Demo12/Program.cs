namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            int mirror = 0;
            while (number > 0)
            {
                // 1234 123 12 1
                int reminder = number % 10; // 4  3 //2 // 1
                mirror = (mirror * 10) + reminder; //  4321 
                number = number / 10;  //123 //12 //1
            }
            Console.WriteLine(mirror);
            
            
        }
    }
}
