namespace Demo2
{
    public class Traingle : Shape
    {
        public Traingle(int _base, int _height) : base(_base, _height)
        {
        }

        public override float Area(int _base, int _height)
        {
            return 0.5f * _base * _height;
        }

        public override void Print()
        {
            Console.WriteLine($"Base = {GetDim1()}, Height = {GetDim2()} => Area = {Area(GetDim1(), GetDim2())}");
        }
    }
}
