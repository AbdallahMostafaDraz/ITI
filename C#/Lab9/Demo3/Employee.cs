﻿namespace Demo3
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Salary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"[{Id}]: {Name}, {Salary} EGP";
        }
    }
}
