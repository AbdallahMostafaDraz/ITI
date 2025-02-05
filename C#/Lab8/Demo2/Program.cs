namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(2, 4);
            Fraction fraction2 = new Fraction(8, 16);
            Console.WriteLine($"Fraction1: {fraction1}, Fraction2: {fraction2}");
            Console.WriteLine($"\n{fraction1} Equals {fraction2}:  {fraction1.Equals(fraction2)}");
            Console.WriteLine($"\n{fraction1} > {fraction2}: {fraction1 > fraction2}");
            Console.WriteLine($"\n{fraction1}++: {fraction1++}");
            Console.WriteLine($"\n{fraction2}--: {fraction2--}");
            Console.WriteLine($"\n({fraction1}) + ({fraction2}): {fraction1 + fraction2}");
            Console.WriteLine($"\n({fraction1}) - ({fraction2}): {fraction1 - fraction2}");
            Console.WriteLine($"\n({fraction1}) * ({fraction2}): {fraction1 * fraction2}");
            Console.WriteLine($"\n({fraction1}) / ({fraction2}): {fraction1 / fraction2}");

        }
    }
}
