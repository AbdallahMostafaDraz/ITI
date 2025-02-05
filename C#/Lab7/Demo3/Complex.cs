namespace Demo3
{
    public struct Complex
        {
            public int real = 1; 
            public int imaginary = 1;

        public Complex()
        {
            real = imaginary = 0;
        }

        public Complex(int _real, int _imaginary)
        {
            real = _real;
            imaginary = _imaginary;
        }

        public void SetReal(int _real) { real = _real; }
            public int GetReal() { return real; }

            public void SetImaginary(int _imaginary) { imaginary = _imaginary; }

            public int GetImaginary() { return imaginary; }

            public void Print()
            {
                if (imaginary == 0)
                    Console.WriteLine($"{real}");
                else if (imaginary < 0)
                    Console.WriteLine($"{real}{imaginary}J");
                else
                    Console.WriteLine($"{real}+{imaginary}J");
            }

            public void test()
            {
              Console.WriteLine("Test");
            }
    }
}
