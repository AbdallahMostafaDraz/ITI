using System.Threading.Channels;

namespace Demo2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            // ==================== Employee ========================
            /*
            Employee employee1 = new Employee(1, "Abdullah");
            Console.WriteLine(employee1);
            employee1.SetAge(34);
            employee1.SetSalary(50000);
            employee1.Print();
            employee1.SetAge(24);
            employee1.Print();

            Employee employee2 = new Employee(2, "Ahmed", 35);
            
            employee2.SetAge(25);
            employee2.SetName("AH");
            employee2.Print();

            Employee employee3 = new Employee(3, "Mahmoud", 30, 4000);
            employee3.Print();
            employee3.SetSalary(7000);
            employee3.Print();
            */

            // =================== BankAccount =======================
            
            BankAccount[] accounts = new BankAccount[3];
            
            accounts[0] = new BankAccount(1, "Abdallah");
            accounts[0].Deposit(10000);
            accounts[0].Withdraw(2000);

            accounts[1] = new BankAccount(2, "Ahmed", 5000);
            accounts[1].Withdraw(3000);
            accounts[1].Withdraw(1500);

            accounts[2] = new BankAccount(3, "Mostafa", 6000);
            accounts[2].Deposit(1000);
            accounts[2].Withdraw(500);

            foreach(var account in accounts) 
                account.Print();
            
            // ==================== Car =============================
            /*
            Car car = new Car("BMW", "White", 300);
            car.AccelerateSpeed();
            car.DeAcclerateSpeed();
            car.DeAcclerateSpeed();
            car.AccelerateSpeed();
            car.Print();
            */


            // =================== Complex ==========================
            Complex complex = new Complex(5, 7);
            complex.Print();
            complex.SetReal(3);
            complex.SetReal(2);
            complex.Print();
            Console.WriteLine($"Real: {complex.GetReal()}");
            Console.WriteLine($"Imagine: {complex.GetImagine()}J");
        }
    }
}
