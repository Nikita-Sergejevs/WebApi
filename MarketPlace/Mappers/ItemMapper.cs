using MarketPlace.Dtos.Item;
using MarketPlace.Models;

namespace MarketPlace.Mappers
{
    public static class ItemMappers
    {
        public static ItemDto ToItemDto(this Item itemModel)
        {
            return new ItemDto
            {
                Id = itemModel.Id,
                Price = itemModel.Price,
                Name = itemModel.Name,    
            };
        }

        public static Item ToItemFromCreatDTO(this CreatItemRequestDto itemDto)
        {
            return new Item
            {
                Price = itemDto.Price,
                Name = itemDto.Name
            };
        }
    }
}