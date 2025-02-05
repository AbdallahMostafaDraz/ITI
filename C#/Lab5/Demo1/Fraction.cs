namespace Demo1
{
    internal partial class Program
    {
        public class Fraction
        {
            int numerator;
            int denominator;

            public void SetNumerator(int _numerator) { numerator = _numerator;}
            public int GetNumerator() { return numerator; }

            public void SetDenominator(int _denominator)
            {
                if (_denominator == 0)
                {
                    Console.WriteLine("Denminator Must Be Not 0!");
                }
                else
                    denominator = _denominator;
            }
            public int GetDenominator() { return denominator; }
            public Fraction() : this (0, 1) { }

            public Fraction(int _numerator, int _denominator)
            {
                SetNumerator(_numerator);
                SetDenominator(_denominator);
            }

            public void Print()
            {
                if (numerator == 0)
                    Console.WriteLine($"{numerator}");
                else if (numerator == denominator)
                    Console.WriteLine("1");
                else
                    Console.WriteLine($"{numerator}/{denominator}");

            }
            public void Simplify(int _numerator, int _denominator)
            {
                int gcd = GetGCD(_numerator, _denominator);
                numerator = _numerator / gcd;
                denominator = _denominator / gcd;
            }
            private int GetGCD(int _numerator, int _denominator) 
            {
                while (_denominator != 0)  
                {
                    int temp = _denominator; 
                    _denominator = _numerator %  _denominator; 
                    _numerator = temp; 
                }
                return _numerator; 
            }
        }


    }
}
