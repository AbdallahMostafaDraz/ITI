using System.Drawing;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic Stack
            /*
            try
            {
                MyStack<int> myStack = new MyStack<int>(5);
                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);
                myStack.Push(40);
                myStack.Push(50);
                myStack.Push(50);
                myStack.Push(50);

                Console.WriteLine($"Pop: {myStack.Pop()}");
                Console.WriteLine($"Stack Elements: {myStack}");
                myStack.Clear();
                Console.WriteLine($"Pop: {myStack.Pop()}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           */

            // Generic List
            MyList<int> myList = new MyList<int>(5);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            Console.WriteLine(myList);
            Console.WriteLine(myList.Capacity);
            myList.Add(6);
            myList.Add(7);
            Console.WriteLine(myList);
            Console.WriteLine(myList.Capacity);
            myList.Remove(5);
            Console.WriteLine(myList);
            myList.RemoveAt(2);
            Console.WriteLine(myList);
            Console.WriteLine(myList.IsFound(2));
            Console.WriteLine(myList.IsFound(22));


        }
    }


}
