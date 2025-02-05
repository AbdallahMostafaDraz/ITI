namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(10, 20);
            Complex c2 = new Complex(11, 22);

            Complex  c3 = c1 + c2;
            Console.WriteLine($"C1 + C2 = {c3}");
            c3 = c2 - c1;
            Console.WriteLine($"C2 - C1 = {c3}");
            c3 = c1++;
            Console.WriteLine($"C1++ = {c1++}");
            int x = 100;
            Console.WriteLine($"C1 + {x} = {c1 + x}");
            Console.WriteLine($"{x} + c1 = {x + c1}");
            Console.WriteLine($"C1 > C2: {c1 > c2}");
            Console.WriteLine($"C1 < C2: {c1 < c2}");
            Console.WriteLine($"C1 == C2: {c1 == c2}");
            Console.WriteLine($"C1 != C2: {c1 != c2}");
            c3.SerReal(c1.GetReal());
            c3.SetImg(c1.GetImg());
            Console.WriteLine($"C1 == C3: {c1 == c3}");
            Console.WriteLine($"C1.Equals(C3): {c1.Equals(c3)}");

            x = (int)c1;
            c1 = x;
            Console.WriteLine($"Cast Complex To int: {x}");
            Console.WriteLine($"Cast int To Complex: {c1}");


            Complex cc = new Complex(10, 20);
            Complex ccc = new Complex(10, 20);
            Console.WriteLine(cc < ccc);
        }
    }
}
