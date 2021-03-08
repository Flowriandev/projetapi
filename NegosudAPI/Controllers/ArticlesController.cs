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
    [Route("api/Articles")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ToDoContext _context;

        public ArticlesController(ToDoContext context)
        {
            _context = context;
        }

        // GET: api/Articles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Articles>>> GetArticles()
        {
            return await _context.Articles.ToListAsync();
        }

        // GET: api/Articles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Articles>> GetArticles(long id)
        {
            var articles = await _context.Articles.FindAsync(id);

            if (articles == null)
            {
                return NotFound();
            }

            return articles;
        }

        // PUT: api/Articles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticles(long id, Articles articles)
        {
            if (id != articles.Id)
            {
                return BadRequest();
            }

            _context.Entry(articles).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticlesExists(id))
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

        // POST: api/Articles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Articles>> PostArticles(Articles articles)
        {
            _context.Articles.Add(articles);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetArticles), new { id = articles.Id }, articles);
        }

        // DELETE: api/Articles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticles(long id)
        {
            var articles = await _context.Articles.FindAsync(id);
            if (articles == null)
            {
                return NotFound();
            }

            _context.Articles.Remove(articles);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticlesExists(long id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
