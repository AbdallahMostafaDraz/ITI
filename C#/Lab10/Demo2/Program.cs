namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine($"Dequeue: {queue.Dequeue()}");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine($"Pop: {stack.Pop()}");

           
            Dictionary<string, string> person = new Dictionary<string, string>();
            person.Add("Name", "Abdallah");
            person.Add("Country", "Egypt");
            person.Add("City", "Cairo");
            Console.WriteLine($"\nDictionary: ");
            foreach (var key in person.Keys)
            {
                Console.WriteLine($"{key}: {person[key]}");
            }


            HashSet<string> keys = new HashSet<string>();
            keys.Add("Abdallah");
            keys.Add("Mostafa");
            keys.Add("Abdallah");
            Console.WriteLine($"\nHashSet: ");
            foreach (var item in keys)
            {
                Console.WriteLine(item);
            }

            SortedList<int, string> sList = new SortedList<int, string>();
            sList.Add(3, "Abdallah");
            sList.Add(1, "Mohamed");
            sList.Add(2, "Ahmed");
            foreach(var item in sList)
                { Console.WriteLine(item); }
        }
    }
}
