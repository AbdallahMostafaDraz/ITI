using System.Security.Cryptography.X509Certificates;

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration duration1 = new Duration(1, 120, 67);
            Console.WriteLine(duration1);

            Duration duration2 = new Duration(3600);
            Console.WriteLine(duration2);

            Duration duration3 = new Duration(7800);
            Console.WriteLine(duration3);

            Duration duration4 = new Duration(666);
            Console.WriteLine(duration4);
            

            Duration d1 = new Duration(3, 189, 59);  
            Duration d2 = new Duration(1, 2, 3);
            // 4 , 191, 62
            // 7, 11, 62
            // 7, 12, 2

            Duration duration5 = d1 + d2;
            Console.WriteLine($"\nd1 + d2: {duration5}");

            Duration duration6 = d2 - d1;
            Console.WriteLine($"\nd2 - d1 = {duration6}");

            // 6, 9, 59
            // 1, 2, 3
            // 5, 7, 56

            d1 = new Duration(3, 10, 20);  // 3, 10, 20
            d2 = new Duration(1, 135, 30); // 3, 15 , 30   // = 5, 10
            duration6 = d2 - d1;
            Console.WriteLine($"\nd2 - d1: {duration6}");

            Console.WriteLine($"\nd1 == d2 : {d1 == d2}");
            Console.WriteLine($"\nd1 != d2 : {d1 != d2}");
            Console.WriteLine($"\nd1 > d2 : {d1 > d2}");
            Console.WriteLine($"\nd1 < d2 : {d1 < d2}");

            duration6 = new Duration(11, 58, 7);
            Console.WriteLine($"\nDuration Before Increas ++ : {duration6}");
            Console.WriteLine($"\nDuration After Increas 1 Minute : {++duration6}");
            Console.WriteLine($"\nDuration After Increas other 1 Minute : {++duration6}");
            Console.WriteLine($"\nDuration After Decreas 1 Minute : {--duration6}");
            Console.WriteLine($"\nDuration After Decreas other 1 Minute : {--duration6}");




        }
    }

}
