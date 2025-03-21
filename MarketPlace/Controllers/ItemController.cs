using MarketPlace.Data;
using MarketPlace.Dtos.Item;
using MarketPlace.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace MarketPlace.Controllers
{
    [Route("MarketPlace/Item")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly DataContext _context;
        public ItemController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var items = _context.Items.ToList().Select(s => s.ToItemDto());

            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var items = _context.Items.Find(id);

            if (items == null)
                return NotFound();
            
            return Ok(items.ToItemDto());
        }

        [HttpPost]
        public IActionResult Creat([FromBody] CreatItemRequestDto itemDto)
        {
            var itemModel = itemDto.ToItemFromCreatDTO();
            _context.Items.Add(itemModel);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = itemModel.Id}, itemModel.ToItemDto());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute] int id, [FromBody] UpdaItemRequestDto updateDto)
        {
            var itemModel = _context.Items.FirstOrDefault(x => x.Id == id);

            if (itemModel == null)
                return NotFound();
            
            itemModel.Name = updateDto.Name;
            itemModel.Price = updateDto.Price;

            _context.SaveChanges();

            return Ok(itemModel.ToItemDto());
        }
    }
}