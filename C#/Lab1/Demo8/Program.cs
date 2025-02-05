namespace Demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.Clear();
            do
            {
                Console.WriteLine("Please Choose One From Menu");
                Console.WriteLine("new(n)\ndisplay(d)\nexit(e)");
                Console.Write("Choose: ");
                c = char.Parse(Console.ReadLine());
                switch (c)
                {
                    case 'n':
                    case 'N':
                        Console.WriteLine("NEW");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("DISPLAY");
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine("EXIT!");
                        break;
                    default:
                        Console.WriteLine("Wrong Choose");
                        break;
                }
            } while (c != 'e' && c != 'E');
        }
    }
}
