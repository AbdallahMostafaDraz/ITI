namespace Demo1
{
    public class Employee : Person
    {
        int salary;
        static int counter;

        public Employee(int _id, string _name, int _age, int _salary = 6000) : base(_id, _name, _age)
        {
            SetSalary(_salary);
            counter++;
        }

        public override void SetAge(int _age)
        {
            if (_age >= 30 &&  _age <= 60)
                base.SetAge(_age);
            else
            {
                Console.WriteLine($"Age Of Employee Must Be In Range 30 To 60!");
                base.SetAge(30); // 30 default value
            }
        }

        public void SetSalary(int _salary)
        {
            if (_salary >= 6000 )
                salary = _salary;
            else
            {
                Console.WriteLine("Minimum Salary Is 6000 EGP!");
            }
        }

        public int GetSalarry() {  return salary; }
        
        public static int GetCounter() {  return counter; }
        public override void Print()
        {
            Console.WriteLine($"Employee: [{GetId()}], {GetName()}, {GetAge()} Years, {salary} EGP");
        }
    }
}
