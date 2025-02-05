namespace Demo2
{
    public abstract class MyCollection<T>
    {
        protected T[] arr;
        public int Capacity { get; set; }
        protected int top;
        public MyCollection(int _capacity)
        {
            Capacity = _capacity;
            top = -1;
            arr = new T[Capacity];
        }
        public void Clear() => top = -1;
       
        public bool IsFound(T value)
        {
            for (int i = 0; i < top;i++)
            {
                if (arr[i].Equals(value))
                    return true;
            }
            return false;
        }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i <= top; i++)
                s += $"{arr[i]}\t";
            return s;
        }
    }
}
