namespace Demo2
{
    public class Square : Rectangle
    {
        public Square(int _dim) : base(_dim, _dim) { }

        public override void SetDim1(int _dim1)
        {
            base.SetDim1(_dim1);
            base.SetDim2(_dim1);
        }

        public override void SetDim2(int _dim2)
        {
            base.SetDim2(_dim2);
            base.SetDim1(_dim2);
        }
    }
}
