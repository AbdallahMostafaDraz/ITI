namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[SetSize()];            
            arr = ScanArr(arr);
            
            PrintArr(arr);
            Console.WriteLine($"\nSum Of Array: {GetSum(arr)}");
            Console.WriteLine($"Max Of Array: {GetMax(arr)}");
            Console.WriteLine($"Min Of Array: {GetMin(arr)}");
            

            int valueToSearch;
            Console.Write($"Enter Value To Search: ");
            valueToSearch = int.Parse(Console.ReadLine());
            int index = Find(valueToSearch, arr);
            if (index != -1)
                Console.WriteLine($"{valueToSearch} is exist in index[{index}]");
            else
                Console.WriteLine($"{valueToSearch} is not exist in array!");
        }
        static int SetSize()
        {
            Console.Write($"Enter Size Of Array: ");
            return int.Parse(Console.ReadLine());
        }
        static int[] ScanArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Element[{i+1}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        static void PrintArr(int[] arr)
        {
            Console.Write($"\nArray:\t");
            for(int i = 0;i < arr.Length;i++)
            {
                Console.Write($"{arr[i]}\t");
            }
        }
        static int GetSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int GetMax(int[] arr)
        {
            int max = arr[0]; 
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }
        static int Find(int value, int[] arr)
        {
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                { 
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
