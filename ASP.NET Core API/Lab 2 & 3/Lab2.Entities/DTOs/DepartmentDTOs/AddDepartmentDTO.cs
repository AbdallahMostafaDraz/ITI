using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Entities.DTOs.DepartmentDTOs
{
    public class AddDepartmentDTO : DepartmentDTO
    {
        public int? ManagerId { get; set; }
        public DateOnly? ManagerHireDate { get; set; }
    }
}
