namespace Demo2
{
    public class Rectangle : Shape
    {
        public Rectangle(int _dim1, int _dim2): base(_dim1, _dim2)
        { }

        public sealed override float Area()
        {
            return GetDim1() * GetDim2();
        }
    }
}
