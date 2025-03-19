using MarketPlace.Data;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    [Route("MarketPlace/Item")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly DataContext _context;
        public StockController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            var items = _context.Items.ToList();

            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var items = _context.Items.Find(id);

            if (items == null)
                return NotFound();
            
            return Ok(items);
        }
    }
}