using System.Diagnostics;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsNumber, coursesNumber;
            Console.Write("Enter Number of Students: ");
            studentsNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter Number of Courses: ");
            coursesNumber = int.Parse(Console.ReadLine());

            int[,] arr = new int[studentsNumber, coursesNumber];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0;  j < arr.GetLength(1); j++)
                {
                    Console.Write($"student[{i+1}] in course[{j+1}]: ");
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }




            // sum of each row
            int[] sumOfStudent = new int[studentsNumber];
            for (int i = 0; i < sumOfStudent.Length; i++)
                sumOfStudent[i] = 0;

            // sum of each column
            int[] sumOfCourse = new int[coursesNumber];


            for(int i = 0; i  < sumOfCourse.Length; i++)
                sumOfCourse[i] = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"Student[{i + 1}]:\t");
                for(int j = 0;j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                    sumOfStudent[i] += arr[i, j];
           
                }
                Console.WriteLine($"| sum = {sumOfStudent[i]}");
                Console.WriteLine();
            }
            
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    sumOfCourse[i] += arr[j, i];
                }
              }


            Console.Write($"         \t--\t--\t--\n\navg      ");
            for (int i = 0; i < sumOfCourse.Length; i++)
            {
                Console.Write($"       {sumOfCourse[i] / studentsNumber}");
                    
            }

            int x = 0, y = 0;
            
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j <arr.GetLength(1); j++)
                {
                    if (arr[i, j] > arr[x, y])
                    {
                        x = i;
                        y = j;
                    }
                }
            }
            Console.WriteLine($"\n\nMax Degree at index [{x}][{y}]");
        }
    }
}
