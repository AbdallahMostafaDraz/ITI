namespace Demo1
{
    public class Employee
    {
        int id;
        string name;
        int age;
        float salary;

        public void SetId(int _id) { id = _id; }
        public int GetId() { return id; }

        public void SetName(string _name)
        {
                name = _name;
        }
        public string GetName() { return name; }

        public void SetAge(int _age)
        {
            if (_age < 30)
                Console.WriteLine("Minimum Of Age Is 30 Year!");
            else
                age = _age;
        }
        public int GetAge() { return age; }

        public void SetSalary(float _salary)
        {
            if (_salary < 6000)
                Console.WriteLine("Minimum Of Salary Is 6000 EGP!");
            else
                salary = _salary;
        }
        public float GetSalary() { return salary; }

        public Employee() : this(0, "No Name", 30, 6000)
        {
        }

        public Employee(int _id, string _name): this(_id, _name, 30, 6000)
        {
        }

        public Employee(int _id, string _name, int _age) : this(_id, _name, _age, 6000)
        {
        }

        public Employee(int _id, string _name, int _age, float _salary) 
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            SetSalary(_salary);
        }

        
        public override string ToString()
        {
            return $"[{id}]: {name}, {age} Years, {salary} EGP ";
        }
    }
}
