namespace Lab11
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<int> list = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15];

            Predicate<int> p1 = delegate (int n) { return n % 2 == 0; };
            var evenList = GetRequiredList(list, p1);

            Console.WriteLine("Even Numbers: ");
            foreach(var item in evenList)
                Console.WriteLine(item);

            Predicate<int> p2 = (int n) => { return n % 2 != 0; };
            var oddList = GetRequiredList(list, p2);

            Console.WriteLine("\nOdd Numbers: ");
            foreach (var item in oddList)
                Console.WriteLine(item);

            p2 += n => n > 5;
            var numbersGreateThan5 = GetRequiredList(list, p2);
            Console.WriteLine("\nNumbers Greater Than 5: ");
            foreach (var item in numbersGreateThan5)
                Console.WriteLine(item);

            p2 += LessThan5;
            var lessThan5 = GetRequiredList(list, p2);
            Console.WriteLine("\nNumbers less Than 5: ");
            foreach (var item in lessThan5)
                Console.WriteLine(item);

        }

        static  bool LessThan5(int n)
        {
            return n < 5;
        }
        static List<T> GetRequiredList<T>(List<T> list, Predicate<T> p)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (p(list[i]))
                    result.Add(list[i]);
            }
            return result;
        }
    }


}
