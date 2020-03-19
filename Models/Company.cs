using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestPumox.Models
{
    public class Company
    {
        public long Id { get; set; }

        [Required] 
        public string Name { get; set; }

        [Required]
        public int EstablishmentYear { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
