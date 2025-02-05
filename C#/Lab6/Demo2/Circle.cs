namespace Demo2
{
    public class Circle : Square
    {
        const float pi = 3.14f;
        public Circle(int _dim) : base(_dim)
        {

        }

        public override float Area(int _dim1, int _dim2)
        {
            return pi * _dim1 * _dim1;
        }
        
       
    }
}
