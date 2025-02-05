using System.Security.Principal;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = new int[2];
            sizes = SetSize();

            int[,] arr = new int[sizes[0], sizes[1]];
            arr = ScanArr(arr);

            PrintArr(arr);

            int[] sumOfEachRow = GetSumOfEachRow(arr);
            Console.WriteLine();
            PrintSumOfEachRow(sumOfEachRow);

            Console.WriteLine();
            int[] avgOfEachColumn = GetAvgOfEachColumn(arr);
            PrintAvgForEachColumn(avgOfEachColumn);
            Console.WriteLine();

            PrintMaxStudent(GetIndexOfMaxStudentForEachCourse(arr));    
        }

        static int[] SetSize()
        {
            int[] arr = new int[2];
            Console.Write($"Enter Number Of Students: ");
            arr[0] = int.Parse(Console.ReadLine());
            Console.Write($"Enter Number Of Courses: ");
            arr[1] = int.Parse(Console.ReadLine());

            return arr;
        }
        static int[,] ScanArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Student [{i+1}], Course [{j+1}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            return arr;
        }

        static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"Student [{i + 1}]:");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"\t{arr[i,j]}\t");
                }
                Console.WriteLine();
            }
        }
        static int[] GetSumOfEachRow(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(0)];
            for (int i = 0; i < sum.Length; i++)
                sum[i] = 0;

            for(int i = 0;i < arr.GetLength(0); i++)
            {
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    sum[i] += arr[i, j]; 
                }
            }
            return sum;
        }

        static void PrintSumOfEachRow(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"Sum Of Student[{i+1}]: {arr[i]}\t\n");
        }

        static int[] GetSumOfEachColumn(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(1)];
            for (int i = 0; i < sum.Length; i++)
                sum[i] = 0;

            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sum[i] += arr[j, i];
                }
            }
            return sum;
        }

        static int[] GetAvgOfEachColumn(int[,] arr)
        {
            int[] sums = GetSumOfEachColumn(arr);
            int[] avg = new int[arr.GetLength(1)];
            for (int i = 0; i < sums.Length; i++)
            {
                avg[i] = sums[i] / arr.GetLength(0);
            }
            return avg;
        }

        static void PrintAvgForEachColumn(int[] avgs)
        {

            for (int i = 0; i < avgs.Length; i++)
                Console.WriteLine($"Average Of Course [{i+1}]: {avgs[i]} ");
        }
        
        static int[] GetIndexOfMaxStudentForEachCourse(int[,] arr)
        {
            int[] indexes = new int[arr.GetLength(1)]; 

            for (int j = 0; j < arr.GetLength(1); j++) 
            {
                int maxIndex = 0; 
                int maxValue = arr[0, j]; 

                for (int i = 1; i < arr.GetLength(0); i++) 
                {
                    if (arr[i, j] > maxValue) 
                    {
                        maxValue = arr[i, j];
                        maxIndex = i; 
                    }
                }
                indexes[j] = maxIndex;
            }

            return indexes;
        }
        static void PrintMaxStudent(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
