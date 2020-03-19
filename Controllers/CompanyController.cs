using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using TestPumox.Data;
using TestPumox.Models;

namespace TestPumox.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly TestPumoxContext _context;

        public CompanyController(TestPumoxContext context)
        {
            _context = context;
        }

        // GET: company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompany()
        {
            // return await _context.Company.ToListAsync();
            return await _context.Company.Include(s => s.Employees).ToListAsync();
        }

        // GET: company/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(long id)
        {
            var company = _context.Company
                .Where(s => s.Id == id)
                .Include(s => s.Employees)
                .FirstOrDefault();

            // var company = await _context.Company.FindAsync(id);

            if (company == null)
            {
                return NotFound();
            }

            // var employee = await _context.Employee.FindAsync(id);
            // company.Employees.Add(employee);

            return company;
        }

        // PUT: company/5
        [HttpPut("update/{id}")]
        public async Task<IActionResult> PutCompany(long id, Company company)
        {
            if (id != company.Id)
            {
                return BadRequest();
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCompany", new { id = company.Id }, "Id: " + company.Id + " updated");
        }

        // POST: company/create
        [HttpPost("create")]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            _context.Company.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompany", new { id = company.Id }, "Id: " + company.Id);
        }

        // POST: company/search
        [HttpPost("search")]
        public async Task<IIncludableQueryable<Company, List<Employee>>> SearchCompany(Search search)
        {
            
            var company = _context.Company
                .Where(s => s.Name.Contains(search.Keyword))
                .Include(s => s.Employees);


            return company;
            // return CreatedAtAction("GetCompany", new { id = company.Id }, "Id: " + company.Id);
        }

        // DELETE: company/5
        [HttpDelete("delete/{id}")]
        public async Task<ActionResult<Company>> DeleteCompany(long id)
        {
            var company = await _context.Company.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Company.Remove(company);
            await _context.SaveChangesAsync();

            return company;
        }

        private bool CompanyExists(long id)
        {
            return _context.Company.Any(e => e.Id == id);
        }
    }
}
