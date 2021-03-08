using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegosudAPI.Models;

namespace NegosudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamillesController : ControllerBase
    {
        private readonly ToDoContext _context;

        public FamillesController(ToDoContext context)
        {
            _context = context;
        }

        // GET: api/Familles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Familles>>> GetFamilles()
        {
            return await _context.Familles.ToListAsync();
        }

        // GET: api/Familles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Familles>> GetFamilles(long id)
        {
            var familles = await _context.Familles.FindAsync(id);

            if (familles == null)
            {
                return NotFound();
            }

            return familles;
        }

        // PUT: api/Familles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamilles(long id, Familles familles)
        {
            if (id != familles.Id)
            {
                return BadRequest();
            }

            _context.Entry(familles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamillesExists(id))
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

        // POST: api/Familles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Familles>> PostFamilles(Familles familles)
        {
            _context.Familles.Add(familles);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFamilles", new { id = familles.Id }, familles);
        }

        // DELETE: api/Familles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamilles(long id)
        {
            var familles = await _context.Familles.FindAsync(id);
            if (familles == null)
            {
                return NotFound();
            }

            _context.Familles.Remove(familles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamillesExists(long id)
        {
            return _context.Familles.Any(e => e.Id == id);
        }
    }
}
