using System.Security.Cryptography.X509Certificates;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Rectangle rectangle = new Rectangle(10, 20);
            Traingle traingle = new Traingle(10, 20);
            Square square = new Square(10);

            
            rectangle.Print();
            Console.WriteLine($"Area: {CalculateArea(rectangle)}");

            traingle.Print();
            Console.WriteLine($"Area: {CalculateArea(traingle)}");

            square.Print();
            Console.WriteLine($"Area = {CalculateArea(square)}");

        }

        static float CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}
