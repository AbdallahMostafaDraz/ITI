namespace Demo2
{
    public class MyList<T> : MyCollection<T>
    {
        public MyList(int _capacity = 4) : base(_capacity) { }
        
        public void Add(T value)
        {
            if (top < Capacity - 1)
                arr[++top] = value;
            else
            {
                T[] tempArr = arr;
                arr = new T[Capacity * 2];
                for (int i = 0; i < tempArr.Length; i++)
                    arr[i] = tempArr[i];
                arr[++top] = value;
                Capacity *= 2;
            }
        }

        public void Remove(T value)
        {
            for (int i = 0; i < top; i++)
            {
                if (value.Equals(arr[i]))
                {
                    for (int j = i; j < top; j++)
                        arr[j] = arr[j + 1];
                    top--;
                    break;
                }
            }
        }

        public void RemoveAt(int index)
        {
            for (int j = index; j < top; j++)
                arr[j] = arr[j + 1];
            top--;
        }

      
    }
}
