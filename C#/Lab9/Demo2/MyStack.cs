namespace Demo2
{

    public class MyStack<T>  : MyCollection<T>
    {
        public MyStack(int _capacity) : base(_capacity)
        {           
        }
        public void Push(T item)
        {
            
            if (top <  Capacity - 1) 
                arr[++top] = item;
            else
                Console.WriteLine("Stack Is Full");
        }
        public T Pop()
        {
            if (top == -1)
                throw new InvalidOperationException("Stack Is Empty!");
            else
                return arr[top--];
        }

        
    }
}
