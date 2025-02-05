using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Employee : Person
    {
        int salary;
        static int counter;

        public Employee(int _id, string _name, int _age, int _salary) : base(_id, _name, _age)
        {
            SetSalary(_salary);
            counter++;

        }
        public override void SetAge(int _age)
        {
            if (_age >= 30 && _age <= 60)
                base.SetAge(_age);
            else
            { 
                Console.WriteLine("Age Of Emplyee Range 30:60 !");
                base.SetAge(30);
            }
        }
        public void SetSalary(int _salary)
        {
            if (_salary >= 6000)
                salary = _salary;
            else
            {
                Console.WriteLine("Minimum Of Salary 6000 EGP!");
                salary = 6000;
            }
        }

        public int GetSalary() { return salary; }

        public new static int GetCounter() { return counter; }

        public override void Print()
        {
            Console.WriteLine($"Employee: [{GetId()}], [{GetName()}], [{GetAge()}], {GetSalary()} EGP");
        }
    }
}
