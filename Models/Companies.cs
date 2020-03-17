using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestPumox.Models
{
    public class Companies
    {
        public Int64 CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int FoundationYear { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
