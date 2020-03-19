using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPumox.Models
{
    public class Search
    {
        public string Keyword { get; set; }
        public DateTime EmployeeDateOfBirthFrom { get; set; }
        public DateTime EmployeeDateOfBirthTo { get; set; }

        public PositionName EmployeeJobTitles { get; set; }
    }
}
