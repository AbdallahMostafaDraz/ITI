using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new();

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddStudent(Student student) 
        {
            Students.Add(student);
            student.FireStudent += RemoveStudent;
        }
        public void RemoveStudent(Student student)
        {
            Students.Remove(student);
            Console.WriteLine($"{student.Name} Removed From {Name} Department");
        }

        public override string ToString()
        {
            string s = $"[{Id}]: {Name}, Has The Following Students:\n";
            foreach(var student in Students)
                s += $"{student.ToString()}\n";
            return s;
        }
    }
}
