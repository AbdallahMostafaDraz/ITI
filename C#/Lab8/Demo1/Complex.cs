namespace Demo1
{
    public class Complex
    {
        int real, img;
        public Complex(int _real, int _img = 0)
        {
            real = _real;
            img = _img;
        }
        public void SerReal(int _real) { real = _real; }
        public int GetReal() { return real; }

        public void SetImg (int _img) { img = _img; }
        public int GetImg() { return img; }

        public override string ToString()
        {
            if (img < 0)
                return $"{real}{img}J";
            else if (img == 0)
                return $"{real}";
            else
                return $"{real}+{img}J";
        }
        public override bool Equals(object? obj)
        {
            Complex c = obj as Complex;
            if (c is null || c.GetType() != this.GetType())
                return false;

            return real == c.real && img == c.img;
        }

        public static  Complex operator+(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c2.img + c2.img);
        }
        public static Complex operator+(Complex c, int n)
        {
            return new Complex(c.real + n, c.img + n);
        }
        public static Complex operator+(int n, Complex c)
        {
            return new Complex(c.real + n, c.img + n);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.real - c1.real, c2.img - c2.img);
        }
        public static Complex operator -(Complex c, int n)
        {
            return new Complex(c.real - n);
        }
        public static Complex operator -(int n, Complex c)
        {
            return new Complex(c.real -  n);
        }
        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.real > c2.real && c1.img > c2.img;
        }
        public static bool operator <(Complex c1, Complex c2)
        {
            return !(c1 > c2) && !(c1 == c2);
        }
        
        public static bool operator ==(Complex c1, Complex c2)
        {
            return (c1.real == c2.real) && (c1.img == c2.img);
        }
        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }
        
        public static Complex operator++(Complex c)
        {
            return new Complex(c.real++, c.img++);
        }
        public static Complex operator--(Complex c)
        {
            return new Complex(c.real--, c.img++);
        }

        public static implicit operator Complex(int x)
        {
            return new Complex(x);
        }

        public static explicit operator int(Complex c)
        {
            return c.real;
        }
    }
}
