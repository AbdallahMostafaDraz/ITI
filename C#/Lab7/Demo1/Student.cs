using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public class Student : Person
    {
        int grade;
        static int counter;

        public Student(int _id, string  _name, int _age, int _grade) : base(_id, _name,_age)
        {
            SetGrade(_grade);
            counter++;
        }

        public override void SetAge(int _age)
        {
            if (_age >= 6 && _age <= 25)
                base.SetAge(_age);
            else
            {
                Console.WriteLine("Age Of Student Range 6:25 !");
                base.SetAge(6);
            }
        }
        public void SetGrade(int _grade)
        {
            if (_grade > 0)
                grade = _grade;
            else
            {
                Console.WriteLine("Grade Not Allowed Zero!");
                grade = 6;
            }
        }
        public int GetGrade() { return grade; }

        public new static int GetCounter() { return counter; }


        public override void Print()
        {
            Console.WriteLine($"Student: [{GetId()}], [{GetName()}], [{GetAge()}], {GetGrade()}");
        }


    }
}
