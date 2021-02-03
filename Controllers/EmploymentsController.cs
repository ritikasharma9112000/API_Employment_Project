using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Employment_Project.Data;
using API_Employment_Project.Model;

namespace API_Employment_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentsController : ControllerBase
    {
        private readonly Database _context;

        public EmploymentsController(Database context)
        {
            _context = context;
        }

        // GET: api/Employments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employment>>> GetEmployment()
        {
            return await _context.Employment.ToListAsync();
        }

        // GET: api/Employments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employment>> GetEmployment(int id)
        {
            var employment = await _context.Employment.FindAsync(id);

            if (employment == null)
            {
                return NotFound();
            }

            return employment;
        }

        // PUT: api/Employments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployment(int id, Employment employment)
        {
            if (id != employment.id)
            {
                return BadRequest();
            }

            _context.Entry(employment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employment>> PostEmployment(Employment employment)
        {
            _context.Employment.Add(employment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployment", new { id = employment.id }, employment);
        }

        // DELETE: api/Employments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployment(int id)
        {
            var employment = await _context.Employment.FindAsync(id);
            if (employment == null)
            {
                return NotFound();
            }

            _context.Employment.Remove(employment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmploymentExists(int id)
        {
            return _context.Employment.Any(e => e.id == id);
        }
    }
}
