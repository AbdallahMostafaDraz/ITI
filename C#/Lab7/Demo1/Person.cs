using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    public abstract class Person
    {
        int id, age;
        string name;
        static int counter;

        public Person(int _id, string _name, int _age)
        {
            SetId(_id);
            SetName(_name);
            SetAge(_age);
            counter++;
        }

        public void SetId(int _id) { id = _id; }
        public int GetId() { return  id; }
        public void SetName(string _name)
        {
            if (_name.Length > 2)
                name = _name;
            else
                Console.WriteLine("Name Must Be More Than 2 Characters!");
        }
        public string GetName() { return name; }
        public virtual void SetAge(int _age) { age = _age;}
        public int GetAge() { return age;}

        public abstract void Print();
        
        public static  int GetCounter() { return counter;}
    }
}
