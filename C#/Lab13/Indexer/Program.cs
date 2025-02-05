namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex complex = new Complex(10, 15);
            try
            {
                complex[0] = 20;
                complex[1] = 30;
                Console.WriteLine(complex[0]);
                Console.WriteLine(complex[1]);
                Console.WriteLine("--------------");
                complex["real"] = 100;
                complex["img"] = 200;
                Console.WriteLine(complex["real"]);
                Console.WriteLine(complex["img"]);
                Console.WriteLine(complex["complex"]); // execption

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public int this[int i]
        {
            get
            {
                if (i == 0)
                    return Real;
                else if (i == 1)
                    return Img;
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                    Real = value;
                else if (i == 1)
                    Img = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        public int this[string s]
        {
            get
            {
                if (s.ToLower() == "real")
                    return Real;
                else if (s.ToLower() == "img")
                    return Img;
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (s.ToLower() == "real")
                    Real = value;
                else if (s.ToLower() == "img")
                    Img = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        public Complex(int real, int img )
        {
            Real = real;
            Img = img;
        }

        public override string ToString()
        {
            if (Img > 0)
            {
                return $"{Real}+{Img}J";
            }
            else if (Img < 0)
            {
                return $"{Real}{Img}J";
            }
            else 
                return $"{Real}";
        }
    }
}
