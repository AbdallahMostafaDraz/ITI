namespace Demo2
{
    public class Traingle : Shape
    {
        public Traingle(int _dim, int _dim2) : base (_dim, _dim2) { }

        public override float Area()
        {
            return 0.5f * GetDim1() * GetDim2();
        }
    }
}
