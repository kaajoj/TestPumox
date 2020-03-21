using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPumox.Models
{
    public enum PositionName
    {
        Administrator,
        Developer,
        Architect,
        Manager
    }

    public class Employee
    {
        public long EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public PositionName JobTitle { get; set; }

        public long CompanyId { get; set; }
    }
}
