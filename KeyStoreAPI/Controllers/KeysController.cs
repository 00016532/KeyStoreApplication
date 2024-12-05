using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KeyStoreAPI.Data;
using KeyStoreAPI.Models;

namespace KeyStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KeysController : ControllerBase
    {
        private readonly KeyStoreDbContext _context;

        public KeysController(KeyStoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Keys 00016532
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Key>>> GetKeys()
        {
            return await _context.Keys.Include(k => k.User).ToListAsync();
        }

        // GET: api/Keys/{id} 00016532
        [HttpGet("{id}")]
        public async Task<ActionResult<Key>> GetKey(int id)
        {
            var key = await _context.Keys.Include(k => k.User).FirstOrDefaultAsync(k => k.KeyID == id);

            if (key == null)
            {
                return NotFound();
            }

            return key;
        }

        // POST: api/Keys 00016532
        [HttpPost]
        public async Task<ActionResult<Key>> CreateKey(Key key)
        {
            _context.Keys.Add(key);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetKey), new { id = key.KeyID }, key);
        }

        // PUT: api/Keys/{id} 00016532
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateKey(int id, Key key)
        {
            if (id != key.KeyID)
            {
                return BadRequest();
            }

            _context.Entry(key).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KeyExists(id))
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

        // DELETE: api/Keys/{id} 00016532
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKey(int id)
        {
            var key = await _context.Keys.FindAsync(id);
            if (key == null)
            {
                return NotFound();
            }

            _context.Keys.Remove(key);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KeyExists(int id)
        {
            return _context.Keys.Any(e => e.KeyID == id);
        }
    }
}

