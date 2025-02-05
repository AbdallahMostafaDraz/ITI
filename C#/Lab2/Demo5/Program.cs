namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1 , 2, 3, 1, 4, 2, 1, 7, 1, 2 ,1 };
            int maxDis = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == array[i])
                    {
                        int dis = j - i - 1;
                        if (dis > maxDis)
                            maxDis = dis;
                    }    
                }
            }
            Console.WriteLine(maxDis);
        }
    }
}
