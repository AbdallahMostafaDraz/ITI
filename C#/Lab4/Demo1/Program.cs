namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20, n3 = 30;
            
            Console.WriteLine($"Call 1: {Add(n1, n2)}");
            Console.WriteLine($"Call 2: {Add(n1, n2, n3)}");
            Console.WriteLine($"Call 3(ref): {Add(ref n1, ref n2)}");
            Console.WriteLine($"Call 4(out): {Add(n1, n2, out n3)}");
            Console.WriteLine($"Call 5: {Add(10.2f, 20.5f)}");
            Console.WriteLine($"Call 6: {Add(10.2f, n1)}");
            Console.WriteLine($"Call 7: {Add(n1, 10.2f)}");
            Console.WriteLine($"Call 8: {Add(10.5, 11.5)}");
        }

        // 1
        static int Add(int n1, int n2) { return n1 + n2; }
        // 2
        static int Add(int n1, int n2, int n3) { return n1 + n2 + n3; }
        // 3
        static int Add(ref int n1, ref int n2) { return n1 + n2; }
        // 4
        static int Add(int n1, int n2, out int result) 
        {
            return result = n1 + n2; 
        }
        // 5
        static float Add(float n1, float n2) { return n1 + n2; }
        // 6
        static float Add(float n1, int n2) { return  n1 + n2; }
        // 7
        static float Add(int n1, float n2) { return n1 + n2; }
        // 8
        static double Add(double n1, double n2) { return n1 + n2; }
    }
}
