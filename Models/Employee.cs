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
        public Int64 EmployeeId { get; set; }
        public string FirstName { get; set; }

        public string SurName { get; set; }

        public DateTime BirthdayDate { get; set; }

        public PositionName Name { get; set; }

        public Int64 CompanyId { get; set; }
    }
}
