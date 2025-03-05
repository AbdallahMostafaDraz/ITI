using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSummary.Models
{
    public class EmployeeV2
    {
        public string Name { get; set; } = string.Empty;

        public override string ToString()
        {
            return Name;
        }
    }
}
