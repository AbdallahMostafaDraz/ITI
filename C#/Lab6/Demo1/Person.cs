namespace Demo1
{
    public class Person
    {
        int id, age;
        string name;
        public static int personCounter;
        public Person(int id, string name, int age)
        {
            SetId(id);
            SetName(name);
            SetAge(age);
            personCounter++;
        }
        public static int GetPersonCounter() { return personCounter; }
       
        public void SetId(int _id)
        {
            if (_id > 0)
                id = _id;
            else
                Console.WriteLine("Id Not Allows Negative Values!");
        }
        public int GetId() { return id; }

        public void SetName(string _name)
        {
            if (_name.Length > 2)
                name = _name;
            else
                Console.WriteLine("Name Must Be More Than 2 Characters!");
        }
        public string GetName() { return name; }

        public virtual void SetAge(int _age)
        {
            if (_age > 0 && _age < 100)
                age = _age;
            else
                Console.WriteLine("Age Of Person Must Be In Range 0 To 100");
        }
        public int GetAge() { return age; }

        public virtual void Print()
        {
            Console.WriteLine($"Person: [{id}], {name}, {age} Years");
        }
    }
}
