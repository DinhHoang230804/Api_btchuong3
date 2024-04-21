using Btchuong3.Data;
using Btchuong3.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Btchuong3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PublishersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Publishers>> GetPublishers()
        {
            return _context.publishers.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Publishers> GetPublishers(int id)
        {
            var publishers = _context.publishers.Find(id);

            if (publishers == null)
            {
                return NotFound();
            }
            return publishers;
        }

        [HttpPost]
        public IActionResult PostPublishers(Publishers publishers)
        {
            _context.publishers.Add(publishers);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPublishers), new { id = publishers.ID }, publishers);
        }

        [HttpPut("{id}")]
        public IActionResult PutPublishers(int id, Publishers publishers)
        {
            if (id != publishers.ID)
            {
                return BadRequest();
            }

            _context.Entry(publishers).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePublishers(int id)
        {
            var publishers = _context.publishers.Find(id);

            if (publishers == null)
            {
                return NotFound();
            }

            _context.publishers.Remove(publishers);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
