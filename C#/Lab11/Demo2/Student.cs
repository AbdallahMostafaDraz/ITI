using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int absentDays { get; set; }
        int failSubject {  get; set; }  

        public event Action<Student> FireStudent;
        
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void IncreaseAbsentDays()
        {
            absentDays++;
            if (absentDays > 3)
                FireStudent?.Invoke(this);
        }
        public void IncreaseFailSubjects()
        {
            failSubject++;
            if (failSubject > 3)
                FireStudent?.Invoke(this);
        }

        public override string ToString()
        {
            return $"[{Id}]: {Name}";
        }


    }
}
