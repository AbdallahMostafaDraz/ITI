namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4);
            rectangle.Print();

            Traingle traingle = new Traingle(6, 4);
            traingle.Print();

            Square square = new Square(4);
            square.Print();

            Circle circle = new Circle(4);
            circle.Print();
        }
    }
}
