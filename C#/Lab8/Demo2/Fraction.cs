namespace Demo2
{
    public class Fraction
    {
        int numerator, denominator;
        public Fraction()
        {
            numerator = denominator = 1;
        }
        public Fraction(int _numerator, int _denominator)
        {
            numerator = _numerator;
            denominator = _denominator;
        }
        public void SetNumerator(int _numerator) { numerator = _numerator; }
        public int GetNumerator() { return numerator; }
        public void SerDenominator(int _denominator) { denominator = _denominator; }
        public int GetDenominator() { return denominator; }

        public Fraction Simplify(int _numerator, int _denominator)
        {
            int gcd = GetGCD(_numerator, _denominator);
            return new Fraction(_numerator / gcd, _denominator / gcd);
        }
        private int GetGCD(int _numerator, int _denominator)
        {
            while (_denominator == 0)
            {
                int temp = _denominator;
                _numerator = temp;
                _denominator = _numerator % _denominator;
            }
            return _numerator;
        }
        public override string ToString()
        {
            if (numerator == denominator)
                return "1";
            else if (numerator == 0)
                return "0";
            else
                return $"{numerator} / {denominator}";
        } 

        public override bool Equals(object? obj)
        {
            Fraction f2 = obj as Fraction;
            if (f2 is null && f2.GetType() != this.GetType())
                return false;

            var f1Smplified = Simplify(numerator, denominator);
            var f2Simplified =  f2.Simplify(f2.numerator, f2.denominator);
            return f1Smplified.numerator == f2Simplified.numerator && f1Smplified.denominator == f2Simplified.denominator;
        }

        public static  bool operator==(Fraction f1, Fraction f2)
        {
            var f1Smplified = f1.Simplify(f1.numerator, f1.denominator);
            var f2Simplified = f2.Simplify(f2.numerator, f2.denominator);
            return f1Smplified.numerator == f2Simplified.numerator && f1Smplified.denominator == f2Simplified.denominator;
        }
        public static  bool operator!=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.numerator = (f1.numerator * f2.denominator) + (f2.numerator * f1.denominator);
            result.denominator = (f1.denominator * f2.denominator);
            return result;
        }

        public static Fraction operator-(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.numerator = (f1.numerator * f2.denominator) - (f2.numerator * f1.denominator);
            result.denominator = (f1.denominator * f2.denominator);
            return result;
        }

        public static Fraction operator*(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.numerator = f1.numerator * f2.numerator;
            result.denominator = f1.denominator * f2.denominator;
            return result;
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            Fraction result = new Fraction();
            result.numerator = f1.numerator * f2.denominator;
            result.denominator = f1.denominator * f2.numerator;
            return result;
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            var f1Simplified =  f1.Simplify(f1.numerator, f1.denominator);
            var f2Simplified =  f2.Simplify(f2.numerator, f2.denominator);
            return f1Simplified.numerator > f2Simplified.numerator || f1Simplified.denominator < f2Simplified.denominator;
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return !(f1 > f2) && !(f1 == f2);
        }

        public static Fraction operator++(Fraction f)
        {
            return new Fraction(f.numerator++, f.denominator);   
        }

        public static Fraction operator --(Fraction f)
        {
            return new Fraction(f.numerator--, f.denominator);
        }


    }
}
