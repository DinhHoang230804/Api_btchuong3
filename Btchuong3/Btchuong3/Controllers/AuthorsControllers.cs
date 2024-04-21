using Btchuong3.Data;
using Btchuong3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Btchuong3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAuthors()
        {
            return _context.authors.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Author> GetAuthor(int id)
        {
            var author = _context.authors.Find(id);

            if (author == null)
            {
                return NotFound();
            }

            return author;
        }

        [HttpPost]
        public IActionResult PostAuthor(Author author)
        {
            _context.authors.Add(author);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetAuthor), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public IActionResult PutAuthor(int id, Author author)
        {
            if (id != author.Id)
            {
                return BadRequest();
            }

            _context.Entry(author).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            var author = _context.authors.Find(id);

            if (author == null)
            {
                return NotFound();
            }

            _context.authors.Remove(author);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
