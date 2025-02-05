namespace Demo2
{
    public class Complex
    {
        int real, imagine;
        public void SetReal(int _real) { real = _real; }
        public int GetReal() { return real; }
        public void SetImagine(int _imagine) { imagine = _imagine; }
        public int GetImagine() { return imagine; }

        public Complex(int _real, int _imagine)
        {
            real = _real;
            imagine = _imagine;
        }

        public void Print()
        {
            Console.WriteLine($"{real} + {imagine}J");
        }
    }
}
