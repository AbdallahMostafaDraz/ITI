namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 2, 1, 3, 2, 1 };
            Console.WriteLine(GetMaxDistance(arr));
        }

        static int GetMaxDistance(int[] arr)
        {
            int maxDis = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] == arr[i])
                    {
                        int dis = j - i - 1;
                        if (dis > maxDis)
                            maxDis = dis;
                    }
                }
            }
            return maxDis;
        }
    }
}
