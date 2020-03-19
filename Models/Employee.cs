using System;
using System.Collections.Generic;
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
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public PositionName JobTitle { get; set; }
    }
}
