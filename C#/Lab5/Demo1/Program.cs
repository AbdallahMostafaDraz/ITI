namespace Demo1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // 1) Employee 
            // ============
            /*
            Employee employee1 = new Employee();
            Console.WriteLine(employee1);

            Employee employee2 = new Employee(1, "Abdallah", 34, 20000);
            Console.WriteLine(employee2);
            employee2.SetAge(24);
            Console.WriteLine(employee2);
            */

            // 2) Complex
            // ===========
            /*
            Complex complex1 = new Complex();
            Console.WriteLine(complex1);
            complex1.SetReal(10);
            complex1.SetImagine(5);
            Console.WriteLine(complex1);
            complex1.SetReal(10);
            complex1.SetImagine(-5);
            Console.WriteLine(complex1);
            Console.WriteLine($"Number Of Objects Created From Complex: {Complex.GetCounter()}");

            Complex complex2 = new Complex(7, 8);
            Console.WriteLine(complex2);
            Console.WriteLine($"Number Of Objects Created From Complex: {Complex.GetCounter()}");
            */


            // 3) Fraction
            // ============
            Fraction fraction = new Fraction();
            fraction.SetNumerator(15);
            fraction.SetDenominator(50);
            fraction.Print();
            fraction.Simplify(fraction.GetNumerator(), fraction.GetDenominator());
            fraction.Print();

        }


    }
}
