namespace Demo2
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
            if (_name.Length < 3 )
                Console.WriteLine("Minimum Character Of Name 3 Characters!");
            else
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
    
        public Employee(int id, string _name)
        {
            SetId(id);
            SetName(_name);
        }

        public Employee(int _id, string _name, int _age) : this(_id, _name)
        {
            SetAge(_age);
        }

        public Employee(int _id, string _name, int _age, float _salary): this(_id, _name, _age)
        {
            SetSalary(_salary);
        }

        public void Print()
        {
            Console.WriteLine($"[{id}]: {name}, {age} Years, {salary} EGP ");
        }


    }
}
