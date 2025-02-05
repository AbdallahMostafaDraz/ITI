namespace Demo2
{
    public class Square : Shape
    {
        public Square(int _dim) : base(_dim, _dim)
        {
        }

        public virtual void SetDim2(int _dim2)
        {
            if (_dim2 ==  GetDim1())
                SetDim2(_dim2);
            else
                Console.WriteLine("Dim2 Must Be Equal Dim1!");
        }
        public override float Area(int _dim1, int _dim2)
        {
            return _dim1 * _dim1;
        }

        public override void Print()
        {
            Console.WriteLine($"Dim = {GetDim1()} => Area = {Area(GetDim1(), GetDim2())}");
        }
    }
}
