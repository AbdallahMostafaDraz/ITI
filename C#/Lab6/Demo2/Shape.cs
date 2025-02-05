namespace Demo2
{
    public abstract class Shape
    {
        int dim1, dim2;

        public Shape(int dim1 = 1, int dim2 = 1)
        {
            SetDim1(dim1);
            SetDim2(dim2);
        }

        public void SetDim1(int _dim1)
        {
            if (_dim1 > 0)
                 dim1 = _dim1;
            else
                Console.WriteLine("Dim Must Be More Than 0!");
        }
        public int GetDim1() { return dim1;}
        
        public virtual void SetDim2(int _dim2)
        {
            if (_dim2 > 0)
                dim2 = _dim2;
            else
                Console.WriteLine("Dim Must Be More Than 0!");
        }
        public int GetDim2() { return dim2;}

        public abstract float Area(int _dim1, int _dim2 = 1); 

        public virtual void Print()
        {
            Console.WriteLine($"Dim1 = {dim1}, Dim2 = {dim2} => Area = {Area(dim1, dim2)}");
        }
    }
}
