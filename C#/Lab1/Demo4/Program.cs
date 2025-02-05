namespace Demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            char operation;

            Console.Write("Enter First Number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Operation: ");
            operation = char.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            number2 = int.Parse(Console.ReadLine());

            string resultStatment = $"{number1} {operation} {number2} =";

            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{resultStatment} {number1 + number2} ");
                    break;
                case '-':
                    Console.WriteLine($"{resultStatment} {number1 - number2} ");
                    break;
                case '*':
                    Console.WriteLine($"{resultStatment} {number1 * number2} ");
                    break;
                case '/':
                    Console.WriteLine($"{resultStatment} {number1 / number2} ");
                    break;
                case '%':
                    Console.WriteLine($"{resultStatment} {number1 % number2} ");
                    break;
                default:
                    Console.WriteLine("Invalid Operation!");
                    break;
            }
        }
    }
}
