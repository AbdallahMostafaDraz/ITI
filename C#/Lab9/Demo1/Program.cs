using System.Diagnostics;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Call Generic Swap Function
            
            int n1 = 10; int n2 = 20;
            Swap(ref n1,ref n2);
            Console.WriteLine($"n1: {n1}, n2: {n2}");

            float f1 = 10.5f, f2 = 5.5f;
            Swap(ref f1, ref f2);
            Console.WriteLine($"f1: {f1}, f2: {f2}");

            string s1 = "Abdallah", s2 = "Mostafa";
            Swap(ref s1,ref s2);
            Console.WriteLine($"s1: {s1}, s2: {s2}");
           

            // 2) Generic List
            
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Capacity = 5;
            numbers.Add(50);
            Console.WriteLine($"Capaicty: {numbers.Capacity}");
            
            List<Point> points = new List<Point>();
            points.Add(new Point(50));
            points.Add(new Point(100));
            points.Add(new Point(150));
            foreach(var item in points)
                Console.WriteLine(item);
            */

            
        }

        class Point
        {
            public int n;
            public Point(int _n) => n = _n;

            public override string ToString()
            {
                return n.ToString();
            }
        }
        static void Swap<T>(ref T item1, ref T item2)
        {
            T temp = item1;
            item1 = item2;
            item2 = temp;
        }
    }
}
