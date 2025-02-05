namespace Demo2
{
    public abstract class Shape
    {
        int dim1, dim2;
        public Shape(int _dim1, int _dim2)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }

        public virtual void SetDim1(int _dim1) { dim1 = _dim1; }
        public int GetDim1() { return dim1; }

        public virtual void SetDim2(int _dim2) { dim2 = _dim2; }

        public int GetDim2() { return dim2; }

        public abstract float Area();
        
        public void Print()
        {
            Console.WriteLine($"{GetType().Name} - Shape State {dim1}, {dim2}");
        }
    }
}
