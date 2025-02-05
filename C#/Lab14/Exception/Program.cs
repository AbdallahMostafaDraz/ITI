namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2;
            
            try
            {
                do
                {
                    Console.Write("First Number: ");
                } while (!(int.TryParse(Console.ReadLine(), out num1)));

                do
                {
                    Console.Write("Second Number: ");
                } while (!(int.TryParse(Console.ReadLine(), out num2)) || num2 == 0);

                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            /*
            
            try
            {
                Console.Write("First Number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Second Number: ");
                num2 = int.Parse(Console.ReadLine());
                if (num2 == 1000)
                    throw new MyCustomException("num 2 must be less 1000");
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cann't Divde By Zero!");
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect Number Format!");
            }
            catch (MyCustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error!");
            }
            */


        }

        class MyCustomException : Exception
        {
            public MyCustomException(string message) : base(message) { } 
        }
    }
}
