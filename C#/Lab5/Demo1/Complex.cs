namespace Demo1
{
    public class Complex
    {
        int real, imagine;
        static int counter;
        public void SetReal(int _real) { real = _real; }
        public int GetReal() { return real; }
        public void SetImagine(int _imagine) { imagine = _imagine; }
        public int GetImagine() { return imagine; }

        public static int GetCounter() { return counter; }
        public Complex() : this(0, 0) 
        { 
        }
        public Complex(int _real, int _imagine)
        {
            real = _real;
            imagine = _imagine;
            counter++;
        }

        public void Print()
        {
            Console.WriteLine($"{real} + {imagine}J");
        }

        public override string ToString()
        {
            if (imagine > 0)
                return $"{real}+{imagine}J";
            else if (imagine < 0)
                return $"{real}{imagine}J";
            else
                return $"{real}";
        }
    }
}
