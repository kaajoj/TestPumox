using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestPumox.Models;

namespace TestPumox.Data
{
    public class TestPumoxContext : DbContext
    {
        public TestPumoxContext (DbContextOptions<TestPumoxContext> options)
            : base(options)
        {
        }

        public DbSet<TestPumox.Models.Company> Company { get; set; }

        public DbSet<TestPumox.Models.Employee> Employee { get; set; }
    }
}
