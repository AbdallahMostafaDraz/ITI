namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length, sum = 0, max, min;
            Console.Write("Enter Length Of Array: ");
            length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for(int i = 0; i < length; i++)
            {
                Console.Write($"Enter Element[{i}]: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            max = min = arr[0];
            
            for (int i = 0; i < length; i++)
            {
                sum += arr[i];
                if (max < arr[i])
                    max = arr[i];
                if(min > arr[i])
                    min = arr[i];
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine($"\nSum: {sum}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");


            int valueToSearch;
            int index = -1;
            Console.Write("Enter a value to search: ");
            valueToSearch = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++) 
            {
                if (valueToSearch == arr[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
                Console.WriteLine($"{valueToSearch} is exist at index[{index}]");
            else
                Console.WriteLine($"{valueToSearch} is not found!");
        }
    }
}
