﻿namespace Lab1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"ID: [{Id}]\nName: {Name}\nAge:{Age} Years";
        }
    }
}
