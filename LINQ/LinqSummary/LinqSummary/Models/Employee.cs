﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSummary.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }

       
        public override string ToString()
        {
            return $"[{Id}] : {Name} - ({Salary})EGP";
        }
    }
}
