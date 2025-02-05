namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = Complex.CreateInstance(5, 10);
            Complex complex2 = Complex.CreateInstance(15, 20);
            Complex complex3 = Complex.CreateInstance(30, 40);

            Console.WriteLine(complex1);
            Console.WriteLine(complex2);
            Console.WriteLine(complex3);
        }
    }

    public class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        static Complex obj = null;
        private Complex(int real, int img)
        {
            Real = real;
            Img = img;
        }

        public static Complex CreateInstance(int real, int img)
        {
            if (obj == null)
                obj = new Complex(real, img);
            return obj;
        }

        public override string ToString()
        {
            return $"{Real}+{Img}J";
        }
    }
}
